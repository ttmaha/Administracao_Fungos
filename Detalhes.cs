using GMap.NET;
using Excel = Microsoft.Office.Interop.Excel;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Threading;
using System.Windows.Forms;
using System.Data;
using System.Text;
using System.Globalization;
using System.Data.OleDb;
using System.Threading;
using System.Windows.Forms;
using System.Collections;


namespace Leitor_de_Mapa
{
    public partial class Detalhes : Form
    {
        string bd = Globais.nomeBD;
        private string data_source = "datasource=localhost;username=root;password=010203;database=db_mind; Convert Zero Datetime=True;";
        
        MySqlConnection Conexao;
        private int? idfungo = Globais.idFungo;
        
        private string nomedafoto;


        public Detalhes()
        {
            InitializeComponent();




        }
        private void SetHeight(ListView listView, int height)
        {
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, height);
            listView.SmallImageList = imgList;
        }
        private void Detalhes_Load(object sender, EventArgs e)
        {

            
            lblIdDetalhes.Text = idfungo.ToString();

            
            lstImages.View = View.Details;
            lstImages.LabelEdit = true;
            lstImages.AllowColumnReorder = true;
            lstImages.FullRowSelect = true;
            lstImages.GridLines = true;


            lstImages.Columns.Add("Nome", 100, HorizontalAlignment.Left);
            lstImages.Columns.Add("idfungo", 100, HorizontalAlignment.Left);

            TopMost = true;

            carregar_fotos();

            lstformulario.View = View.Details;
            lstformulario.LabelEdit = true;
            lstformulario.AllowColumnReorder = true;
            lstformulario.FullRowSelect = true;
            lstformulario.GridLines = true;

            lstformulario.Columns.Add("especie", 40, HorizontalAlignment.Left);
            lstformulario.Columns.Add("Píleo", 80, HorizontalAlignment.Left);
            lstformulario.Columns.Add("Estipe", 80, HorizontalAlignment.Left);
            lstformulario.Columns.Add("Melzier", 50, HorizontalAlignment.Left);
            lstformulario.Columns.Add("KOH", 50, HorizontalAlignment.Left);
            lstformulario.Columns.Add("CottonBlue", 50, HorizontalAlignment.Left);
            lstformulario.Columns.Add("Basidio", 100, HorizontalAlignment.Left);
            lstformulario.Columns.Add("Basidiolo", 100, HorizontalAlignment.Left);
            lstformulario.Columns.Add("Poros", 50, HorizontalAlignment.Left);
            lstformulario.Columns.Add("Form. Esp", 50, HorizontalAlignment.Left);
            lstformulario.Columns.Add("Tam. Esp", 40, HorizontalAlignment.Left);
            lstformulario.Columns.Add("Cor Esp", 50, HorizontalAlignment.Left);
            lstformulario.Columns.Add("Cont. Esp", 60, HorizontalAlignment.Left);
            lstformulario.Columns.Add("Ornam. Esp", 50, HorizontalAlignment.Left);
            lstformulario.Columns.Add("Sist. Hifal", 100, HorizontalAlignment.Left);
            lstformulario.Columns.Add("Estéreis", 40, HorizontalAlignment.Left);
            lstformulario.Columns.Add("Cistidio", 100, HorizontalAlignment.Left);
            lstformulario.Columns.Add("Setas", 50, HorizontalAlignment.Left);
            lstformulario.Columns.Add("Septos", 100, HorizontalAlignment.Left);
            lstformulario.Columns.Add("Pileipelis", 100, HorizontalAlignment.Left);
            lstformulario.Columns.Add("Stipitipelis", 100, HorizontalAlignment.Left);
            lstformulario.Columns.Add("Pleurocistidios", 100, HorizontalAlignment.Left);
            lstformulario.Columns.Add("Queilocistidios", 100, HorizontalAlignment.Left);
            lstformulario.Columns.Add("Adicionais", 100, HorizontalAlignment.Left);
            lstformulario.Columns.Add("Drive", 100, HorizontalAlignment.Left);
            lstformulario.Columns.Add("IUCN", 50, HorizontalAlignment.Left);
            carregar_formulario();
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;


            SetHeight(lstformulario, 45);

        }

        private void btnAdicionarFotos_Click(object sender, EventArgs e)
        {
            
            //ADICIONAR FOTO

            OpenFileDialog OD = new OpenFileDialog();
            OD.FileName = "";
            OD.Filter = " Suported Images|*.jpeg;*.jpeg;*.png";
            if (OD.ShowDialog() == DialogResult.OK)
                pictureBox2.Load(OD.FileName);

            pictureBox2.Enabled = true;
            pictureSumir2.Visible = false;
            pictureSumir.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SALVAR FOTO

            if(pictureBox2.Enabled == false)
            {
                MessageBox.Show("Adicione uma foto");
            }
            else
            {



             if(txtNomeFoto.Text == "")
                {
                    MessageBox.Show("Adicione um nome");
                }
                else
                {
                    try
                    {
                        



                        string idBd = idfungo.ToString() + bd;
                        string nomedigitado = txtNomeFoto.Text;
                        string nomefotoid = idfungo.ToString() + bd.ToString() + nomedigitado;
                        //criar conexao com sql

                        Conexao = new MySqlConnection(data_source);
                        Conexao.Open();
                        MySqlCommand cmd = new MySqlCommand();
                        cmd.Connection = Conexao;
                        cmd.CommandText = "INSERT fungosfotos (idfungos, fotos, nomefoto, nomefotoidfungo) VALUES (@idfungos,@fotos, @nomefoto, @fotoidfungo)";

                        var image = new ImageConverter().ConvertTo(pictureBox2.Image, typeof(byte[]));


                        cmd.Parameters.AddWithValue("@id", idfungo);
                        cmd.Parameters.AddWithValue("@idfungos", idBd);
                        cmd.Parameters.AddWithValue("@nomefoto", txtNomeFoto.Text);
                        cmd.Parameters.AddWithValue("@fotos", image);
                        cmd.Parameters.AddWithValue("@fotoidfungo", nomefotoid);

                        //  cmd.Parameters.AddWithValue("@fotos", txtIdImage.Text);


                        cmd.Prepare();
                        cmd.ExecuteNonQuery();


                        MessageBox.Show("Foto adicionada com Sucesso!",
                                        "Sucesso!", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);


                        carregar_fotos();

                        txtNomeFoto.Text = String.Empty;

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Não use nomes duplicados para as fotos do mesmo fungo \n" + ex.Message);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ocorreu: " + ex.Message,
                                   "Error",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                    }
                    finally
                    {

                        Conexao.Close();
                    }
                }


            }

        }



        private void carregar_formulario()
        {
            try
            {
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();
                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Conexao;
                cmd.CommandText = "SELECT * FROM " + bd + " WHERE id = @id ";
                cmd.Parameters.AddWithValue("@id", lblIdDetalhes.Text);
                cmd.Prepare();
                MySqlDataReader reader = cmd.ExecuteReader();
                lstformulario.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                        
                        reader.GetString(6),
                        reader.GetString(9),
                        reader.GetString(10),
                        reader.GetString(11),
                        reader.GetString(12),
                        reader.GetString(13),
                        reader.GetString(14),
                        reader.GetString(15),
                        reader.GetString(16),
                        reader.GetString(17),
                        reader.GetString(18),
                        reader.GetString(19),
                        reader.GetString(20),
                        reader.GetString(21),
                        reader.GetString(22),
                        reader.GetString(23),
                        reader.GetString(24),
                        reader.GetString(25),
                        reader.GetString(26),
                        reader.GetString(27),
                        reader.GetString(28),
                        reader.GetString(29),
                        reader.GetString(30),
                        reader.GetString(31),
                        reader.GetString(32),
                        reader.GetString(33),
                        
                    //reader.Convert.GetDateTime(6);

                };
                    lstformulario.Items.Add(new ListViewItem(row));
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }


        private void zerar_Formulario()
        {

            
            txtSuperficiePileo.Text = String.Empty;
            txtTipoEstipe.Text = String.Empty;
            txtReacaoMelzier.Text = String.Empty;
            txtReacaoKoh.Text = String.Empty;
            txtCottonBlue.Text = String.Empty;
            txtBasidio.Text = String.Empty;
            txtBasidiolo.Text = String.Empty;
            txtPoros.Text = String.Empty;
            txtFormatoEsporos.Text = String.Empty;
            txtTamanhoEsporos.Text= String.Empty;
            txtCorEsporos.Text=String.Empty;
            txtuConteudoEsporos.Text = String.Empty;
            txtOrnamentacao.Text = String.Empty;
            txtSistemaHifal.Text = String.Empty;
            txtElementosEstereis.Text = String.Empty;
            txtCistidio.Text = String.Empty;
            txtSetas.Text = String.Empty;
            txtSeptos.Text = String.Empty;
            txtPileipelis.Text = String.Empty;
            txtStipitipelis.Text= String.Empty;
            txtPleurocistidios.Text = String.Empty;
            txtQueilocistidios.Text = String.Empty;
            txtObservacoes.Text = String.Empty;
            txtGoogleDrive.Text = String.Empty;
            





        }









        string nomefotoidfungo;
        private void lstImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            ListView.SelectedListViewItemCollection itens_selecionados = lstImages.SelectedItems;

            foreach (ListViewItem itens in itens_selecionados)
            {

                nomefotoidfungo = itens.SubItems[1].Text;



                try
                {



                    Conexao = new MySqlConnection(data_source);
                    Conexao.Open();
                    MySqlCommand cmd = new MySqlCommand();

                    cmd.Connection = Conexao;




                    cmd.CommandText = "SELECT * FROM fungosfotos WHERE nomefotoidfungo =@id ; ";

                    cmd.Parameters.AddWithValue("@id", nomefotoidfungo);


                    cmd.Prepare();
                    MySqlDataReader reader = cmd.ExecuteReader();



                    while (reader.Read())
                    {


                        byte[] img = (byte[])reader["fotos"];
                        MemoryStream ms = new MemoryStream(img);
                        pictureBox1.Image = Image.FromStream(ms);
                        lblnomefoto.Text = reader.GetString(3);
                        nomedafoto = lblnomefoto.Text;

                    }


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Conexao.Close();
                }




            }








        }

        private void btnRemoverFoto_Click(object sender, EventArgs e)
        {

            try
            {
                string nomedigitado = lblnomefoto.Text;
                string idBd = idfungo.ToString() + bd;
                string nomefotoid = idfungo.ToString() + bd.ToString() + nomedigitado;
                //confirmar exclusao

                DialogResult conf = MessageBox.Show("Tem certeza da exclusão?", "Ops, tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                if (conf == DialogResult.Yes)
                {
                    //Excluir no DB
                    Conexao = new MySqlConnection(data_source);
                    Conexao.Open();
                    MySqlCommand cmd = new MySqlCommand();

                    cmd.Connection = Conexao;
                    cmd.CommandText = "DELETE FROM fungosfotos WHERE nomefotoidfungo=@id ";
                   
                    cmd.Parameters.AddWithValue("@id", nomefotoid);
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();



                    carregar_fotos();

                    MessageBox.Show("Excluido com sucesso!");


                  

                }



            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro" + ex.Number + "ocorreu: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ocorreu: " + ex.Message,
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.Close();

            }




        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //BOTAO ADICIONAR INFORMAÇÕES
            
            

            string idBd = idfungo.ToString() + bd;


            //criar conexao com sql

            DialogResult retorno = MessageBox.Show("Deseja realmente Salvar?",
                                               "adicionar",
                                               MessageBoxButtons.YesNo);
            if (retorno == DialogResult.Yes)
            {



                try
                {
                    Conexao = new MySqlConnection(data_source);

                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = Conexao;

                    Conexao.Open();

                    cmd.CommandText = "UPDATE " + bd + " SET idimages=@idimages, suppileo=@suppileo, " +
                        "estipe=@estipe, melzier=@melzier, koh=@koh, cottonb=@cottonb, basidio=@basidio, " +
                        "basidiolo=@basidiolo, poros=@poros, formatoesporos=@formatoesporos, " +
                        "tamanhoesporos=@tamanhoesporos, coresporos=@coresporos, conteudoesporos=@conteudoesporos, " +
                        "ornamentacaoesporos=@ornamentacaoesporos, sistemahifal=@sistemahifal, " +
                        "estereisadicionais=@estereisadicionais, cistidio=@cistidio, setas=@setas, " +
                        "tipodesepto=@tipodesepto, pileipelis=@pileipelis, stipitipelis=@stipitipelis, " +
                        "pleurocistidios=@pleurocistidios, queilocistidios=@queilocistidios, " +
                        "obsadicionais=@obsadicionais, googledrive=@googledrive WHERE id=@id ";

                    
                    
                    cmd.Parameters.AddWithValue("@idimages", idBd);

                    cmd.Parameters.AddWithValue("@suppileo", txtSuperficiePileo.Text);
                    cmd.Parameters.AddWithValue("@estipe", txtTipoEstipe.Text);
                    cmd.Parameters.AddWithValue("@melzier", txtReacaoMelzier.Text);
                    cmd.Parameters.AddWithValue("@koh", txtReacaoKoh.Text);
                    cmd.Parameters.AddWithValue("@cottonb", txtCottonBlue.Text);
                    cmd.Parameters.AddWithValue("@basidio", txtBasidio.Text);
                    cmd.Parameters.AddWithValue("@basidiolo", txtBasidiolo.Text);
                    cmd.Parameters.AddWithValue("@poros", txtPoros.Text);
                    cmd.Parameters.AddWithValue("@formatoesporos", txtFormatoEsporos.Text);
                    cmd.Parameters.AddWithValue("@tamanhoesporos", txtTamanhoEsporos.Text);
                    cmd.Parameters.AddWithValue("@coresporos", txtCorEsporos.Text);
                    cmd.Parameters.AddWithValue("@conteudoesporos",txtuConteudoEsporos.Text);
                    cmd.Parameters.AddWithValue("@ornamentacaoesporos", txtOrnamentacao.Text);
                    cmd.Parameters.AddWithValue("@sistemahifal", txtSistemaHifal.Text);
                    cmd.Parameters.AddWithValue("@estereisadicionais", txtElementosEstereis.Text);
                    cmd.Parameters.AddWithValue("@cistidio", txtCistidio.Text);
                    cmd.Parameters.AddWithValue("@setas", txtSetas.Text);
                    cmd.Parameters.AddWithValue("@tipodesepto", txtSeptos.Text);
                    cmd.Parameters.AddWithValue("@pileipelis", txtPileipelis.Text);
                    cmd.Parameters.AddWithValue("@stipitipelis", txtStipitipelis.Text);
                    cmd.Parameters.AddWithValue("@pleurocistidios", txtPleurocistidios.Text);
                    cmd.Parameters.AddWithValue("@queilocistidios", txtQueilocistidios.Text);
                    cmd.Parameters.AddWithValue("@obsadicionais", txtObservacoes.Text);
                    cmd.Parameters.AddWithValue("@googledrive", txtGoogleDrive.Text);
                    cmd.Parameters.AddWithValue("@id", lblIdDetalhes.Text);
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Conexao.Close();
                }

                
                carregar_formulario();

                btnSalvar.Enabled = false;
                zerar_Formulario();
            }





        }

        private void carregar_fotos()
        {



            //CARRREGAR IMAGENS NA LISTA
            try
            {

                string idBd = idfungo.ToString() + bd;

                Conexao = new MySqlConnection(data_source);
                Conexao.Open();
                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Conexao;
                cmd.CommandText = "SELECT * FROM fungosfotos WHERE idfungos =@id ";
                cmd.Parameters.AddWithValue("@id", idBd);


                cmd.Prepare();
                MySqlDataReader reader = cmd.ExecuteReader();
                lstImages.Items.Clear();



                while (reader.Read())
                {


                    

                    string[] row =
                    {

                        reader.GetString(3),
                        reader.GetString(4),
                    //reader.Convert.GetDateTime(6);

                };

                    lstImages.Items.Add(new ListViewItem(row));
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }



        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult conf = MessageBox.Show("Tem certeza que quer voltar?", "Ops, tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


            if (conf == DialogResult.Yes)
            {
               
                
               this.Close();



            }
        }


        private void btnEsquerda_Click(object sender, EventArgs e)
        {



            try
            {

                string idBd = idfungo.ToString() + bd;

                Conexao = new MySqlConnection(data_source);
                Conexao.Open();
                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Conexao;

                
                

                cmd.CommandText = "SELECT * FROM fungosfotos WHERE idfungos =@id ORDER BY RAND() LIMIT 1; ";

                cmd.Parameters.AddWithValue("@id", idBd);


                cmd.Prepare();
                MySqlDataReader reader = cmd.ExecuteReader();
                lstImages.Items.Clear();



                while (reader.Read())
                {


                    byte[] img = (byte[])reader["fotos"];

                    MemoryStream ms = new MemoryStream(img);
                    pictureBox1.Image = Image.FromStream(ms);
                    lblnomefoto.Text = reader.GetString(3);

                    nomedafoto = lblnomefoto.Text;


                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }

            carregar_fotos();



        }

        private void txtNomeFoto_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtGoogleDrive_Leave(object sender, EventArgs e)
        {
        }

        private void lstformulario_SelectedIndexChanged(object sender, EventArgs e)
        {


            ListView.SelectedListViewItemCollection itens_selecionados = lstformulario.SelectedItems;

            foreach (ListViewItem itens in itens_selecionados)
            {
                txtSuperficiePileo.Text = itens.SubItems[1].Text;
                txtTipoEstipe.Text = itens.SubItems[2].Text;
                txtReacaoMelzier.Text = itens.SubItems[3].Text;
                txtReacaoKoh.Text = itens.SubItems[4].Text;
                txtCottonBlue.Text = itens.SubItems[5].Text;
                txtBasidio.Text = itens.SubItems[6].Text;
                txtBasidiolo.Text = itens.SubItems[7].Text;
                txtPoros.Text = itens.SubItems[8].Text;
                txtFormatoEsporos.Text = itens.SubItems[9].Text;
                txtTamanhoEsporos.Text = itens.SubItems[10].Text;
                txtCorEsporos.Text = itens.SubItems[11].Text;
                txtuConteudoEsporos.Text = itens.SubItems[12].Text;
                txtOrnamentacao.Text = itens.SubItems[13].Text;
                txtSistemaHifal.Text = itens.SubItems[14].Text;
                txtElementosEstereis.Text = itens.SubItems[15].Text;
                txtCistidio.Text = itens.SubItems[16].Text;
                txtSetas.Text = itens.SubItems[17].Text;
                txtSeptos.Text = itens.SubItems[18].Text;
                txtPileipelis.Text = itens.SubItems[19].Text;
                txtStipitipelis.Text = itens.SubItems[20].Text;
                txtPleurocistidios.Text = itens.SubItems[21].Text;
                txtQueilocistidios.Text = itens.SubItems[22].Text;
                txtObservacoes.Text = itens.SubItems[23].Text;
                txtGoogleDrive.Text = itens.SubItems[24].Text;
                lnklabel.Text = itens.SubItems[24].Text;

            }
            pictureSumir.Visible = false;
            btnSalvar.Enabled = true;

            txtSuperficiePileo.Enabled = true;
            txtTipoEstipe.Enabled = true;
            txtReacaoMelzier.Enabled = true;
            txtReacaoKoh.Enabled = true;
            txtCottonBlue.Enabled = true;
            txtBasidio.Enabled = true;
            txtBasidiolo.Enabled = true;
            txtPoros.Enabled = true;
            txtFormatoEsporos.Enabled = true;
            txtTamanhoEsporos.Enabled=true;
            txtCorEsporos.Enabled = true;
            txtuConteudoEsporos.Enabled = true;
            txtOrnamentacao.Enabled = true;
            txtSistemaHifal.Enabled = true;
            txtElementosEstereis.Enabled = true;
            txtCistidio.Enabled = true;
            txtSetas.Enabled = true;
            txtSeptos.Enabled = true;
            txtPileipelis.Enabled = true;
            txtStipitipelis.Enabled=true;
            txtPleurocistidios.Enabled = true;
            txtQueilocistidios.Enabled = true;
            txtObservacoes.Enabled = true;
            txtGoogleDrive.Enabled = true;



        }

     

        private void barrasuperior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSuperficiePileo_Enter(object sender, EventArgs e)
        {
            txtSuperficiePileo.BackColor = Color.LightYellow;

        }

        private void txtSuperficiePileo_Leave(object sender, EventArgs e)
        {
            txtSuperficiePileo.BackColor = Color.White;
        }

        private void txtTipoEstipe_Enter(object sender, EventArgs e)
        {
            txtTipoEstipe.BackColor = Color.LightYellow;
        }

        private void txtTipoEstipe_Leave(object sender, EventArgs e)
        {
            txtTipoEstipe.BackColor = Color.White;
        }

        private void txtReacaoMelzier_Leave(object sender, EventArgs e)
        {
            txtReacaoMelzier.BackColor = Color.White;
        }

        private void txtCottonBlue_Leave(object sender, EventArgs e)
        {
            txtCottonBlue.BackColor = Color.White;
        }

        private void txtBasidiolo_Leave(object sender, EventArgs e)
        {
            txtBasidiolo.BackColor = Color.White;
        }

        private void txtFormatoEsporos_Leave(object sender, EventArgs e)
        {
            txtFormatoEsporos.BackColor = Color.White;
        }

        private void txtCorEsporos_Leave(object sender, EventArgs e)
        {
            txtCorEsporos.BackColor = Color.White;
        }

        private void txtOrnamentacao_Leave(object sender, EventArgs e)
        {
            txtOrnamentacao.BackColor = Color.White;
        }

        private void txtElementosEstereis_Leave(object sender, EventArgs e)
        {
            txtElementosEstereis.BackColor = Color.White;
        }

        private void txtSetas_Leave(object sender, EventArgs e)
        {
            txtSetas.BackColor = Color.White;
        }

        private void txtPileipelis_Leave(object sender, EventArgs e)
        {
            txtPileipelis.BackColor = Color.White;
        }

        private void txtPleurocistidios_Leave(object sender, EventArgs e)
        {
            txtPleurocistidios.BackColor = Color.White;
        }

        private void txtReacaoKoh_Leave(object sender, EventArgs e)
        {
            txtReacaoKoh.BackColor = Color.White;
        }

        private void txtBasidio_Leave(object sender, EventArgs e)
        {
            txtBasidio.BackColor = Color.White;
        }

        private void txtPoros_Leave(object sender, EventArgs e)
        {
            txtPoros.BackColor = Color.White;
        }

        private void txtTamanhoEsporos_Leave(object sender, EventArgs e)
        {
            txtTamanhoEsporos.BackColor = Color.White;
        }

        private void txtuConteudoEsporos_Leave(object sender, EventArgs e)
        {
            txtuConteudoEsporos.BackColor = Color.White;
        }

        private void txtSistemaHifal_Leave(object sender, EventArgs e)
        {
            txtSistemaHifal.BackColor = Color.White;
        }

        private void txtCistidio_Leave(object sender, EventArgs e)
        {
            txtCistidio.BackColor = Color.White;
        }

        private void txtSeptos_Leave(object sender, EventArgs e)
        {
            txtSeptos.BackColor = Color.White;
        }

        private void txtStipitipelis_Leave(object sender, EventArgs e)
        {
            txtStipitipelis.BackColor = Color.White;
        }

        private void txtQueilocistidios_Leave(object sender, EventArgs e)
        {
            txtQueilocistidios.BackColor = Color.White;
        }

        private void txtObservacoes_Leave(object sender, EventArgs e)
        {
            txtObservacoes.BackColor = Color.White;
        }

        private void txtNomeFoto_Leave(object sender, EventArgs e)
        {
            txtNomeFoto.BackColor = Color.White;
        }

        private void txtReacaoMelzier_Enter(object sender, EventArgs e)
        {
            txtReacaoMelzier.BackColor = Color.LightYellow;
        }

        private void txtReacaoKoh_Enter(object sender, EventArgs e)
        {
            txtReacaoKoh.BackColor = Color.LightYellow;
        }

        private void txtCottonBlue_Enter(object sender, EventArgs e)
        {
            txtCottonBlue.BackColor = Color.LightYellow;
        }

        private void txtBasidio_Enter(object sender, EventArgs e)
        {
            txtBasidio.BackColor = Color.LightYellow;
        }

        private void txtBasidiolo_Enter(object sender, EventArgs e)
        {
            txtBasidiolo.BackColor = Color.LightYellow;
        }

        private void txtPoros_Enter(object sender, EventArgs e)
        {
            txtPoros.BackColor = Color.LightYellow;
        }

        private void txtFormatoEsporos_Enter(object sender, EventArgs e)
        {
            txtFormatoEsporos.BackColor = Color.LightYellow;
        }

        private void txtTamanhoEsporos_Enter(object sender, EventArgs e)
        {
            txtTamanhoEsporos.BackColor = Color.LightYellow;
        }

        private void txtCorEsporos_Enter(object sender, EventArgs e)
        {
            txtCorEsporos.BackColor = Color.LightYellow;
        }

        private void txtuConteudoEsporos_Enter(object sender, EventArgs e)
        {
            txtuConteudoEsporos.BackColor = Color.LightYellow;
        }

        private void txtOrnamentacao_Enter(object sender, EventArgs e)
        {
            txtOrnamentacao.BackColor = Color.LightYellow;
        }

        private void txtSistemaHifal_Enter(object sender, EventArgs e)
        {
            txtSistemaHifal.BackColor = Color.LightYellow;
        }

        private void txtElementosEstereis_Enter(object sender, EventArgs e)
        {
            txtElementosEstereis.BackColor = Color.LightYellow;
        }

        private void txtCistidio_Enter(object sender, EventArgs e)
        {
            txtCistidio.BackColor = Color.LightYellow;
        }

        private void txtSetas_Enter(object sender, EventArgs e)
        {
            txtSetas.BackColor = Color.LightYellow;
        }

        private void txtSeptos_Enter(object sender, EventArgs e)
        {
            txtSeptos.BackColor = Color.LightYellow;
        }

        private void txtPileipelis_Enter(object sender, EventArgs e)
        {
            txtPileipelis.BackColor = Color.LightYellow;
        }

        private void txtStipitipelis_Enter(object sender, EventArgs e)
        {
            txtStipitipelis.BackColor = Color.LightYellow;
        }

        private void txtPleurocistidios_Enter(object sender, EventArgs e)
        {
            txtPleurocistidios.BackColor = Color.LightYellow;
        }

        private void txtQueilocistidios_Enter(object sender, EventArgs e)
        {
            txtQueilocistidios.BackColor = Color.LightYellow;
        }

        private void txtObservacoes_Enter(object sender, EventArgs e)
        {
            txtObservacoes.BackColor = Color.LightYellow;
        }

        private void txtGoogleDrive_Enter(object sender, EventArgs e)
        {
            txtGoogleDrive.BackColor = Color.LightYellow;
        }

        private void txtNomeFoto_Enter(object sender, EventArgs e)
        {
            txtNomeFoto.BackColor = Color.LightYellow;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
        bool mousedown;
        private void panel10_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
        }

        private void panel10_MouseMove(object sender, MouseEventArgs e)
        {
            if(mousedown)
            {
                int mousex = MousePosition.X - 400;
                int mousey = MousePosition.Y - 20;
                this.SetDesktopLocation(mousex,mousey);

            }
        }

        private void panel10_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown=false;

        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lnklabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


            if (lnklabel.Text != "")
            {

                try
                {
                    Globais.googledriveurl = lnklabel.Text;


                    Form2 j3 = new Form2();

                    j3.Show();



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }



            }





        }
    }
    }

