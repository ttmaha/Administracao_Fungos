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


using DataTable = System.Data.DataTable;
using ClosedXML.Excel;

namespace Leitor_de_Mapa
{
    public partial class Form1 : Form
    {





        DataTable dt = new DataTable();
        private int? idfungos = Globais.idFungo;
        string bd = Globais.nomeBD;
        private string data_source = "datasource=localhost;username=root;password=010203;database=db_mind; Convert Zero Datetime=True;";
        
        
        double latInicial = -27.595830;
        double lngInicial = -48.565178;

        MySqlConnection Conexao;
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        GMapOverlay Poligono;



        public Form1()
        {



            configurartabela();

            InitializeComponent();

            lstFungos.View = View.Details;
            lstFungos.LabelEdit = true;
            lstFungos.AllowColumnReorder = true;
            lstFungos.FullRowSelect = true;
            lstFungos.GridLines = true;

            lstFungos.Columns.Add("id", 30, HorizontalAlignment.Left);
            lstFungos.Columns.Add("descricao", 60, HorizontalAlignment.Left);
            lstFungos.Columns.Add("ocorrencia", 60, HorizontalAlignment.Left);
            lstFungos.Columns.Add("latitude", 0, HorizontalAlignment.Left);
            lstFungos.Columns.Add("longitude", 0, HorizontalAlignment.Left);
            lstFungos.Columns.Add("genero", 100, HorizontalAlignment.Left);
            lstFungos.Columns.Add("especie", 100, HorizontalAlignment.Left);
            lstFungos.Columns.Add("datetime", 100, HorizontalAlignment.Left);

            lstFungos.Columns.Add("idimages", 100, HorizontalAlignment.Left);
            lstFungos.Columns.Add("suppileo", 100, HorizontalAlignment.Left);
            lstFungos.Columns.Add("estipe", 100, HorizontalAlignment.Left);
            lstFungos.Columns.Add("melzier", 100, HorizontalAlignment.Left);
            lstFungos.Columns.Add("koh", 100, HorizontalAlignment.Left);
            lstFungos.Columns.Add("cottonb", 100, HorizontalAlignment.Left);
            lstFungos.Columns.Add("basidio", 100, HorizontalAlignment.Left);
            lstFungos.Columns.Add("basidiolo", 100, HorizontalAlignment.Left);
            lstFungos.Columns.Add("poros", 100, HorizontalAlignment.Left);
            lstFungos.Columns.Add("formatoesporos", 100, HorizontalAlignment.Left);
            lstFungos.Columns.Add("tamanhoesporos", 100, HorizontalAlignment.Left);
            lstFungos.Columns.Add("coresporos", 100, HorizontalAlignment.Left);
            lstFungos.Columns.Add("conteudoesporos", 100, HorizontalAlignment.Left);
            lstFungos.Columns.Add("ornamentaçãoesporos", 100, HorizontalAlignment.Left);
            lstFungos.Columns.Add("sistemahifal", 100, HorizontalAlignment.Left);
            lstFungos.Columns.Add("estereisadicionais", 100, HorizontalAlignment.Left);
            lstFungos.Columns.Add("cistidio", 100, HorizontalAlignment.Left);
            lstFungos.Columns.Add("setas", 100, HorizontalAlignment.Left);
            lstFungos.Columns.Add("tipodesepto", 100, HorizontalAlignment.Left);
            lstFungos.Columns.Add("pileipelis", 100, HorizontalAlignment.Left);
            lstFungos.Columns.Add("stipitipelis", 100, HorizontalAlignment.Left);
            lstFungos.Columns.Add("pleurocistidios", 100, HorizontalAlignment.Left);
            lstFungos.Columns.Add("queilocistidios", 100, HorizontalAlignment.Left);
            lstFungos.Columns.Add("obsadicionais", 100, HorizontalAlignment.Left);
            lstFungos.Columns.Add("google drive", 100, HorizontalAlignment.Left);
            lstFungos.Columns.Add("iucn", 100, HorizontalAlignment.Left);




            carregar_contatos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(latInicial, lngInicial);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.AutoScroll = true;
            gMapControl1.Zoom = 10;
            gMapControl1.ShowCenter = false;



            //Marcadores
            markerOverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new PointLatLng(latInicial, lngInicial), GMarkerGoogleType.green);
            markerOverlay.Markers.Add(marker); //adicionamos no mapa

            //adicionar  ponto nos marcadores
            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = string.Format("Localização: Latitude:{0} \n Longitude:{1}", latInicial, lngInicial);

            // Adicionar o mapa e marcador no controle
            gMapControl1.Overlays.Add(markerOverlay);
            

        }


        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
        }


        private void btnRemover_Click(object sender, EventArgs e)
        {

            if (lbl_id.Text != ".")
            {
                excluirdados();
                zerar_Formulario();
            }
        }

        private void btnPoligon_Click(object sender, EventArgs e)
        {


            //MessageBox.Show(" " + listaclicks.Count);
            Poligono = new GMapOverlay();
            List<PointLatLng> pontos = new List<PointLatLng>();
            double lng,lat;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                lat = Convert.ToDouble(dataGridView1.Rows[i].Cells[0].Value);
                lng = Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value);
                pontos.Add(new PointLatLng(lat, lng));
            }

            GMapPolygon poligonoPontos = new GMapPolygon(pontos, "Poligono");
            Poligono.Polygons.Add(poligonoPontos);
            gMapControl1.Overlays.Add(Poligono);
            gMapControl1.Zoom = gMapControl1.Zoom + 1;
            gMapControl1.Zoom = gMapControl1.Zoom - 1;


        }


        private void abrirPlanilhaExcel()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {

                ofd.Filter = "Excel Files Only | *xlsx; *xls";
                ofd.Title = "Choose the file";
                if (ofd.ShowDialog() == DialogResult.OK)
                    FileName_LBL.Text = ofd.FileName;
            }
        }

        private async void btnExportar_Click(object sender, EventArgs e)
        {
            zerar_Formulario();
            carregar_contatos();




            DialogResult retorno = MessageBox.Show("Deseja realmente exportar?",
                                              "adicionar",
                                              MessageBoxButtons.YesNo);
            if (retorno == DialogResult.Yes)
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter sw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                        {
                            StringBuilder sb = new StringBuilder();
                            sb.AppendLine("id, descricao, ocorrencia, latitude, longitude, genero, especie, " +
                                "datetime, idimages, suppileo, estipe, melzier, koh, cottonb, basidio, basidiolo, " +
                                "poros, formatoesporos,tamanhoesporos,coresporos,conteudoesporos,ornamentacaoesporos," +
                                "sistemahifal,estereisadicionais,cistidio,setas,tipodesepeto,pileipelis,stipitipelis," +
                                "pleurocistidios,queilocistidios,obsadicionais,googledrive, iucn");

                            foreach (ListViewItem item in lstFungos.Items)
                            {
                                sb.AppendLine(string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}," +
                                    "{14},{15},{16},{17},{18},{19},{20},{21},{22},{23},{24},{25},{26},{27},{28},{29},{30},{31},{32}" +
                                    "{32}", item.SubItems[0].Text, item.SubItems[1].Text, item.SubItems[2].Text, item.SubItems[3].Text,
                                    item.SubItems[4].Text, item.SubItems[5].Text, item.SubItems[6].Text, item.SubItems[7].Text, item.SubItems[8].Text,
                                    item.SubItems[9].Text, item.SubItems[10].Text, item.SubItems[11].Text, item.SubItems[12].Text, item.SubItems[13].Text,
                                    item.SubItems[14].Text, item.SubItems[15].Text, item.SubItems[16].Text, item.SubItems[17].Text, item.SubItems[18].Text,
                                    item.SubItems[19].Text, item.SubItems[20].Text, item.SubItems[21].Text, item.SubItems[22].Text, item.SubItems[23].Text,
                                    item.SubItems[24].Text, item.SubItems[25].Text, item.SubItems[26].Text, item.SubItems[27].Text, item.SubItems[28].Text,
                                    item.SubItems[29].Text, item.SubItems[30].Text, item.SubItems[31].Text, item.SubItems[32].Text, item.SubItems[33].Text));


                            }
                            await sw.WriteLineAsync(sb.ToString());
                            MessageBox.Show("Dados Exportados", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }


                    }
                }

            }




            
        }

        private void button1_Click(object sender, EventArgs e)
        { //buscar
            try
            {
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();
                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Conexao;
                cmd.CommandText = "SELECT * FROM " + bd + " WHERE genero LIKE @q OR id LIKE @q OR descricao LIKE @q OR especie LIKE @q OR ocorrencia LIKE @q";
                cmd.Parameters.AddWithValue("@q", "%" + txtBuscar.Text + "%");

                cmd.Prepare();
                MySqlDataReader reader = cmd.ExecuteReader();

                lstFungos.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetString(4),
                        reader.GetString(5),
                        reader.GetString(6),
                        reader.GetString(7),
                        

                };
                    lstFungos.Items.Add(new ListViewItem(row));
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

       


        private void txtDescricao_Enter(object sender, EventArgs e)
        {
            txtDescricao.BackColor = Color.LightYellow;
        }

        private void txtDescricao_Leave(object sender, EventArgs e)
        {
            txtDescricao.BackColor = Color.White;
        }

        private void txtLat_Enter(object sender, EventArgs e)
        {
            txtLat.BackColor = Color.LightYellow;
        }

        private void txtLat_Leave(object sender, EventArgs e)
        {
            txtLat.BackColor = Color.White;
        }

        private void txtLong_Enter(object sender, EventArgs e)
        {
            txtLong.BackColor = Color.LightYellow;
        }

        private void txtLong_Leave(object sender, EventArgs e)
        {
            txtLong.BackColor = Color.White;
        }

        private void txtGenero_Enter(object sender, EventArgs e)
        {
            txtGenero.BackColor = Color.LightYellow;
        }

        private void txtGenero_Leave(object sender, EventArgs e)
        {
            txtGenero.BackColor = Color.White;
        }

        private void txtEspecie_Enter(object sender, EventArgs e)
        {
            txtEspecie.BackColor = Color.LightYellow;
        }

        private void txtEspecie_Leave(object sender, EventArgs e)
        {
            txtEspecie.BackColor = Color.White;
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {

            zerar_Formulario();
            carregar_contatos();
            
            //abrirPlanilhaExcel();

        }


        private void txtLat_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            //BOTAO ADICIONAR




            DialogResult retorno = MessageBox.Show("Deseja realmente adicionar?",
                                                "adicionar",
                                                MessageBoxButtons.YesNo);
            if (retorno == DialogResult.Yes)
            {




                //connectar no SQL

                try
                {
                   

                    txtData.Value.ToString();

                    //criar conexao com sql

                    Conexao = new MySqlConnection(data_source);

                    Conexao.Open();
                    MySqlCommand cmd = new MySqlCommand();

                    cmd.Connection = Conexao;



                    if (idfungos == null)


                    {
                        string iucn = txtcomboBoxStatusCon.Text;

                        cmd.CommandText = "INSERT INTO " + bd + " (descricao, ocorrencia, latitude, longitude, genero, especie, datetime, iucn) " +
                       "VALUES (@descricao,@ocorrencia, @latitude, @longitude, @genero, @especie, @datetime, @iucn) ";



                        cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                        cmd.Parameters.AddWithValue("@ocorrencia", txtOcorrencia.Text);
                        cmd.Parameters.AddWithValue("@latitude", txtLat.Text);
                        cmd.Parameters.AddWithValue("@longitude", txtLong.Text);
                        cmd.Parameters.AddWithValue("@genero", txtGenero.Text);
                        cmd.Parameters.AddWithValue("@especie", txtEspecie.Text);
                        cmd.Parameters.AddWithValue("@datetime", txtData.Text);
                        cmd.Parameters.AddWithValue("@iucn", iucn);

                        cmd.Prepare();
                        cmd.ExecuteNonQuery();


                        MessageBox.Show("Dados adicionados com Sucesso!",
                                        "Sucesso!", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                    }
                    else
                    {

                        //atualizacao
                        MessageBox.Show("Use o botão editar",
                                        "Sucesso!", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                    }

                    carregar_contatos();
                    zerar_Formulario();

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

        private void carregar_contatos()
        {
            try
            {
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();
                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Conexao;
                cmd.CommandText = "SELECT * FROM " + bd + " ORDER BY descricao ASC";
                cmd.Prepare();

                MySqlDataReader reader = cmd.ExecuteReader();
                lstFungos.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetString(4),
                        reader.GetString(5),
                        reader.GetString(6),
                        reader.GetString(7),

                        reader.GetString(8),
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
                    lstFungos.Items.Add(new ListViewItem(row));
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

        private void lstFungos_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {



        }

        private void txtData_ValueChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            excluirdados();

        }

        private void lstFungos_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            ListView.SelectedListViewItemCollection itens_selecionados = lstFungos.SelectedItems;

            foreach (ListViewItem itens in itens_selecionados)
            {
                idfungos = Convert.ToInt32(itens.SubItems[0].Text);

                txtDescricao.Text = itens.SubItems[1].Text;
                txtOcorrencia.Text = itens.SubItems[2].Text;
                txtLat.Text = itens.SubItems[3].Text;
                txtLong.Text = itens.SubItems[4].Text;
                txtGenero.Text = itens.SubItems[5].Text;
                txtEspecie.Text = itens.SubItems[6].Text;
                //txtData.Text = itens.SubItems[7].Text;
                //txtcomboBoxStatusCon.Text = itens.SubItems[33].Text;
                txtData.Text = Convert.ToString(itens.SubItems[7].Text);

            }
            lbl_id.Text = idfungos.ToString();

            btnDetalhes.Enabled = true;


            if (txtLat.Text != "")
            {

                // adicionar no grid do marcador
                marker.Position = new PointLatLng(Convert.ToDouble(txtLat.Text), Convert.ToDouble(txtLong.Text));
                // posicionar o foco no ponto
                gMapControl1.Position = marker.Position;
                gMapControl1.Zoom = 10;

            }





        }



        private void excluirdados()
        {
            try
            {

                //confirmar exclusao

                DialogResult conf = MessageBox.Show("Tem certeza da exclusão?", "Ops, tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                if (conf == DialogResult.Yes)
                {
                    //Excluir no DB
                    Conexao = new MySqlConnection(data_source);
                    Conexao.Open();
                    MySqlCommand cmd = new MySqlCommand();

                    cmd.Connection = Conexao;
                    cmd.CommandText = "DELETE FROM " + bd + " WHERE id=@id ";
                    cmd.Parameters.AddWithValue("@id", idfungos);
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();



                    carregar_contatos();

                    MessageBox.Show("Excluido com sucesso!");


                    lbl_id.Text = ".";

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









            try
            {

                
                //Excluir no DBFOTOS

                string idBd = idfungos.ToString() + bd;
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();
                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Conexao;
                cmd.CommandText = "DELETE FROM fungosfotos WHERE idfungos=@id ";
                cmd.Parameters.AddWithValue("@id", idBd);
                cmd.Prepare();
                cmd.ExecuteNonQuery();



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



        private void zerar_Formulario()
        {

            idfungos = null;
            txtDescricao.Text = String.Empty;
            txtOcorrencia.Text = String.Empty;
            //txtLat.Text = String.Empty;
            // txtLong.Text = String.Empty;
            txtGenero.Text = String.Empty;
            txtEspecie.Text = String.Empty;
            //txtData.Text = String.Empty;
            //txtDescricao.Focus();
            btnDetalhes.Enabled= false;
            txtcomboBoxStatusCon.Text = "IUCN";


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //BOTAO ADICIONAR

            DialogResult retorno = MessageBox.Show("Deseja realmente editar?",
                                                "adicionar",
                                                MessageBoxButtons.YesNo);
            if (retorno == DialogResult.Yes)
            {
                //connectar no SQL

                try
                {

                    //criar conexao com sql

                    Conexao = new MySqlConnection(data_source);


                    Conexao.Open();
                    MySqlCommand cmd = new MySqlCommand();

                    cmd.Connection = Conexao;

                    if (idfungos == null)


                    {
                        

                        cmd.CommandText = "INSERT INTO " + bd + " (descricao, ocorrencia, latitude, longitude, genero, especie, datetime, iucn) " +
                       "VALUES (@descricao, @latitude, @longitude, @genero, @especie, @datetime, @iucn) ";



                        cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                        cmd.Parameters.AddWithValue("@ocorrencia", txtDescricao.Text);
                        cmd.Parameters.AddWithValue("@latitude", txtLat.Text);
                        cmd.Parameters.AddWithValue("@longitude", txtLong.Text);
                        cmd.Parameters.AddWithValue("@genero", txtGenero.Text);
                        cmd.Parameters.AddWithValue("@especie", txtEspecie.Text);
                        cmd.Parameters.AddWithValue("@datetime", txtData.Text);
                        cmd.Parameters.AddWithValue("@iucn", txtcomboBoxStatusCon.Text);

                        cmd.Prepare();
                        cmd.ExecuteNonQuery();



                        MessageBox.Show("Dados adicionados com Sucesso!",
                                        "Sucesso!", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                    }
                    else
                    {


                        //atualizacao

                        cmd.CommandText = "UPDATE " + bd + " SET " +
                            "descricao=@descricao, ocorrencia=@ocorrencia, latitude=@latitude, longitude=@longitude, genero=@genero, especie=@especie, datetime=@datetime, iucn=@iucn WHERE id=@id ";

                        //idfungos = Convert.ToInt32(itens.SubItems[0].Text);


                        cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                        cmd.Parameters.AddWithValue("@ocorrencia", txtOcorrencia.Text);
                        cmd.Parameters.AddWithValue("@latitude", txtLat.Text);
                        cmd.Parameters.AddWithValue("@longitude", txtLong.Text);
                        cmd.Parameters.AddWithValue("@genero", txtGenero.Text);
                        cmd.Parameters.AddWithValue("@especie", txtEspecie.Text);
                        cmd.Parameters.AddWithValue("@datetime", txtData.Text);
                        cmd.Parameters.AddWithValue("@id", lbl_id.Text);
                        cmd.Parameters.AddWithValue("@iucn", txtcomboBoxStatusCon.Text);

                        cmd.Prepare();
                        cmd.ExecuteNonQuery();




                        MessageBox.Show("Dados Atualizados com Sucesso!",
                                        "Sucesso!", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);


                    }




                    carregar_contatos();


                    zerar_Formulario();




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
                    txtDescricao.Focus();
                }



            }


        }

        private void btn_satelite_Click(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMapProviders.GoogleChinaSatelliteMap;
        }

        private void btn_normal_Click(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
        }

        private void btn_relevo_Click(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMapProviders.GoogleTerrainMap;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            trackBar1.Value = Convert.ToInt32(gMapControl1.Zoom);
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            gMapControl1.Zoom = trackBar1.Value;
        }

        private void FileName_LBL_Click(object sender, EventArgs e)
        {

        }

        private void tabelasBancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {





        }

        private void fecharProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult retorno = MessageBox.Show("Deseja realmente sair?",
                                           "Sair",
                                           MessageBoxButtons.YesNo);
            if (retorno == DialogResult.Yes)
            {
                Application.Exit();

            }
        }

        private void novaTabelaToolStripMenuItem1_Click(object sender, EventArgs e)
        {



            DialogResult retorno = MessageBox.Show("Deseja realmente criar uma nova tabela?",
                                    "Criar",
                                    MessageBoxButtons.YesNo);
            if (retorno == DialogResult.Yes)
            {

                Nova_Tabela j1 = new Nova_Tabela();

                j1.Show();


                this.Hide();


                //j1.ShowDialog();


            }






        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void txtEnquadrar_Click(object sender, EventArgs e)
        {

            gMapControl1.Focus();
            gMapControl1.Position = marker.Position;
            gMapControl1.Zoom = 10;


            //carregar_contatos();




        }

        private void trocarTabelaToolStripMenuItem_Click(object sender, EventArgs e)
        {


            DialogResult retorno = MessageBox.Show("Deseja realmente trocar a tabela?",
                                    "Trocar",
                                    MessageBoxButtons.YesNo);
            if (retorno == DialogResult.Yes)
            {

                EscolhaTabela j2 = new EscolhaTabela();

                j2.Show();






                this.Hide();


                //j1.ShowDialog();


            }




        }

        private void btnpontoadd_Click(object sender, EventArgs e)
        {



            if(txtLat.Text != "")
            {
                dt.Rows.Add(txtLat.Text, txtLong.Text);

                dataGridView1.DataSource = dt;
            }




        }


        private void configurartabela()
        {


            dt.Columns.Add(new DataColumn("latitude", typeof(double)));
            dt.Columns.Add(new DataColumn("longitude", typeof(double)));
            







        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            

            if (dataGridView1.Rows.Count != 0)
            {

               

                int rowIndex = dataGridView1.CurrentCell.RowIndex;

                dataGridView1.Rows.RemoveAt(rowIndex);
                dataGridView1.Refresh();
                gMapControl1.Refresh();

                gMapControl1.Overlays.Clear();
                gMapControl1.Overlays.Add(markerOverlay);
                


            }


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            

        }

        private void btnDetalhes_Click(object sender, EventArgs e)
        {
           
          

            Globais.idFungo = idfungos;

            //MessageBox.Show(" " + Globais.idFungo.Value);
            Detalhes j1 = new Detalhes();
            j1.Show();



        }


     

     

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.Exit();

        }

      

        private void lstFungos_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            Globais.idFungo = idfungos;

            //MessageBox.Show(" " + Globais.idFungo.Value);
            Detalhes j1 = new Detalhes();
            j1.Show();

        }

   

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
        bool mousedown;
        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {

            mousedown = true;

        }

        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown)
            {
                int mousex = MousePosition.X - 400;
                int mousey = MousePosition.Y - 20;
                this.SetDesktopLocation(mousex, mousey);

            }
        }

        private void menuStrip1_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void comboBoxStatusCon_SelectedIndexChanged(object sender, EventArgs e)
        {



        }


    

        private void gMapControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lbl_id.Text = ".";
            //Zerar ID e outros dados
            zerar_Formulario();
            // obter dados do cursos
            double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            double lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;


            //Posicionar no texto
            txtLat.Text = lat.ToString();
            txtLong.Text = lng.ToString();
            //criar o marcador para mover aonde quiser
            marker.Position = new PointLatLng(lat, lng);
            // mensagem no tooltip
            marker.ToolTipText = String.Format(" Localização: \n Latitude: {0} \n Longitude:{1}", lat, lng);


            btnDetalhes.Enabled = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;

        }
    }




}





