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
    public partial class Game : Form
    {
        public Game(int valor)
        {
            InitializeComponent();
            if (valor == 0)
            {
                valor = 100;
            }
            else
            {
                ImgRaquete.Height = valor;
            }
        }

        int vel = 10;
        int resul;
        bool topo, esquerda;
        public void Mover()
        {
            LBpontos.Text = resul.ToString();
            if (ImgBola.Left > ImgRaquete.Left)
            {
                timer1.Enabled = false;
                MessageBox.Show("Você perdeu :  " + resul.ToString());
                resul = 0;
            }

            if (ImgBola.Left + ImgBola.Width >= ImgRaquete.Left && ImgBola.Left + ImgBola.Width <= ImgRaquete.Left + ImgRaquete.Width
                && ImgBola.Top + ImgBola.Height >= ImgRaquete.Top && ImgBola.Top + ImgBola.Height <= ImgRaquete.Top + ImgRaquete.Height + ImgBola.Height)
            {
                esquerda = false;
                resul += 1;
                this.Text = resul.ToString();
            }

            if (esquerda)
                ImgBola.Left += vel;
            else
                ImgBola.Left -= vel;

            if (topo)
                ImgBola.Top += vel;
            else
                ImgBola.Top -= vel;

            if (ImgBola.Top >= this.Height - 50)
                topo = false;

            if (ImgBola.Top <= 0)
                topo = true;

            if (ImgBola.Left <= 0)
                esquerda = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Mover();
        }

        private void Game_MouseMove(object sender, MouseEventArgs e)
        {
            ImgRaquete.Top = e.Y;
        }

        private void Game_Click(object sender, EventArgs e)
        {
            Random R = new Random();
            ImgBola.Location = new Point(0, R.Next(this.Height));
            topo = esquerda = true;
            timer1.Enabled = true;
        }
        
       

       
        private void Game_Load(object sender, EventArgs e)
        {
            Random R = new Random();
            ImgBola.Location = new Point(0, R.Next(this.Height));
            topo = esquerda = true;
            timer1.Enabled = true;
        }


    }
}
