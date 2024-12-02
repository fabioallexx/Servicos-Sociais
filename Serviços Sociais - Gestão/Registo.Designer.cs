namespace Serviços_Sociais___Gestão
{
    partial class Registo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registo));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerDN = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbEC = new System.Windows.Forms.ComboBox();
            this.estadoCivilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicos_SociaisDataSet = new Serviços_Sociais___Gestão.Servicos_SociaisDataSet();
            this.lblMorada = new System.Windows.Forms.Label();
            this.txtMorada = new System.Windows.Forms.TextBox();
            this.lblCP = new System.Windows.Forms.Label();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtTelemovel = new System.Windows.Forms.TextBox();
            this.cbGen = new System.Windows.Forms.ComboBox();
            this.generoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btGravar = new System.Windows.Forms.Button();
            this.lblDesc = new System.Windows.Forms.Label();
            this.estadoCivilTableAdapter = new Serviços_Sociais___Gestão.Servicos_SociaisDataSetTableAdapters.EstadoCivilTableAdapter();
            this.tableAdapterManager = new Serviços_Sociais___Gestão.Servicos_SociaisDataSetTableAdapters.TableAdapterManager();
            this.rbSim = new System.Windows.Forms.RadioButton();
            this.rbNao = new System.Windows.Forms.RadioButton();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.lblQuantos = new System.Windows.Forms.Label();
            this.txtNSS = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbServ = new System.Windows.Forms.ComboBox();
            this.serviçoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtNF = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNIF = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBIC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIBAN = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNISS = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbSS = new System.Windows.Forms.ComboBox();
            this.sistemaSaudeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.btConfirmar = new System.Windows.Forms.Button();
            this.sóciosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sóciosTableAdapter = new Serviços_Sociais___Gestão.Servicos_SociaisDataSetTableAdapters.SóciosTableAdapter();
            this.sistemaSaudeTableAdapter = new Serviços_Sociais___Gestão.Servicos_SociaisDataSetTableAdapters.SistemaSaudeTableAdapter();
            this.serviçoTableAdapter = new Serviços_Sociais___Gestão.Servicos_SociaisDataSetTableAdapters.ServiçoTableAdapter();
            this.generoTableAdapter = new Serviços_Sociais___Gestão.Servicos_SociaisDataSetTableAdapters.GeneroTableAdapter();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePickerDA = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.estadoCivilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicos_SociaisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviçoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaSaudeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sóciosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(198, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Completo:";
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.BackColor = System.Drawing.Color.Khaki;
            this.txtNome.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(402, 60);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(463, 27);
            this.txtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(198, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data de Nascimento:";
            // 
            // dateTimePickerDN
            // 
            this.dateTimePickerDN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDN.CalendarMonthBackground = System.Drawing.Color.Khaki;
            this.dateTimePickerDN.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDN.Location = new System.Drawing.Point(402, 126);
            this.dateTimePickerDN.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerDN.Name = "dateTimePickerDN";
            this.dateTimePickerDN.Size = new System.Drawing.Size(212, 27);
            this.dateTimePickerDN.TabIndex = 3;
            this.dateTimePickerDN.ValueChanged += new System.EventHandler(this.dateTimePickerDN_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(198, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Estado Civil:";
            // 
            // cbEC
            // 
            this.cbEC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEC.BackColor = System.Drawing.Color.Khaki;
            this.cbEC.DataSource = this.estadoCivilBindingSource;
            this.cbEC.DisplayMember = "EstadoCivil";
            this.cbEC.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEC.FormattingEnabled = true;
            this.cbEC.Location = new System.Drawing.Point(402, 159);
            this.cbEC.Name = "cbEC";
            this.cbEC.Size = new System.Drawing.Size(212, 27);
            this.cbEC.TabIndex = 5;
            this.cbEC.ValueMember = "EstadoCivil";
            // 
            // estadoCivilBindingSource
            // 
            this.estadoCivilBindingSource.DataMember = "EstadoCivil";
            this.estadoCivilBindingSource.DataSource = this.servicos_SociaisDataSet;
            // 
            // servicos_SociaisDataSet
            // 
            this.servicos_SociaisDataSet.DataSetName = "Servicos_SociaisDataSet";
            this.servicos_SociaisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblMorada
            // 
            this.lblMorada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMorada.AutoSize = true;
            this.lblMorada.BackColor = System.Drawing.Color.Transparent;
            this.lblMorada.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.lblMorada.Location = new System.Drawing.Point(198, 195);
            this.lblMorada.Name = "lblMorada";
            this.lblMorada.Size = new System.Drawing.Size(168, 24);
            this.lblMorada.TabIndex = 6;
            this.lblMorada.Text = "Morada Completa:";
            // 
            // txtMorada
            // 
            this.txtMorada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMorada.BackColor = System.Drawing.Color.Khaki;
            this.txtMorada.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMorada.Location = new System.Drawing.Point(402, 192);
            this.txtMorada.Name = "txtMorada";
            this.txtMorada.Size = new System.Drawing.Size(463, 27);
            this.txtMorada.TabIndex = 7;
            // 
            // lblCP
            // 
            this.lblCP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCP.AutoSize = true;
            this.lblCP.BackColor = System.Drawing.Color.Transparent;
            this.lblCP.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.lblCP.Location = new System.Drawing.Point(198, 228);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(131, 24);
            this.lblCP.TabIndex = 8;
            this.lblCP.Text = "Código Postal:";
            // 
            // txtCP
            // 
            this.txtCP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCP.BackColor = System.Drawing.Color.Khaki;
            this.txtCP.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCP.Location = new System.Drawing.Point(402, 225);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(212, 27);
            this.txtCP.TabIndex = 9;
            // 
            // lblTel
            // 
            this.lblTel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTel.AutoSize = true;
            this.lblTel.BackColor = System.Drawing.Color.Transparent;
            this.lblTel.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.lblTel.Location = new System.Drawing.Point(198, 261);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(100, 24);
            this.lblTel.TabIndex = 10;
            this.lblTel.Text = "Telemóvel:";
            // 
            // txtTelemovel
            // 
            this.txtTelemovel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelemovel.BackColor = System.Drawing.Color.Khaki;
            this.txtTelemovel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelemovel.Location = new System.Drawing.Point(402, 258);
            this.txtTelemovel.Name = "txtTelemovel";
            this.txtTelemovel.Size = new System.Drawing.Size(212, 27);
            this.txtTelemovel.TabIndex = 11;
            // 
            // cbGen
            // 
            this.cbGen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbGen.BackColor = System.Drawing.Color.Khaki;
            this.cbGen.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGen.FormattingEnabled = true;
            this.cbGen.Location = new System.Drawing.Point(402, 93);
            this.cbGen.Name = "cbGen";
            this.cbGen.Size = new System.Drawing.Size(212, 27);
            this.cbGen.TabIndex = 13;
            // 
            // generoBindingSource
            // 
            this.generoBindingSource.DataMember = "Genero";
            this.generoBindingSource.DataSource = this.servicos_SociaisDataSet;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(198, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Género:";
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btCancelar.ForeColor = System.Drawing.Color.White;
            this.btCancelar.Location = new System.Drawing.Point(402, 614);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(125, 50);
            this.btCancelar.TabIndex = 14;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click_1);
            // 
            // btGravar
            // 
            this.btGravar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btGravar.ForeColor = System.Drawing.Color.White;
            this.btGravar.Location = new System.Drawing.Point(533, 614);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(125, 50);
            this.btGravar.TabIndex = 15;
            this.btGravar.Text = "Gravar";
            this.btGravar.UseVisualStyleBackColor = false;
            this.btGravar.Click += new System.EventHandler(this.btGravar_Click);
            // 
            // lblDesc
            // 
            this.lblDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDesc.AutoSize = true;
            this.lblDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblDesc.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(641, 108);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(166, 23);
            this.lblDesc.TabIndex = 19;
            this.lblDesc.Text = "Tem descendentes?";
            this.lblDesc.Visible = false;
            // 
            // estadoCivilTableAdapter
            // 
            this.estadoCivilTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssistenciasTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ComparticipacoesTableAdapter = null;
            this.tableAdapterManager.ConjugeTableAdapter = null;
            this.tableAdapterManager.DescendentesTableAdapter = null;
            this.tableAdapterManager.EstadoCivilTableAdapter = this.estadoCivilTableAdapter;
            this.tableAdapterManager.GeneroTableAdapter = null;
            this.tableAdapterManager.ParentescoTableAdapter = null;
            this.tableAdapterManager.ServiçoTableAdapter = null;
            this.tableAdapterManager.SistemaSaudeTableAdapter = null;
            this.tableAdapterManager.SóciosTableAdapter = null;
            this.tableAdapterManager.TipoAssistenciaTableAdapter = null;
            this.tableAdapterManager.TipoPagamentoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Serviços_Sociais___Gestão.Servicos_SociaisDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // rbSim
            // 
            this.rbSim.AutoSize = true;
            this.rbSim.BackColor = System.Drawing.Color.Transparent;
            this.rbSim.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.rbSim.Location = new System.Drawing.Point(641, 134);
            this.rbSim.Name = "rbSim";
            this.rbSim.Size = new System.Drawing.Size(57, 27);
            this.rbSim.TabIndex = 23;
            this.rbSim.TabStop = true;
            this.rbSim.Text = "Sim";
            this.rbSim.UseVisualStyleBackColor = false;
            this.rbSim.Visible = false;
            this.rbSim.CheckedChanged += new System.EventHandler(this.rbSim_CheckedChanged);
            // 
            // rbNao
            // 
            this.rbNao.AutoSize = true;
            this.rbNao.BackColor = System.Drawing.Color.Transparent;
            this.rbNao.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.rbNao.Location = new System.Drawing.Point(704, 134);
            this.rbNao.Name = "rbNao";
            this.rbNao.Size = new System.Drawing.Size(60, 27);
            this.rbNao.TabIndex = 24;
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
            this.numericUpDown.Location = new System.Drawing.Point(878, 131);
            this.numericUpDown.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(40, 27);
            this.numericUpDown.TabIndex = 22;
            this.numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown.Visible = false;
            this.numericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // lblQuantos
            // 
            this.lblQuantos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuantos.AutoSize = true;
            this.lblQuantos.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantos.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantos.Location = new System.Drawing.Point(786, 135);
            this.lblQuantos.Name = "lblQuantos";
            this.lblQuantos.Size = new System.Drawing.Size(86, 23);
            this.lblQuantos.TabIndex = 25;
            this.lblQuantos.Text = "Quantos?";
            this.lblQuantos.Visible = false;
            // 
            // txtNSS
            // 
            this.txtNSS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNSS.BackColor = System.Drawing.Color.Khaki;
            this.txtNSS.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNSS.Location = new System.Drawing.Point(402, 324);
            this.txtNSS.Name = "txtNSS";
            this.txtNSS.Size = new System.Drawing.Size(212, 27);
            this.txtNSS.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(198, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 24);
            this.label8.TabIndex = 40;
            this.label8.Text = "Nº Sistema Saúde:";
            // 
            // cbServ
            // 
            this.cbServ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbServ.BackColor = System.Drawing.Color.Khaki;
            this.cbServ.DataSource = this.serviçoBindingSource;
            this.cbServ.DisplayMember = "Serviço";
            this.cbServ.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbServ.FormattingEnabled = true;
            this.cbServ.Location = new System.Drawing.Point(402, 554);
            this.cbServ.Name = "cbServ";
            this.cbServ.Size = new System.Drawing.Size(212, 27);
            this.cbServ.TabIndex = 39;
            this.cbServ.ValueMember = "Serviço";
            // 
            // serviçoBindingSource
            // 
            this.serviçoBindingSource.DataMember = "Serviço";
            this.serviçoBindingSource.DataSource = this.servicos_SociaisDataSet;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(198, 557);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 24);
            this.label4.TabIndex = 38;
            this.label4.Text = "Serviço:";
            // 
            // txtNF
            // 
            this.txtNF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNF.BackColor = System.Drawing.Color.Khaki;
            this.txtNF.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNF.Location = new System.Drawing.Point(402, 489);
            this.txtNF.Name = "txtNF";
            this.txtNF.Size = new System.Drawing.Size(212, 27);
            this.txtNF.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(198, 492);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 24);
            this.label6.TabIndex = 36;
            this.label6.Text = "Nº Funcionário:";
            // 
            // txtNIF
            // 
            this.txtNIF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNIF.BackColor = System.Drawing.Color.Khaki;
            this.txtNIF.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIF.Location = new System.Drawing.Point(402, 456);
            this.txtNIF.Name = "txtNIF";
            this.txtNIF.Size = new System.Drawing.Size(212, 27);
            this.txtNIF.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(198, 459);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 24);
            this.label5.TabIndex = 34;
            this.label5.Text = "NIF:";
            // 
            // txtBIC
            // 
            this.txtBIC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBIC.BackColor = System.Drawing.Color.Khaki;
            this.txtBIC.Enabled = false;
            this.txtBIC.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBIC.Location = new System.Drawing.Point(402, 423);
            this.txtBIC.Name = "txtBIC";
            this.txtBIC.Size = new System.Drawing.Size(212, 27);
            this.txtBIC.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(198, 426);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 24);
            this.label9.TabIndex = 32;
            this.label9.Text = "SWIFT/BIC:";
            // 
            // txtIBAN
            // 
            this.txtIBAN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIBAN.BackColor = System.Drawing.Color.Khaki;
            this.txtIBAN.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIBAN.Location = new System.Drawing.Point(402, 390);
            this.txtIBAN.Name = "txtIBAN";
            this.txtIBAN.Size = new System.Drawing.Size(212, 27);
            this.txtIBAN.TabIndex = 31;
            this.txtIBAN.TextChanged += new System.EventHandler(this.txtIBAN_TextChanged);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(198, 393);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 24);
            this.label10.TabIndex = 30;
            this.label10.Text = "IBAN:";
            // 
            // txtNISS
            // 
            this.txtNISS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNISS.BackColor = System.Drawing.Color.Khaki;
            this.txtNISS.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNISS.Location = new System.Drawing.Point(402, 357);
            this.txtNISS.Name = "txtNISS";
            this.txtNISS.Size = new System.Drawing.Size(212, 27);
            this.txtNISS.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(198, 360);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 24);
            this.label11.TabIndex = 28;
            this.label11.Text = "NISS:";
            // 
            // cbSS
            // 
            this.cbSS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSS.BackColor = System.Drawing.Color.Khaki;
            this.cbSS.DataSource = this.sistemaSaudeBindingSource;
            this.cbSS.DisplayMember = "SistemaSaude";
            this.cbSS.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSS.FormattingEnabled = true;
            this.cbSS.Location = new System.Drawing.Point(402, 291);
            this.cbSS.Name = "cbSS";
            this.cbSS.Size = new System.Drawing.Size(212, 27);
            this.cbSS.TabIndex = 27;
            this.cbSS.ValueMember = "SistemaSaude";
            // 
            // sistemaSaudeBindingSource
            // 
            this.sistemaSaudeBindingSource.DataMember = "SistemaSaude";
            this.sistemaSaudeBindingSource.DataSource = this.servicos_SociaisDataSet;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(198, 294);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(163, 24);
            this.label12.TabIndex = 26;
            this.label12.Text = "Sistema de Saúde:";
            // 
            // btConfirmar
            // 
            this.btConfirmar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btConfirmar.ForeColor = System.Drawing.Color.White;
            this.btConfirmar.Location = new System.Drawing.Point(924, 131);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Size = new System.Drawing.Size(76, 27);
            this.btConfirmar.TabIndex = 42;
            this.btConfirmar.Text = "Confirmar";
            this.btConfirmar.UseVisualStyleBackColor = false;
            this.btConfirmar.Visible = false;
            this.btConfirmar.Click += new System.EventHandler(this.btConfirmar_Click);
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
            // sistemaSaudeTableAdapter
            // 
            this.sistemaSaudeTableAdapter.ClearBeforeFill = true;
            // 
            // serviçoTableAdapter
            // 
            this.serviçoTableAdapter.ClearBeforeFill = true;
            // 
            // generoTableAdapter
            // 
            this.generoTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(198, 524);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(168, 24);
            this.label13.TabIndex = 43;
            this.label13.Text = "Data de Admissão:";
            // 
            // dateTimePickerDA
            // 
            this.dateTimePickerDA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerDA.CalendarMonthBackground = System.Drawing.Color.Khaki;
            this.dateTimePickerDA.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDA.Location = new System.Drawing.Point(402, 521);
            this.dateTimePickerDA.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerDA.Name = "dateTimePickerDA";
            this.dateTimePickerDA.Size = new System.Drawing.Size(212, 27);
            this.dateTimePickerDA.TabIndex = 44;
            // 
            // Registo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1058, 676);
            this.ControlBox = false;
            this.Controls.Add(this.dateTimePickerDA);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btConfirmar);
            this.Controls.Add(this.txtNSS);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbServ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNF);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNIF);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBIC);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtIBAN);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNISS);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbSS);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblQuantos);
            this.Controls.Add(this.rbNao);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.cbGen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTelemovel);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.txtCP);
            this.Controls.Add(this.lblCP);
            this.Controls.Add(this.txtMorada);
            this.Controls.Add(this.lblMorada);
            this.Controls.Add(this.cbEC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerDN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbSim);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registo";
            this.Load += new System.EventHandler(this.Registo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.estadoCivilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicos_SociaisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviçoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaSaudeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sóciosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerDN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbEC;
        private System.Windows.Forms.Label lblMorada;
        private System.Windows.Forms.TextBox txtMorada;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtTelemovel;
        private System.Windows.Forms.ComboBox cbGen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btGravar;
        private System.Windows.Forms.Label lblDesc;
        private Servicos_SociaisDataSet servicos_SociaisDataSet;
        private System.Windows.Forms.BindingSource estadoCivilBindingSource;
        private Servicos_SociaisDataSetTableAdapters.EstadoCivilTableAdapter estadoCivilTableAdapter;
        private Servicos_SociaisDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.RadioButton rbSim;
        private System.Windows.Forms.RadioButton rbNao;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Label lblQuantos;
        private System.Windows.Forms.TextBox txtNSS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbServ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNIF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBIC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIBAN;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNISS;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbSS;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btConfirmar;
        private System.Windows.Forms.BindingSource sóciosBindingSource;
        private Servicos_SociaisDataSetTableAdapters.SóciosTableAdapter sóciosTableAdapter;
        private System.Windows.Forms.BindingSource sistemaSaudeBindingSource;
        private Servicos_SociaisDataSetTableAdapters.SistemaSaudeTableAdapter sistemaSaudeTableAdapter;
        private System.Windows.Forms.BindingSource serviçoBindingSource;
        private Servicos_SociaisDataSetTableAdapters.ServiçoTableAdapter serviçoTableAdapter;
        private System.Windows.Forms.BindingSource generoBindingSource;
        private Servicos_SociaisDataSetTableAdapters.GeneroTableAdapter generoTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePickerDA;
    }
}