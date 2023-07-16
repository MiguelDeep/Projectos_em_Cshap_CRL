using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace AppPrincipal
{
    public partial class Cronometro : Form
    {
        private Stopwatch crono;
        public Cronometro()
        {
            InitializeComponent();
            ImgPausar.Hide();
            ImgRestaurar.Enabled = false;
            LbIntervalos.Hide();
        }
        private void Cronometro_Load(object sender, EventArgs e)
        {
            crono = new Stopwatch();
        }
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LbIntervalos.Visible = true;
            label1.Text = crono.Elapsed.ToString();
            ListaNumerodevoltas.Items.Add(label1.Text);
        }
  

        private void TimerResul_Tick(object sender, EventArgs e)
        {
            this.Lb_Resul.Text = string.Format("{0:hh\\:mm\\:ss\\:ff}", crono.Elapsed);
        }
        private void BtFechar_Click(object sender, EventArgs e)
        {
            this.Hide();
            App A = new App();
            A.Show();
        }
        private void btMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ImgIniciar_Click(object sender, EventArgs e)
        {
            crono.Start();
            ImgPausar.Visible = true;
            ImgIniciar.Hide();
            ImgRestaurar.Enabled = false;
            ImgBuneroDeVoltas.Enabled = true;
        }

        private void ImgRestaurar_Click_1(object sender, EventArgs e)
        {
            crono.Reset();
            ImgIniciar.Visible = true;
            ImgPausar.Visible = false;
            ImgBuneroDeVoltas.Enabled = false;
            LbIntervalos.Hide();
            ListaNumerodevoltas.Hide();
        }

        private void ImgPausar_Click_1(object sender, EventArgs e)
        {
            crono.Stop();
            ImgPausar.Hide();
            ImgIniciar.Visible = true;
            ImgRestaurar.Enabled = true;
            ImgBuneroDeVoltas.Enabled = false;
        }

        private void ImgBuneroDeVoltas_Click(object sender, EventArgs e)
        {
            ListaNumerodevoltas.Items.Add(Lb_Resul.Text);
        }
    }
}
