namespace Serviços_Sociais___Gestão
{
    partial class RegConj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegConj));
            this.gbConjuge = new System.Windows.Forms.GroupBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btGuardarC = new System.Windows.Forms.Button();
            this.txtADSE = new System.Windows.Forms.TextBox();
            this.dtpConjuge = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNConjuge = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btConfirmar = new System.Windows.Forms.Button();
            this.lblQuantos = new System.Windows.Forms.Label();
            this.rbNao = new System.Windows.Forms.RadioButton();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.lblDesc = new System.Windows.Forms.Label();
            this.rbSim = new System.Windows.Forms.RadioButton();
            this.servicos_SociaisDataSet = new Serviços_Sociais___Gestão.Servicos_SociaisDataSet();
            this.conjugeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conjugeTableAdapter = new Serviços_Sociais___Gestão.Servicos_SociaisDataSetTableAdapters.ConjugeTableAdapter();
            this.tableAdapterManager = new Serviços_Sociais___Gestão.Servicos_SociaisDataSetTableAdapters.TableAdapterManager();
            this.sóciosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sóciosTableAdapter = new Serviços_Sociais___Gestão.Servicos_SociaisDataSetTableAdapters.SóciosTableAdapter();
            this.rbCNao = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rbCSim = new System.Windows.Forms.RadioButton();
            this.gbConjuge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicos_SociaisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conjugeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sóciosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbConjuge
            // 
            this.gbConjuge.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbConjuge.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.gbConjuge.Controls.Add(this.btCancelar);
            this.gbConjuge.Controls.Add(this.btGuardarC);
            this.gbConjuge.Controls.Add(this.txtADSE);
            this.gbConjuge.Controls.Add(this.dtpConjuge);
            this.gbConjuge.Controls.Add(this.label11);
            this.gbConjuge.Controls.Add(this.label10);
            this.gbConjuge.Controls.Add(this.txtNConjuge);
            this.gbConjuge.Controls.Add(this.label9);
            this.gbConjuge.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConjuge.Location = new System.Drawing.Point(181, 141);
            this.gbConjuge.Name = "gbConjuge";
            this.gbConjuge.Size = new System.Drawing.Size(702, 152);
            this.gbConjuge.TabIndex = 22;
            this.gbConjuge.TabStop = false;
            this.gbConjuge.Text = "Conjuge";
            this.gbConjuge.Visible = false;
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.DarkKhaki;
            this.btCancelar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(513, 100);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(84, 33);
            this.btCancelar.TabIndex = 49;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btGuardarC
            // 
            this.btGuardarC.BackColor = System.Drawing.Color.DarkKhaki;
            this.btGuardarC.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardarC.Location = new System.Drawing.Point(603, 100);
            this.btGuardarC.Name = "btGuardarC";
            this.btGuardarC.Size = new System.Drawing.Size(84, 33);
            this.btGuardarC.TabIndex = 15;
            this.btGuardarC.Text = "Guardar";
            this.btGuardarC.UseVisualStyleBackColor = false;
            this.btGuardarC.Click += new System.EventHandler(this.btGuardarC_Click);
            // 
            // txtADSE
            // 
            this.txtADSE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtADSE.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtADSE.Location = new System.Drawing.Point(226, 100);
            this.txtADSE.Name = "txtADSE";
            this.txtADSE.Size = new System.Drawing.Size(242, 27);
            this.txtADSE.TabIndex = 10;
            // 
            // dtpConjuge
            // 
            this.dtpConjuge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpConjuge.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpConjuge.Location = new System.Drawing.Point(226, 63);
            this.dtpConjuge.Name = "dtpConjuge";
            this.dtpConjuge.Size = new System.Drawing.Size(242, 27);
            this.dtpConjuge.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(214, 23);
            this.label11.TabIndex = 5;
            this.label11.Text = "Nº ADSE/Serviços Sociais:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 23);
            this.label10.TabIndex = 3;
            this.label10.Text = "Data de Nascimento:";
            // 
            // txtNConjuge
            // 
            this.txtNConjuge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNConjuge.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNConjuge.Location = new System.Drawing.Point(226, 27);
            this.txtNConjuge.Name = "txtNConjuge";
            this.txtNConjuge.Size = new System.Drawing.Size(470, 27);
            this.txtNConjuge.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 23);
            this.label9.TabIndex = 1;
            this.label9.Text = "Nome Completo:";
            // 
            // btConfirmar
            // 
            this.btConfirmar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btConfirmar.ForeColor = System.Drawing.Color.White;
            this.btConfirmar.Location = new System.Drawing.Point(439, 464);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Size = new System.Drawing.Size(166, 47);
            this.btConfirmar.TabIndex = 48;
            this.btConfirmar.Text = "Confirmar";
            this.btConfirmar.UseVisualStyleBackColor = false;
            this.btConfirmar.Visible = false;
            this.btConfirmar.Click += new System.EventHandler(this.btConfirmar_Click);
            // 
            // lblQuantos
            // 
            this.lblQuantos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuantos.AutoSize = true;
            this.lblQuantos.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantos.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantos.Location = new System.Drawing.Point(439, 418);
            this.lblQuantos.Name = "lblQuantos";
            this.lblQuantos.Size = new System.Drawing.Size(86, 23);
            this.lblQuantos.TabIndex = 47;
            this.lblQuantos.Text = "Quantos?";
            this.lblQuantos.Visible = false;
            // 
            // rbNao
            // 
            this.rbNao.AutoSize = true;
            this.rbNao.BackColor = System.Drawing.Color.Transparent;
            this.rbNao.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.rbNao.Location = new System.Drawing.Point(502, 379);
            this.rbNao.Name = "rbNao";
            this.rbNao.Size = new System.Drawing.Size(60, 27);
            this.rbNao.TabIndex = 46;
            this.rbNao.TabStop = true;
            this.rbNao.Text = "Não";
            this.rbNao.UseVisualStyleBackColor = false;
            this.rbNao.Visible = false;
            this.rbNao.CheckedChanged += new System.EventHandler(this.rbNao_CheckedChanged);
            // 
            // numericUpDown
            // 
            this.numericUpDown.BackColor = System.Drawing.Color.Khaki;
            this.numericUpDown.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown.Location = new System.Drawing.Point(531, 414);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(40, 27);
            this.numericUpDown.TabIndex = 44;
            this.numericUpDown.Visible = false;
            this.numericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // lblDesc
            // 
            this.lblDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDesc.AutoSize = true;
            this.lblDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblDesc.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(439, 353);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(166, 23);
            this.lblDesc.TabIndex = 43;
            this.lblDesc.Text = "Tem descendentes?";
            this.lblDesc.Visible = false;
            // 
            // rbSim
            // 
            this.rbSim.AutoSize = true;
            this.rbSim.BackColor = System.Drawing.Color.Transparent;
            this.rbSim.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.rbSim.Location = new System.Drawing.Point(439, 379);
            this.rbSim.Name = "rbSim";
            this.rbSim.Size = new System.Drawing.Size(57, 27);
            this.rbSim.TabIndex = 45;
            this.rbSim.TabStop = true;
            this.rbSim.Text = "Sim";
            this.rbSim.UseVisualStyleBackColor = false;
            this.rbSim.Visible = false;
            this.rbSim.CheckedChanged += new System.EventHandler(this.rbSim_CheckedChanged);
            // 
            // servicos_SociaisDataSet
            // 
            this.servicos_SociaisDataSet.DataSetName = "Servicos_SociaisDataSet";
            this.servicos_SociaisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // conjugeBindingSource
            // 
            this.conjugeBindingSource.DataMember = "Conjuge";
            this.conjugeBindingSource.DataSource = this.servicos_SociaisDataSet;
            // 
            // conjugeTableAdapter
            // 
            this.conjugeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssistenciasTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ComparticipacoesTableAdapter = null;
            this.tableAdapterManager.ConjugeTableAdapter = this.conjugeTableAdapter;
            this.tableAdapterManager.DescendentesTableAdapter = null;
            this.tableAdapterManager.EstadoCivilTableAdapter = null;
            this.tableAdapterManager.GeneroTableAdapter = null;
            this.tableAdapterManager.ParentescoTableAdapter = null;
            this.tableAdapterManager.ServiçoTableAdapter = null;
            this.tableAdapterManager.SistemaSaudeTableAdapter = null;
            this.tableAdapterManager.SóciosTableAdapter = null;
            this.tableAdapterManager.TipoAssistenciaTableAdapter = null;
            this.tableAdapterManager.TipoPagamentoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Serviços_Sociais___Gestão.Servicos_SociaisDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sóciosBindingSource
            // 
            this.sóciosBindingSource.DataMember = "Sócios";
            this.sóciosBindingSource.DataSource = this.servicos_SociaisDataSet;
            // 
            // sóciosTableAdapter
            // 
            this.sóciosTableAdapter.ClearBeforeFill = true;
            // 
            // rbCNao
            // 
            this.rbCNao.AutoSize = true;
            this.rbCNao.BackColor = System.Drawing.Color.Transparent;
            this.rbCNao.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.rbCNao.Location = new System.Drawing.Point(526, 62);
            this.rbCNao.Name = "rbCNao";
            this.rbCNao.Size = new System.Drawing.Size(60, 27);
            this.rbCNao.TabIndex = 51;
            this.rbCNao.TabStop = true;
            this.rbCNao.Text = "Não";
            this.rbCNao.UseVisualStyleBackColor = false;
            this.rbCNao.CheckedChanged += new System.EventHandler(this.rbCNao_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(403, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 23);
            this.label1.TabIndex = 49;
            this.label1.Text = "O conjuge vai ser beneficiante?";
            // 
            // rbCSim
            // 
            this.rbCSim.AutoSize = true;
            this.rbCSim.BackColor = System.Drawing.Color.Transparent;
            this.rbCSim.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.rbCSim.Location = new System.Drawing.Point(463, 62);
            this.rbCSim.Name = "rbCSim";
            this.rbCSim.Size = new System.Drawing.Size(57, 27);
            this.rbCSim.TabIndex = 50;
            this.rbCSim.TabStop = true;
            this.rbCSim.Text = "Sim";
            this.rbCSim.UseVisualStyleBackColor = false;
            this.rbCSim.CheckedChanged += new System.EventHandler(this.rbCSim_CheckedChanged);
            // 
            // RegConj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1058, 676);
            this.ControlBox = false;
            this.Controls.Add(this.rbCNao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbCSim);
            this.Controls.Add(this.btConfirmar);
            this.Controls.Add(this.lblQuantos);
            this.Controls.Add(this.rbNao);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.rbSim);
            this.Controls.Add(this.gbConjuge);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegConj";
            this.Load += new System.EventHandler(this.RegistoDoc_Load);
            this.gbConjuge.ResumeLayout(false);
            this.gbConjuge.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicos_SociaisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conjugeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sóciosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbConjuge;
        private System.Windows.Forms.Button btGuardarC;
        private System.Windows.Forms.TextBox txtADSE;
        private System.Windows.Forms.DateTimePicker dtpConjuge;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNConjuge;
        private System.Windows.Forms.Label label9;
        private Servicos_SociaisDataSet servicos_SociaisDataSet;
        private System.Windows.Forms.BindingSource conjugeBindingSource;
        private Servicos_SociaisDataSetTableAdapters.ConjugeTableAdapter conjugeTableAdapter;
        private Servicos_SociaisDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btConfirmar;
        private System.Windows.Forms.Label lblQuantos;
        private System.Windows.Forms.RadioButton rbNao;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.RadioButton rbSim;
        private System.Windows.Forms.BindingSource sóciosBindingSource;
        private Servicos_SociaisDataSetTableAdapters.SóciosTableAdapter sóciosTableAdapter;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.RadioButton rbCNao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbCSim;
    }
}