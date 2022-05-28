using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Leitor_de_Mapa
{
    public partial class telaloading : Form
    {
        public telaloading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if(panel2.Width >= 599)
            {
                timer1.Stop();
                btnMinhaTabela.Visible = true;
                btnNovaTabela.Visible=true;
                lblcarregando.Text = "Funga!";
                pictureBox1.Visible = true;
            }
        }

        private void btnMinhaTabela_Click(object sender, EventArgs e)
        {
            EscolhaTabela escolhaTabela = new EscolhaTabela();
            escolhaTabela.Show();
            this.Hide();
           
        }

        private void btnNovaTabela_Click(object sender, EventArgs e)
        {
            Nova_Tabela novaTabela = new Nova_Tabela();
            novaTabela.Show();
            this.Hide();
        }

        private void btnSair_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {

        }
    }
}
