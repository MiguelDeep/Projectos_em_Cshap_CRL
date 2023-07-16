namespace AppPrincipal
{
    partial class Browser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Browser));
            this.PainelTopo = new System.Windows.Forms.Panel();
            this.btnhome = new System.Windows.Forms.Button();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnavancar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PainelTopo.SuspendLayout();
            this.SuspendLayout();
            // 
            // PainelTopo
            // 
            this.PainelTopo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PainelTopo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.PainelTopo.Controls.Add(this.btnhome);
            this.PainelTopo.Controls.Add(this.btnpesquisar);
            this.PainelTopo.Controls.Add(this.btnActualizar);
            this.PainelTopo.Controls.Add(this.btnavancar);
            this.PainelTopo.Controls.Add(this.btnvoltar);
            this.PainelTopo.Controls.Add(this.textBox1);
            this.PainelTopo.Location = new System.Drawing.Point(0, 0);
            this.PainelTopo.Name = "PainelTopo";
            this.PainelTopo.Size = new System.Drawing.Size(968, 61);
            this.PainelTopo.TabIndex = 0;
            this.PainelTopo.Paint += new System.Windows.Forms.PaintEventHandler(this.PainelTopo_Paint);
            // 
            // btnhome
            // 
            this.btnhome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnhome.FlatAppearance.BorderSize = 0;
            this.btnhome.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhome.Image = ((System.Drawing.Image)(resources.GetObject("btnhome.Image")));
            this.btnhome.Location = new System.Drawing.Point(110, 20);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(34, 26);
            this.btnhome.TabIndex = 29;
            this.btnhome.UseVisualStyleBackColor = true;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnpesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpesquisar.FlatAppearance.BorderSize = 0;
            this.btnpesquisar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnpesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnpesquisar.Image")));
            this.btnpesquisar.Location = new System.Drawing.Point(842, 20);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(34, 26);
            this.btnpesquisar.TabIndex = 29;
            this.btnpesquisar.UseVisualStyleBackColor = true;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.Location = new System.Drawing.Point(75, 20);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(34, 26);
            this.btnActualizar.TabIndex = 28;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnavancar
            // 
            this.btnavancar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnavancar.FlatAppearance.BorderSize = 0;
            this.btnavancar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnavancar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnavancar.Image = ((System.Drawing.Image)(resources.GetObject("btnavancar.Image")));
            this.btnavancar.Location = new System.Drawing.Point(40, 20);
            this.btnavancar.Name = "btnavancar";
            this.btnavancar.Size = new System.Drawing.Size(34, 26);
            this.btnavancar.TabIndex = 22;
            this.btnavancar.UseVisualStyleBackColor = true;
            this.btnavancar.Click += new System.EventHandler(this.btnavancar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnvoltar.FlatAppearance.BorderSize = 0;
            this.btnvoltar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnvoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnvoltar.Image")));
            this.btnvoltar.Location = new System.Drawing.Point(0, 20);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(34, 26);
            this.btnvoltar.TabIndex = 22;
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Silver;
            this.textBox1.Location = new System.Drawing.Point(150, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(677, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Digite algo para pesquisar ou insira o endereço Web";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(0, 52);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(968, 694);
            this.webBrowser1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(0, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 694);
            this.panel1.TabIndex = 22;
            // 
            // Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(968, 746);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.PainelTopo);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Browser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Browser";
            this.PainelTopo.ResumeLayout(false);
            this.PainelTopo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PainelTopo;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnavancar;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.Button btnhome;
    }
}