namespace AppPrincipal
{
    partial class Cronometro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cronometro));
            this.TimerResul = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.LbIntervalos = new System.Windows.Forms.Label();
            this.ListaNumerodevoltas = new System.Windows.Forms.ListBox();
            this.ImgBuneroDeVoltas = new System.Windows.Forms.PictureBox();
            this.ImgRestaurar = new System.Windows.Forms.PictureBox();
            this.ImgIniciar = new System.Windows.Forms.PictureBox();
            this.ImgPausar = new System.Windows.Forms.PictureBox();
            this.Lb_Resul = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBuneroDeVoltas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgIniciar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPausar)).BeginInit();
            this.SuspendLayout();
            // 
            // TimerResul
            // 
            this.TimerResul.Enabled = true;
            this.TimerResul.Interval = 10;
            this.TimerResul.Tick += new System.EventHandler(this.TimerResul_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(4, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 24;
            this.label1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.imgLogo);
            this.panel1.Controls.Add(this.LbIntervalos);
            this.panel1.Controls.Add(this.ListaNumerodevoltas);
            this.panel1.Controls.Add(this.ImgBuneroDeVoltas);
            this.panel1.Controls.Add(this.ImgRestaurar);
            this.panel1.Controls.Add(this.ImgIniciar);
            this.panel1.Controls.Add(this.ImgPausar);
            this.panel1.Controls.Add(this.Lb_Resul);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(12, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 324);
            this.panel1.TabIndex = 28;
            // 
            // imgLogo
            // 
            this.imgLogo.BackColor = System.Drawing.Color.Transparent;
            this.imgLogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(209, 16);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(90, 90);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgLogo.TabIndex = 36;
            this.imgLogo.TabStop = false;
            // 
            // LbIntervalos
            // 
            this.LbIntervalos.AutoSize = true;
            this.LbIntervalos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbIntervalos.ForeColor = System.Drawing.Color.White;
            this.LbIntervalos.Location = new System.Drawing.Point(24, 117);
            this.LbIntervalos.Name = "LbIntervalos";
            this.LbIntervalos.Size = new System.Drawing.Size(66, 16);
            this.LbIntervalos.TabIndex = 35;
            this.LbIntervalos.Text = "Intervalos";
            // 
            // ListaNumerodevoltas
            // 
            this.ListaNumerodevoltas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.ListaNumerodevoltas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListaNumerodevoltas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaNumerodevoltas.ForeColor = System.Drawing.Color.White;
            this.ListaNumerodevoltas.FormattingEnabled = true;
            this.ListaNumerodevoltas.ItemHeight = 16;
            this.ListaNumerodevoltas.Location = new System.Drawing.Point(24, 140);
            this.ListaNumerodevoltas.Name = "ListaNumerodevoltas";
            this.ListaNumerodevoltas.Size = new System.Drawing.Size(67, 176);
            this.ListaNumerodevoltas.TabIndex = 34;
            // 
            // ImgBuneroDeVoltas
            // 
            this.ImgBuneroDeVoltas.BackColor = System.Drawing.Color.Transparent;
            this.ImgBuneroDeVoltas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImgBuneroDeVoltas.Image = ((System.Drawing.Image)(resources.GetObject("ImgBuneroDeVoltas.Image")));
            this.ImgBuneroDeVoltas.Location = new System.Drawing.Point(326, 275);
            this.ImgBuneroDeVoltas.Name = "ImgBuneroDeVoltas";
            this.ImgBuneroDeVoltas.Size = new System.Drawing.Size(23, 23);
            this.ImgBuneroDeVoltas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ImgBuneroDeVoltas.TabIndex = 33;
            this.ImgBuneroDeVoltas.TabStop = false;
            this.ImgBuneroDeVoltas.Click += new System.EventHandler(this.ImgBuneroDeVoltas_Click);
            // 
            // ImgRestaurar
            // 
            this.ImgRestaurar.BackColor = System.Drawing.Color.Transparent;
            this.ImgRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImgRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("ImgRestaurar.Image")));
            this.ImgRestaurar.Location = new System.Drawing.Point(202, 275);
            this.ImgRestaurar.Name = "ImgRestaurar";
            this.ImgRestaurar.Size = new System.Drawing.Size(23, 23);
            this.ImgRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ImgRestaurar.TabIndex = 32;
            this.ImgRestaurar.TabStop = false;
            this.ImgRestaurar.Click += new System.EventHandler(this.ImgRestaurar_Click_1);
            // 
            // ImgIniciar
            // 
            this.ImgIniciar.BackColor = System.Drawing.Color.Transparent;
            this.ImgIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImgIniciar.Image = ((System.Drawing.Image)(resources.GetObject("ImgIniciar.Image")));
            this.ImgIniciar.Location = new System.Drawing.Point(249, 263);
            this.ImgIniciar.Name = "ImgIniciar";
            this.ImgIniciar.Size = new System.Drawing.Size(50, 50);
            this.ImgIniciar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ImgIniciar.TabIndex = 31;
            this.ImgIniciar.TabStop = false;
            this.ImgIniciar.Click += new System.EventHandler(this.ImgIniciar_Click);
            // 
            // ImgPausar
            // 
            this.ImgPausar.BackColor = System.Drawing.Color.Transparent;
            this.ImgPausar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImgPausar.Image = ((System.Drawing.Image)(resources.GetObject("ImgPausar.Image")));
            this.ImgPausar.Location = new System.Drawing.Point(249, 263);
            this.ImgPausar.Name = "ImgPausar";
            this.ImgPausar.Size = new System.Drawing.Size(50, 50);
            this.ImgPausar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ImgPausar.TabIndex = 30;
            this.ImgPausar.TabStop = false;
            this.ImgPausar.Click += new System.EventHandler(this.ImgPausar_Click_1);
            // 
            // Lb_Resul
            // 
            this.Lb_Resul.AutoSize = true;
            this.Lb_Resul.BackColor = System.Drawing.Color.Transparent;
            this.Lb_Resul.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Resul.ForeColor = System.Drawing.Color.White;
            this.Lb_Resul.Location = new System.Drawing.Point(138, 140);
            this.Lb_Resul.Name = "Lb_Resul";
            this.Lb_Resul.Size = new System.Drawing.Size(292, 55);
            this.Lb_Resul.TabIndex = 29;
            this.Lb_Resul.Text = "00:00:00:00 ";
            this.Lb_Resul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(113, 69);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(0, 10);
            this.button4.TabIndex = 28;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Cronometro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(512, 386);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cronometro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cronometro";
            this.Load += new System.EventHandler(this.Cronometro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBuneroDeVoltas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgIniciar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPausar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer TimerResul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label LbIntervalos;
        private System.Windows.Forms.ListBox ListaNumerodevoltas;
        private System.Windows.Forms.PictureBox ImgBuneroDeVoltas;
        private System.Windows.Forms.PictureBox ImgRestaurar;
        private System.Windows.Forms.PictureBox ImgIniciar;
        private System.Windows.Forms.PictureBox ImgPausar;
        private System.Windows.Forms.Label Lb_Resul;
        private System.Windows.Forms.Button button4;
    }
}