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
    public partial class Sair : Form
    {
        public Sair()
        {
            InitializeComponent();
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
