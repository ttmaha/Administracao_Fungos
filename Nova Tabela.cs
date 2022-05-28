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
using System.Drawing.Drawing2D;


namespace Leitor_de_Mapa
{
    public partial class Nova_Tabela : Form
    {



        MySqlConnection Conexao;
        private string data_source = "datasource=localhost;username=root;password=010203;database=db_mind; Convert Zero Datetime=True;";


        public Nova_Tabela()
        {
            InitializeComponent();
            txtNovaTabela.Focus();


        }

        public Nova_Tabela(string NomeTabela)
        {
            InitializeComponent();


        }



        private void txtNovaTabela_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNovaTabela_Click(object sender, EventArgs e)
        {


            //CRIAR NOVA TABELA E POSICIONAR LISTVIEW




            //CREATE TABLE teste1 LIKE fungomind


            DialogResult retorno = MessageBox.Show("Deseja realmente criar a tabela com o nome de " + txtNovaTabela.Text + " ?",
                                                "adicionar",
                                                MessageBoxButtons.YesNo);
            if (retorno == DialogResult.Yes)
            {





                try
                {
                    


                    Conexao = new MySqlConnection(data_source);
                    Conexao.Open();
                    MySqlCommand cmd = new MySqlCommand();

                    cmd.Connection = Conexao;

                    cmd.CommandText = "CREATE TABLE " + txtNovaTabela.Text + " LIKE fungomind";
                    
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();





                    EscolhaTabela j2 = new EscolhaTabela();
                    j2.Show();



                    Hide();

                    MessageBox.Show("Tabela Criada");




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

        private void Nova_Tabela_FormClosing(object sender, FormClosingEventArgs e)
        {


            


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            telaloading t1 = new telaloading();
            t1.Show();

        }

        private void Nova_Tabela_Load(object sender, EventArgs e)
        {

        }
    }
}
