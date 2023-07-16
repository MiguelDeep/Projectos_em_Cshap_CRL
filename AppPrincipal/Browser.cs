using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPrincipal
{
    public partial class Browser : Form
    {
        public Browser()
        {
            InitializeComponent();
        }
        private void pesquisar()
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Digite algo ou insira o endereço Web!");
            }
            else
            {
                panel1.Hide();
                if (!(string.IsNullOrEmpty(textBox1.Text)))
                    webBrowser1.Navigate(textBox1.Text);
            }
        }
        private void btnvoltar_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }
        private void btnavancar_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }
        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            pesquisar();
            
        }
      
        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Hide();
            App A = new App();
            A.Show();
        }
       
        private void btMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
      
        private void btnhome_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            textBox1.Text = string.Empty;
        }

        private void PainelTopo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
