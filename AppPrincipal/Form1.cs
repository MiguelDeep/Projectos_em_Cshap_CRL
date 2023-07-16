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
using System.Runtime.InteropServices;

namespace AppPrincipal
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
            PaineL_Visivel();
            menu();
        }
        private void menu()
        {
            Btmenu.Visible = true;
            if (PainelMenu.Width == 187)
                PainelMenuPequeno();
            else
                PainelMenuGrande();
        }
        
        private Panel panelCentral { get; set; }
        private Form FormCentral { get; set; }

        private Form formAtivo = null;
        public void abrirFormulario(Form formFilho, Panel painel)
        {
            this.panelCentral = painel;

            if (formAtivo != null)
            {
                formAtivo.Close();
            }
            formAtivo = formFilho;
            formFilho.TopLevel = false;
            formFilho.FormBorderStyle = FormBorderStyle.None;
            formFilho.Dock = DockStyle.Fill;
            panelCentral.Controls.Add(formFilho);
            panelCentral.Tag = formFilho;
            formFilho.BringToFront();
            formFilho.Show();
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public const int WM_LBUTTONDOWN = 0x0201;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
        int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_LBUTTONDOWN)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        //Area das funções
    
        private void PaineL_Visivel()
        {
            PainelMenu.Visible = true;
            PainelMenu.Height = 605;
            PainelMenu.Width = 40;
            Btmenu.Location = new Point(37, 0);
        }
        private void PainelMenuPequeno()
        {
            Thread.Sleep(20);
            PainelMenu.Width = 40;
            Btmenu.Location = new Point(41, 1);

           
        }
        private void PainelMenuGrande()
        {
            Thread.Sleep(20);
            PainelMenu.Width = 187;
            Btmenu.Location = new Point(188, 0);

          
        }
     

        private void btMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    
     
        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            BtnMaximizar.Visible = true;
            BtnRestaurar.Hide();
        }
        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            BtnRestaurar.Visible = true;
            BtnMaximizar.Hide();
        }
        private void Btminimizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void Btnfechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "sair", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No) return;
            Application.Exit();
        }
        private void Btnfechar_MouseEnter(object sender, EventArgs e)
        {
            this.Btnfechar.BackColor = Color.Red;
        }
        private void Btnfechar_MouseLeave(object sender, EventArgs e)
        {
            this.Btnfechar.BackColor = Color.Transparent;
        }

        //Area do chamamento de outros Formulários
        private void btnAlarme_Click(object sender, EventArgs e)
        {
      
            Alarme A = new Alarme();
            abrirFormulario(A, panel1);

        }
        private void BtnCalculadora_Click(object sender, EventArgs e)
        {
            Calculadora C = new Calculadora();
            abrirFormulario(C, panel1);
        }
        private void BtnCronometro_Click(object sender, EventArgs e)
        {
           
            Cronometro Crono = new Cronometro();
            abrirFormulario(Crono, panel1);
        }
        private void BtnLeitor_Click(object sender, EventArgs e)
        {
            
            Media L = new Media();
            abrirFormulario(L, panel1);
        }
        private void BtnGame_Click(object sender, EventArgs e)
        {
         
            MenuJogo Game = new MenuJogo();
         
            abrirFormulario(Game, panel1);
        }
        private void BtnBrowser_Click(object sender, EventArgs e)
        {
       
            Browser BR = new Browser();

            abrirFormulario(BR, panel1);
          
        }
       
    }
}
