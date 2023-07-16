namespace AppPrincipal
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.ImgBola = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LBpontos = new System.Windows.Forms.Label();
            this.ImgRaquete = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgRaquete)).BeginInit();
            this.SuspendLayout();
            // 
            // ImgBola
            // 
            this.ImgBola.BackColor = System.Drawing.Color.Transparent;
            this.ImgBola.Image = ((System.Drawing.Image)(resources.GetObject("ImgBola.Image")));
            this.ImgBola.Location = new System.Drawing.Point(154, 147);
            this.ImgBola.Name = "ImgBola";
            this.ImgBola.Size = new System.Drawing.Size(27, 33);
            this.ImgBola.TabIndex = 3;
            this.ImgBola.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LBpontos
            // 
            this.LBpontos.AutoSize = true;
            this.LBpontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBpontos.Location = new System.Drawing.Point(12, 9);
            this.LBpontos.Name = "LBpontos";
            this.LBpontos.Size = new System.Drawing.Size(0, 20);
            this.LBpontos.TabIndex = 5;
            // 
            // ImgRaquete
            // 
            this.ImgRaquete.BackColor = System.Drawing.Color.LightGray;
            this.ImgRaquete.Location = new System.Drawing.Point(606, 107);
            this.ImgRaquete.Name = "ImgRaquete";
            this.ImgRaquete.Size = new System.Drawing.Size(10, 200);
            this.ImgRaquete.TabIndex = 4;
            this.ImgRaquete.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(616, 405);
            this.Controls.Add(this.LBpontos);
            this.Controls.Add(this.ImgRaquete);
            this.Controls.Add(this.ImgBola);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.Click += new System.EventHandler(this.Game_Click);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Game_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.ImgBola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgRaquete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox ImgBola;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LBpontos;
        private System.Windows.Forms.PictureBox ImgRaquete;
    }
}