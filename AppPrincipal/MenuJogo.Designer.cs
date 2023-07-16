namespace AppPrincipal
{
    partial class MenuJogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuJogo));
            this.Btnfacil = new System.Windows.Forms.Button();
            this.btnMedio = new System.Windows.Forms.Button();
            this.BtnDificil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Btnfechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btnfacil
            // 
            this.Btnfacil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btnfacil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btnfacil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btnfacil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnfacil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnfacil.ForeColor = System.Drawing.Color.White;
            this.Btnfacil.Location = new System.Drawing.Point(84, 64);
            this.Btnfacil.Name = "Btnfacil";
            this.Btnfacil.Size = new System.Drawing.Size(186, 48);
            this.Btnfacil.TabIndex = 0;
            this.Btnfacil.Text = "Fácil";
            this.Btnfacil.UseVisualStyleBackColor = false;
            this.Btnfacil.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMedio
            // 
            this.btnMedio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMedio.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMedio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMedio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedio.ForeColor = System.Drawing.Color.White;
            this.btnMedio.Location = new System.Drawing.Point(84, 141);
            this.btnMedio.Name = "btnMedio";
            this.btnMedio.Size = new System.Drawing.Size(186, 48);
            this.btnMedio.TabIndex = 1;
            this.btnMedio.Text = "Médio";
            this.btnMedio.UseVisualStyleBackColor = false;
            this.btnMedio.Click += new System.EventHandler(this.btnMedio_Click);
            // 
            // BtnDificil
            // 
            this.BtnDificil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnDificil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnDificil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDificil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDificil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDificil.ForeColor = System.Drawing.Color.White;
            this.BtnDificil.Location = new System.Drawing.Point(84, 216);
            this.BtnDificil.Name = "BtnDificil";
            this.BtnDificil.Size = new System.Drawing.Size(186, 48);
            this.BtnDificil.TabIndex = 2;
            this.BtnDificil.Text = "Difícil";
            this.BtnDificil.UseVisualStyleBackColor = false;
            this.BtnDificil.Click += new System.EventHandler(this.BtnDificil_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(83, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nivel de Dificuldade";
            // 
            // Btnfechar
            // 
            this.Btnfechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btnfechar.FlatAppearance.BorderSize = 0;
            this.Btnfechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Btnfechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnfechar.Image = ((System.Drawing.Image)(resources.GetObject("Btnfechar.Image")));
            this.Btnfechar.Location = new System.Drawing.Point(320, -1);
            this.Btnfechar.Name = "Btnfechar";
            this.Btnfechar.Size = new System.Drawing.Size(33, 33);
            this.Btnfechar.TabIndex = 12;
            this.Btnfechar.UseVisualStyleBackColor = true;
            this.Btnfechar.Click += new System.EventHandler(this.Btnfechar_Click);
            // 
            // MenuJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(354, 284);
            this.Controls.Add(this.Btnfechar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnDificil);
            this.Controls.Add(this.btnMedio);
            this.Controls.Add(this.Btnfacil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuJogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MenuJogo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btnfacil;
        private System.Windows.Forms.Button btnMedio;
        private System.Windows.Forms.Button BtnDificil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btnfechar;
    }
}