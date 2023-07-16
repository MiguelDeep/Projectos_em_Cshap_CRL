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
    public partial class AlarmeAux : Form
    {
        public AlarmeAux()
        {
            InitializeComponent();


        }

        private void LbHora_Click(object sender, EventArgs e)
        {

        }

        private void AlarmeAux_Load(object sender, EventArgs e)
        {
            LbHora.Text = DateTime.Now.Hour.ToString();
            LbMinuto.Text = DateTime.Now.Minute.ToString();

            if (DateTime.Now.Hour > 0 && DateTime.Now.Hour <= 11)
            {
                LbEstadado.Text = "Bom Dia!";
            }else if (DateTime.Now.Hour > 12 && DateTime.Now.Hour <= 17)
            {
                LbEstadado.Text = "Boa Tarde!";
            }
            else
            {
                LbEstadado.Text = "Boa Noite!";
            }
            if (DateTime.Now.Hour.ToString() != LbEstadado.Text)
            {
                this.Hide();
                Alarme A = new Alarme();
                A.Show();
            }
        }
        private void btnParar_Click(object sender, EventArgs e)
        { 
            this.Hide();
            Alarme A = new Alarme();
            A.Show();
          
        }
    }
}
