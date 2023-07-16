using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AppPrincipal
{
    public partial class Gunnateste : Form
    {
  
        public Gunnateste()
        {
            InitializeComponent();
            Processo.Hide();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            int i = 1;
                Processo.Visible = true;
                Processo.Start();
                i++; Thread.Sleep(100);
                if (i == 5)
                {
                    this.Hide();
                    App A = new App();
                    A.Show();
                }
        }

        private void Processo_Click(object sender, EventArgs e)
        {

        }
    }
}
