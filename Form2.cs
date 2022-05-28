using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

namespace Leitor_de_Mapa
{
    public partial class Form2 : Form
    {

   

        public Form2()
        {
            InitializeComponent();

        }

       







        private void Form2_Load(object sender, EventArgs e)
        {
            TopMost = true;
            initBrowser();

        }
        private async Task initizated()
        {
            await webView21.EnsureCoreWebView2Async(null);


        }
        public async void initBrowser()
        {


            try
            {
                string url = Globais.googledriveurl;
                await initizated();
                webView21.CoreWebView2.Navigate(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }

    }

   

}
