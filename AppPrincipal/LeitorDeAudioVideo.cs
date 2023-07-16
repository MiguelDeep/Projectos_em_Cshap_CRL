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
    public partial class Media : Form
    {
        public Media()
        {
            InitializeComponent();
            PainelMenuPequeno();
            coitroles_invisiveis();
            Player.Hide();
            trackvolume.Value = 5;
            
        }
        private void adicionar()
        {
            Player.Visible = true;

            if (this.WindowState == FormWindowState.Maximized)
                Player.Width = 1600;
            else
                Player.Width = 781;

            this.BackColor = Color.FromArgb(0, 25, 45);

            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Multiselect = true;
            abrir.Title = "Abrir Arquivo";
            abrir.Filter = "Arquivo mp4|*.mp4|Arquivo mp3|*.mp3";
            if (abrir.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ficheiros = abrir.SafeFileNames;
                nomeFicheiro = abrir.FileNames;
                for (i = 0; i < ficheiros.Length; i++)
                {
                    ListaReproducao.Items.Add(ficheiros[i]);
                }
                LbLogo.Hide();
                LbSubtitulo.Hide();
            }
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
        string[] nomeFicheiro, ficheiros; //Vetores de strings para armazenar os ficheiros

        private void coitroles_invisiveis()
        {
            imgPausar.Visible = false;
            Imgplay.Visible = true;
            Player.Width = 602;
            ListaReproducao.Visible = false;
        }
        private void PainelMenuPequeno() //Funcao quando o menu esta pequeno
        {
            Thread.Sleep(20);
        }
        private void PainelMenuGrande() //Funcao quando o menu esta grande
        {
            Thread.Sleep(20);
        }
      
        /// Botões de do topo, minimizar, maximizar e fechar etc
        private void Btmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
           
        }
        private void btMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btcompressar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
           
        }
        private void Btsair_Click(object sender, EventArgs e)
        {
            this.Hide();
            App A = new App();
            A.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            App A = new App();
            A.Show();
        }
       

        //Botões da area de reprodução
        private void trackBar1_Scroll(object sender, EventArgs e) //Botao Volume
        {
            Player.settings.volume = trackvolume.Value;
            Lbvolume.Text = trackvolume.Value.ToString();
        }        
        private void Imgplay_Click(object sender, EventArgs e) //Botao play
        {
            this.imgPausar.Show();
            this.Imgplay.Hide();
            Player.Ctlcontrols.play();
        }
        private void imgPausar_Click(object sender, EventArgs e)//Botão pausar
        {
            this.imgPausar.Hide();
            this.Imgplay.Show();
            Player.Ctlcontrols.pause();
        }
        
        private void imgAvancar_Click(object sender, EventArgs e)//Botão avançar
        {
            if (ListaReproducao.SelectedIndex < ListaReproducao.Items.Count - 1)
            {
                ListaReproducao.SelectedIndex = ListaReproducao.SelectedIndex + 1;
            }
        }
        private void Imgvoltar_Click(object sender, EventArgs e)//Botão voltar
        {
            if (ListaReproducao.SelectedIndex > 0)
            {
                ListaReproducao.SelectedIndex = ListaReproducao.SelectedIndex - 1;
            }
        }
        int i;
        /// <summary>
        /// ////Area dos botões principais
        private void BtnAdicionar_Click(object sender, EventArgs e) //botão Adicionar ficheiro
        {
            adicionar();
        }
        private void imgrepetir_Click(object sender, EventArgs e)
        {
            ListaReproducao.Items.Clear();
            Player.close();
        }
    
        private void listavisivel_Click(object sender, EventArgs e)
        {
            listavisivel.Visible = false;
            ImgListaremover.Visible = true;
            ListaReproducao.Visible = true;

            if (this.WindowState == FormWindowState.Normal)
                Player.Width = 602;
            else
                Player.Width = 1385;

        }//lista de reproducao visivel
        private void ImgListaremover_Click(object sender, EventArgs e)
        {
            listavisivel.Visible = true;
            ImgListaremover.Visible = false;
            ListaReproducao.Visible = false;

            if (this.WindowState == FormWindowState.Normal)
                Player.Width = 781;
            else
                Player.Width = 1600;
        }//lista de reproducao invisivel
        private void Player_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)//Evento quando o player troca de estado (reproduzindo, pausado etc)
        {
            if (Player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                timer1.Start();
            }
            else if (Player.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                timer1.Stop();
            }else if (Player.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                timer1.Stop();
            }
        }
        private void ListaReproducao_SelectedIndexChanged(object sender, EventArgs e)
        {
            Player.URL = nomeFicheiro[ListaReproducao.SelectedIndex];
            imgPausar.Visible = true;
            Imgplay.Visible = false;
        }//Evento quando a lista e clicada

        private void BtnAdicionar_Click_1(object sender, EventArgs e)
        {
            adicionar();
        }

        private void Media_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LbInicioreproducao.Text = Player.Ctlcontrols.currentPositionString;
            if (Player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                panel1.Visible = true;
                panel1.Width = (int)Player.Ctlcontrols.currentPosition;
                panel1.Width += 5;
            }
        }
    }
}
