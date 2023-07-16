namespace AppPrincipal
{
    partial class Media
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Media));
            this.PainelReproducao = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listavisivel = new System.Windows.Forms.PictureBox();
            this.LbFimreproducao = new System.Windows.Forms.Label();
            this.LbInicioreproducao = new System.Windows.Forms.Label();
            this.LbPorcentoVolume = new System.Windows.Forms.Label();
            this.Lbvolume = new System.Windows.Forms.Label();
            this.trackvolume = new System.Windows.Forms.TrackBar();
            this.ImgListaremover = new System.Windows.Forms.PictureBox();
            this.imgPausar = new System.Windows.Forms.PictureBox();
            this.imgrepetir = new System.Windows.Forms.PictureBox();
            this.ImgAleatorio = new System.Windows.Forms.PictureBox();
            this.Imgvoltar = new System.Windows.Forms.PictureBox();
            this.imgAvancar = new System.Windows.Forms.PictureBox();
            this.Imgplay = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ListaReproducao = new System.Windows.Forms.ListBox();
            this.Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.LbLogo = new System.Windows.Forms.Label();
            this.LbSubtitulo = new System.Windows.Forms.Label();
            this.PainelReproducao.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listavisivel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackvolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgListaremover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPausar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgrepetir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgAleatorio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imgvoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAvancar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imgplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // PainelReproducao
            // 
            this.PainelReproducao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.PainelReproducao.Controls.Add(this.panel2);
            this.PainelReproducao.Controls.Add(this.listavisivel);
            this.PainelReproducao.Controls.Add(this.LbFimreproducao);
            this.PainelReproducao.Controls.Add(this.LbInicioreproducao);
            this.PainelReproducao.Controls.Add(this.LbPorcentoVolume);
            this.PainelReproducao.Controls.Add(this.Lbvolume);
            this.PainelReproducao.Controls.Add(this.trackvolume);
            this.PainelReproducao.Controls.Add(this.ImgListaremover);
            this.PainelReproducao.Controls.Add(this.imgPausar);
            this.PainelReproducao.Controls.Add(this.imgrepetir);
            this.PainelReproducao.Controls.Add(this.ImgAleatorio);
            this.PainelReproducao.Controls.Add(this.Imgvoltar);
            this.PainelReproducao.Controls.Add(this.imgAvancar);
            this.PainelReproducao.Controls.Add(this.Imgplay);
            this.PainelReproducao.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PainelReproducao.Location = new System.Drawing.Point(0, 463);
            this.PainelReproducao.Name = "PainelReproducao";
            this.PainelReproducao.Size = new System.Drawing.Size(817, 103);
            this.PainelReproducao.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(26, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(741, 4);
            this.panel2.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tomato;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(28, 4);
            this.panel1.TabIndex = 25;
            // 
            // listavisivel
            // 
            this.listavisivel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.listavisivel.BackColor = System.Drawing.Color.Transparent;
            this.listavisivel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listavisivel.Image = ((System.Drawing.Image)(resources.GetObject("listavisivel.Image")));
            this.listavisivel.Location = new System.Drawing.Point(245, 44);
            this.listavisivel.Name = "listavisivel";
            this.listavisivel.Size = new System.Drawing.Size(26, 26);
            this.listavisivel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.listavisivel.TabIndex = 23;
            this.listavisivel.TabStop = false;
            this.listavisivel.Click += new System.EventHandler(this.listavisivel_Click);
            // 
            // LbFimreproducao
            // 
            this.LbFimreproducao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LbFimreproducao.AutoSize = true;
            this.LbFimreproducao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbFimreproducao.ForeColor = System.Drawing.Color.White;
            this.LbFimreproducao.Location = new System.Drawing.Point(764, 24);
            this.LbFimreproducao.Name = "LbFimreproducao";
            this.LbFimreproducao.Size = new System.Drawing.Size(39, 16);
            this.LbFimreproducao.TabIndex = 22;
            this.LbFimreproducao.Text = "00:00";
            // 
            // LbInicioreproducao
            // 
            this.LbInicioreproducao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LbInicioreproducao.AutoSize = true;
            this.LbInicioreproducao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbInicioreproducao.ForeColor = System.Drawing.Color.White;
            this.LbInicioreproducao.Location = new System.Drawing.Point(11, 24);
            this.LbInicioreproducao.Name = "LbInicioreproducao";
            this.LbInicioreproducao.Size = new System.Drawing.Size(39, 16);
            this.LbInicioreproducao.TabIndex = 6;
            this.LbInicioreproducao.Text = "00:00";
            // 
            // LbPorcentoVolume
            // 
            this.LbPorcentoVolume.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LbPorcentoVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPorcentoVolume.ForeColor = System.Drawing.Color.White;
            this.LbPorcentoVolume.Location = new System.Drawing.Point(713, 44);
            this.LbPorcentoVolume.Name = "LbPorcentoVolume";
            this.LbPorcentoVolume.Size = new System.Drawing.Size(21, 24);
            this.LbPorcentoVolume.TabIndex = 19;
            this.LbPorcentoVolume.Text = "%";
            // 
            // Lbvolume
            // 
            this.Lbvolume.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Lbvolume.AutoSize = true;
            this.Lbvolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbvolume.ForeColor = System.Drawing.Color.White;
            this.Lbvolume.Location = new System.Drawing.Point(677, 44);
            this.Lbvolume.Name = "Lbvolume";
            this.Lbvolume.Size = new System.Drawing.Size(20, 24);
            this.Lbvolume.TabIndex = 18;
            this.Lbvolume.Text = "5";
            // 
            // trackvolume
            // 
            this.trackvolume.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackvolume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackvolume.Location = new System.Drawing.Point(579, 47);
            this.trackvolume.Maximum = 100;
            this.trackvolume.Name = "trackvolume";
            this.trackvolume.Size = new System.Drawing.Size(100, 45);
            this.trackvolume.TabIndex = 16;
            this.trackvolume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackvolume.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // ImgListaremover
            // 
            this.ImgListaremover.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ImgListaremover.BackColor = System.Drawing.Color.Transparent;
            this.ImgListaremover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImgListaremover.Image = ((System.Drawing.Image)(resources.GetObject("ImgListaremover.Image")));
            this.ImgListaremover.Location = new System.Drawing.Point(245, 44);
            this.ImgListaremover.Name = "ImgListaremover";
            this.ImgListaremover.Size = new System.Drawing.Size(26, 26);
            this.ImgListaremover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ImgListaremover.TabIndex = 17;
            this.ImgListaremover.TabStop = false;
            this.ImgListaremover.Click += new System.EventHandler(this.ImgListaremover_Click);
            // 
            // imgPausar
            // 
            this.imgPausar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.imgPausar.BackColor = System.Drawing.Color.Transparent;
            this.imgPausar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgPausar.Image = ((System.Drawing.Image)(resources.GetObject("imgPausar.Image")));
            this.imgPausar.Location = new System.Drawing.Point(375, 22);
            this.imgPausar.Name = "imgPausar";
            this.imgPausar.Size = new System.Drawing.Size(70, 70);
            this.imgPausar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgPausar.TabIndex = 14;
            this.imgPausar.TabStop = false;
            this.imgPausar.Click += new System.EventHandler(this.imgPausar_Click);
            // 
            // imgrepetir
            // 
            this.imgrepetir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.imgrepetir.BackColor = System.Drawing.Color.Transparent;
            this.imgrepetir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgrepetir.Image = ((System.Drawing.Image)(resources.GetObject("imgrepetir.Image")));
            this.imgrepetir.Location = new System.Drawing.Point(515, 44);
            this.imgrepetir.Name = "imgrepetir";
            this.imgrepetir.Size = new System.Drawing.Size(24, 24);
            this.imgrepetir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgrepetir.TabIndex = 13;
            this.imgrepetir.TabStop = false;
            this.imgrepetir.Click += new System.EventHandler(this.imgrepetir_Click);
            // 
            // ImgAleatorio
            // 
            this.ImgAleatorio.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ImgAleatorio.BackColor = System.Drawing.Color.Transparent;
            this.ImgAleatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImgAleatorio.Image = ((System.Drawing.Image)(resources.GetObject("ImgAleatorio.Image")));
            this.ImgAleatorio.Location = new System.Drawing.Point(277, 44);
            this.ImgAleatorio.Name = "ImgAleatorio";
            this.ImgAleatorio.Size = new System.Drawing.Size(24, 24);
            this.ImgAleatorio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ImgAleatorio.TabIndex = 12;
            this.ImgAleatorio.TabStop = false;
            // 
            // Imgvoltar
            // 
            this.Imgvoltar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Imgvoltar.BackColor = System.Drawing.Color.Transparent;
            this.Imgvoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Imgvoltar.Image = ((System.Drawing.Image)(resources.GetObject("Imgvoltar.Image")));
            this.Imgvoltar.Location = new System.Drawing.Point(325, 36);
            this.Imgvoltar.Name = "Imgvoltar";
            this.Imgvoltar.Size = new System.Drawing.Size(40, 40);
            this.Imgvoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Imgvoltar.TabIndex = 11;
            this.Imgvoltar.TabStop = false;
            this.Imgvoltar.Click += new System.EventHandler(this.Imgvoltar_Click);
            // 
            // imgAvancar
            // 
            this.imgAvancar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.imgAvancar.BackColor = System.Drawing.Color.Transparent;
            this.imgAvancar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgAvancar.Image = ((System.Drawing.Image)(resources.GetObject("imgAvancar.Image")));
            this.imgAvancar.Location = new System.Drawing.Point(454, 36);
            this.imgAvancar.Name = "imgAvancar";
            this.imgAvancar.Size = new System.Drawing.Size(40, 40);
            this.imgAvancar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgAvancar.TabIndex = 10;
            this.imgAvancar.TabStop = false;
            this.imgAvancar.Click += new System.EventHandler(this.imgAvancar_Click);
            // 
            // Imgplay
            // 
            this.Imgplay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Imgplay.BackColor = System.Drawing.Color.Transparent;
            this.Imgplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Imgplay.Image = ((System.Drawing.Image)(resources.GetObject("Imgplay.Image")));
            this.Imgplay.Location = new System.Drawing.Point(375, 22);
            this.Imgplay.Name = "Imgplay";
            this.Imgplay.Size = new System.Drawing.Size(70, 70);
            this.Imgplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Imgplay.TabIndex = 9;
            this.Imgplay.TabStop = false;
            this.Imgplay.Click += new System.EventHandler(this.Imgplay_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ListaReproducao
            // 
            this.ListaReproducao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListaReproducao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.ListaReproducao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListaReproducao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaReproducao.ForeColor = System.Drawing.Color.White;
            this.ListaReproducao.FormattingEnabled = true;
            this.ListaReproducao.ItemHeight = 15;
            this.ListaReproducao.Location = new System.Drawing.Point(628, 35);
            this.ListaReproducao.Name = "ListaReproducao";
            this.ListaReproducao.Size = new System.Drawing.Size(186, 435);
            this.ListaReproducao.TabIndex = 21;
            this.ListaReproducao.SelectedIndexChanged += new System.EventHandler(this.ListaReproducao_SelectedIndexChanged);
            // 
            // Player
            // 
            this.Player.AllowDrop = true;
            this.Player.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Player.Enabled = true;
            this.Player.Location = new System.Drawing.Point(26, 28);
            this.Player.Name = "Player";
            this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
            this.Player.Size = new System.Drawing.Size(602, 432);
            this.Player.TabIndex = 20;
            // 
            // LbLogo
            // 
            this.LbLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbLogo.AutoSize = true;
            this.LbLogo.BackColor = System.Drawing.Color.Transparent;
            this.LbLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLogo.ForeColor = System.Drawing.Color.White;
            this.LbLogo.Location = new System.Drawing.Point(187, 171);
            this.LbLogo.Name = "LbLogo";
            this.LbLogo.Size = new System.Drawing.Size(510, 73);
            this.LbLogo.TabIndex = 23;
            this.LbLogo.Text = "Seja Bem Vindo!";
            // 
            // LbSubtitulo
            // 
            this.LbSubtitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbSubtitulo.AutoSize = true;
            this.LbSubtitulo.BackColor = System.Drawing.Color.Transparent;
            this.LbSubtitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbSubtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSubtitulo.ForeColor = System.Drawing.Color.White;
            this.LbSubtitulo.Location = new System.Drawing.Point(220, 255);
            this.LbSubtitulo.Name = "LbSubtitulo";
            this.LbSubtitulo.Size = new System.Drawing.Size(459, 29);
            this.LbSubtitulo.TabIndex = 24;
            this.LbSubtitulo.Text = "Um Lugar Para as Suas Musicas e Vídeos";
            // 
            // Media
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(817, 566);
            this.Controls.Add(this.PainelReproducao);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.ListaReproducao);
            this.Controls.Add(this.LbSubtitulo);
            this.Controls.Add(this.LbLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Media";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media";
            this.Load += new System.EventHandler(this.Media_Load);
            this.PainelReproducao.ResumeLayout(false);
            this.PainelReproducao.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listavisivel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackvolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgListaremover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPausar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgrepetir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgAleatorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imgvoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAvancar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Imgplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PainelReproducao;
        private System.Windows.Forms.PictureBox Imgvoltar;
        private System.Windows.Forms.PictureBox imgrepetir;
        private System.Windows.Forms.PictureBox ImgAleatorio;
        private System.Windows.Forms.PictureBox imgAvancar;
        private System.Windows.Forms.PictureBox imgPausar;
        private System.Windows.Forms.PictureBox Imgplay;
        private System.Windows.Forms.PictureBox ImgListaremover;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LbPorcentoVolume;
        private System.Windows.Forms.Label Lbvolume;
        private System.Windows.Forms.TrackBar trackvolume;
        private System.Windows.Forms.Label LbFimreproducao;
        private System.Windows.Forms.ListBox ListaReproducao;
        private AxWMPLib.AxWindowsMediaPlayer Player;
        private System.Windows.Forms.Label LbInicioreproducao;
        private System.Windows.Forms.PictureBox listavisivel;
        private System.Windows.Forms.Label LbLogo;
        private System.Windows.Forms.Label LbSubtitulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}