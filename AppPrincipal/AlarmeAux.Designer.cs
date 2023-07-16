namespace AppPrincipal
{
    partial class AlarmeAux
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlarmeAux));
            this.btnParar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.imgAlarme = new System.Windows.Forms.PictureBox();
            this.LbMinuto = new System.Windows.Forms.Label();
            this.LbHora = new System.Windows.Forms.Label();
            this.Lb2Pontos = new System.Windows.Forms.Label();
            this.LbEstadado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgAlarme)).BeginInit();
            this.SuspendLayout();
            // 
            // btnParar
            // 
            this.btnParar.AnimationHoverSpeed = 0.07F;
            this.btnParar.AnimationSpeed = 0.03F;
            this.btnParar.BackColor = System.Drawing.Color.Transparent;
            this.btnParar.BaseColor = System.Drawing.Color.Red;
            this.btnParar.BorderColor = System.Drawing.Color.Black;
            this.btnParar.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnParar.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnParar.CheckedForeColor = System.Drawing.Color.White;
            this.btnParar.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnParar.CheckedImage")));
            this.btnParar.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnParar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnParar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnParar.FocusedColor = System.Drawing.Color.Empty;
            this.btnParar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParar.ForeColor = System.Drawing.Color.White;
            this.btnParar.Image = null;
            this.btnParar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnParar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnParar.Location = new System.Drawing.Point(73, 200);
            this.btnParar.Name = "btnParar";
            this.btnParar.OnHoverBaseColor = System.Drawing.Color.Red;
            this.btnParar.OnHoverBorderColor = System.Drawing.Color.Red;
            this.btnParar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnParar.OnHoverImage = null;
            this.btnParar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnParar.OnPressedColor = System.Drawing.Color.Black;
            this.btnParar.Radius = 8;
            this.btnParar.Size = new System.Drawing.Size(131, 49);
            this.btnParar.TabIndex = 0;
            this.btnParar.Text = "Parar";
            this.btnParar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // imgAlarme
            // 
            this.imgAlarme.Image = ((System.Drawing.Image)(resources.GetObject("imgAlarme.Image")));
            this.imgAlarme.Location = new System.Drawing.Point(115, 12);
            this.imgAlarme.Name = "imgAlarme";
            this.imgAlarme.Size = new System.Drawing.Size(50, 50);
            this.imgAlarme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgAlarme.TabIndex = 1;
            this.imgAlarme.TabStop = false;
            // 
            // LbMinuto
            // 
            this.LbMinuto.AutoSize = true;
            this.LbMinuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbMinuto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMinuto.ForeColor = System.Drawing.Color.White;
            this.LbMinuto.Location = new System.Drawing.Point(153, 144);
            this.LbMinuto.Name = "LbMinuto";
            this.LbMinuto.Size = new System.Drawing.Size(28, 21);
            this.LbMinuto.TabIndex = 3;
            this.LbMinuto.Text = "00";
            // 
            // LbHora
            // 
            this.LbHora.AutoSize = true;
            this.LbHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbHora.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHora.ForeColor = System.Drawing.Color.White;
            this.LbHora.Location = new System.Drawing.Point(99, 144);
            this.LbHora.Name = "LbHora";
            this.LbHora.Size = new System.Drawing.Size(28, 21);
            this.LbHora.TabIndex = 4;
            this.LbHora.Text = "00";
            this.LbHora.Click += new System.EventHandler(this.LbHora_Click);
            // 
            // Lb2Pontos
            // 
            this.Lb2Pontos.AutoSize = true;
            this.Lb2Pontos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb2Pontos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb2Pontos.ForeColor = System.Drawing.Color.White;
            this.Lb2Pontos.Location = new System.Drawing.Point(133, 144);
            this.Lb2Pontos.Name = "Lb2Pontos";
            this.Lb2Pontos.Size = new System.Drawing.Size(14, 21);
            this.Lb2Pontos.TabIndex = 5;
            this.Lb2Pontos.Text = ":";
            // 
            // LbEstadado
            // 
            this.LbEstadado.AutoSize = true;
            this.LbEstadado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbEstadado.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEstadado.ForeColor = System.Drawing.Color.White;
            this.LbEstadado.Location = new System.Drawing.Point(71, 75);
            this.LbEstadado.Name = "LbEstadado";
            this.LbEstadado.Size = new System.Drawing.Size(138, 23);
            this.LbEstadado.TabIndex = 6;
            this.LbEstadado.Text = "Estado do Dia";
            this.LbEstadado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AlarmeAux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(280, 261);
            this.Controls.Add(this.LbEstadado);
            this.Controls.Add(this.Lb2Pontos);
            this.Controls.Add(this.LbHora);
            this.Controls.Add(this.LbMinuto);
            this.Controls.Add(this.imgAlarme);
            this.Controls.Add(this.btnParar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlarmeAux";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlarmeAux";
            this.Load += new System.EventHandler(this.AlarmeAux_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgAlarme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaAdvenceButton btnParar;
        private System.Windows.Forms.PictureBox imgAlarme;
        private System.Windows.Forms.Label LbMinuto;
        private System.Windows.Forms.Label LbHora;
        private System.Windows.Forms.Label Lb2Pontos;
        private System.Windows.Forms.Label LbEstadado;
    }
}