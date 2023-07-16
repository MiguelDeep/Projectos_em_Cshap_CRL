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
    public partial class MenuJogo : Form
    {
        public MenuJogo()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Game Game = new Game(200);
            Game.Show();
        }

        private void btnMedio_Click(object sender, EventArgs e)
        {
            this.Hide();
            Game Game = new Game(100);
            Game.Show();
        }

        private void BtnDificil_Click(object sender, EventArgs e)
        {
            this.Hide();
            Game Game = new Game(50);
            Game.Show();
        }

        private void Btnfechar_Click(object sender, EventArgs e)
        {
            this.Hide();
            App A = new App();
            A.Show();
        }
    }
}
