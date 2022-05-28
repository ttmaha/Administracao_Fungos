using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leitor_de_Mapa
{
    public partial class EscolhaTabela : Form
    {

        public EscolhaTabela()
        {
            InitializeComponent();

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            Globais.nomeBD = txtNomeTabela.Text;

            Form1 j2 = new Form1();
            j2.Show();

            Hide();
        }



        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

  
    }
}
