namespace Serviços_Sociais___Gestão
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.btSair = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btConsultar = new System.Windows.Forms.Button();
            this.btRegComp = new System.Windows.Forms.Button();
            this.btRegistar = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btSair
            // 
            this.btSair.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btSair.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btSair.ForeColor = System.Drawing.Color.White;
            this.btSair.Location = new System.Drawing.Point(470, 696);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(148, 53);
            this.btSair.TabIndex = 1;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 678);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // btConsultar
            // 
            this.btConsultar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btConsultar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btConsultar.BackgroundImage = global::Serviços_Sociais___Gestão.Properties.Resources.user_removebg_preview1;
            this.btConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btConsultar.Location = new System.Drawing.Point(769, 312);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(292, 264);
            this.btConsultar.TabIndex = 5;
            this.btConsultar.UseVisualStyleBackColor = false;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // btRegComp
            // 
            this.btRegComp.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btRegComp.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btRegComp.BackgroundImage = global::Serviços_Sociais___Gestão.Properties.Resources.blogging_removebg_preview1;
            this.btRegComp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btRegComp.Location = new System.Drawing.Point(399, 312);
            this.btRegComp.Name = "btRegComp";
            this.btRegComp.Size = new System.Drawing.Size(292, 264);
            this.btRegComp.TabIndex = 4;
            this.btRegComp.UseVisualStyleBackColor = false;
            this.btRegComp.Click += new System.EventHandler(this.btRegComp_Click);
            // 
            // btRegistar
            // 
            this.btRegistar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btRegistar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btRegistar.BackgroundImage = global::Serviços_Sociais___Gestão.Properties.Resources.add_user_removebg_preview1;
            this.btRegistar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btRegistar.Location = new System.Drawing.Point(20, 312);
            this.btRegistar.Name = "btRegistar";
            this.btRegistar.Size = new System.Drawing.Size(292, 264);
            this.btRegistar.TabIndex = 3;
            this.btRegistar.UseVisualStyleBackColor = false;
            this.btRegistar.Click += new System.EventHandler(this.btRegistar_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(228, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(629, 222);
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(1084, 761);
            this.ControlBox = false;
            this.Controls.Add(this.btConsultar);
            this.Controls.Add(this.btRegComp);
            this.Controls.Add(this.btRegistar);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btRegistar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btRegComp;
        private System.Windows.Forms.Button btConsultar;
    }
}

