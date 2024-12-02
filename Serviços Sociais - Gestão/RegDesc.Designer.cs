namespace Serviços_Sociais___Gestão
{
    partial class RegDesc
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
            this.gbDesc = new System.Windows.Forms.GroupBox();
            this.btGuardar = new System.Windows.Forms.Button();
            this.cbParent = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtADSEDesc = new System.Windows.Forms.TextBox();
            this.dtpDesc = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNDesc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.servicos_SociaisDataSet = new Serviços_Sociais___Gestão.Servicos_SociaisDataSet();
            this.descendentesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descendentesTableAdapter = new Serviços_Sociais___Gestão.Servicos_SociaisDataSetTableAdapters.DescendentesTableAdapter();
            this.tableAdapterManager = new Serviços_Sociais___Gestão.Servicos_SociaisDataSetTableAdapters.TableAdapterManager();
            this.parentescoTableAdapter = new Serviços_Sociais___Gestão.Servicos_SociaisDataSetTableAdapters.ParentescoTableAdapter();
            this.sóciosTableAdapter = new Serviços_Sociais___Gestão.Servicos_SociaisDataSetTableAdapters.SóciosTableAdapter();
            this.parentescoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sóciosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btCancelar = new System.Windows.Forms.Button();
            this.gbDesc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicos_SociaisDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descendentesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentescoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sóciosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDesc
            // 
            this.gbDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDesc.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.gbDesc.Controls.Add(this.btCancelar);
            this.gbDesc.Controls.Add(this.btGuardar);
            this.gbDesc.Controls.Add(this.cbParent);
            this.gbDesc.Controls.Add(this.label8);
            this.gbDesc.Controls.Add(this.txtADSEDesc);
            this.gbDesc.Controls.Add(this.dtpDesc);
            this.gbDesc.Controls.Add(this.label4);
            this.gbDesc.Controls.Add(this.label5);
            this.gbDesc.Controls.Add(this.txtNDesc);
            this.gbDesc.Controls.Add(this.label6);
            this.gbDesc.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDesc.Location = new System.Drawing.Point(161, 216);
            this.gbDesc.Name = "gbDesc";
            this.gbDesc.Size = new System.Drawing.Size(698, 181);
            this.gbDesc.TabIndex = 22;
            this.gbDesc.TabStop = false;
            this.gbDesc.Text = "Descendentes";
            // 
            // btGuardar
            // 
            this.btGuardar.BackColor = System.Drawing.Color.DarkKhaki;
            this.btGuardar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardar.Location = new System.Drawing.Point(608, 142);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(84, 33);
            this.btGuardar.TabIndex = 16;
            this.btGuardar.Text = "Seguinte";
            this.btGuardar.UseVisualStyleBackColor = false;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // cbParent
            // 
            this.cbParent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbParent.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbParent.FormattingEnabled = true;
            this.cbParent.Location = new System.Drawing.Point(226, 95);
            this.cbParent.Name = "cbParent";
            this.cbParent.Size = new System.Drawing.Size(238, 27);
            this.cbParent.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 23);
            this.label8.TabIndex = 11;
            this.label8.Text = "Parentesco:";
            // 
            // txtADSEDesc
            // 
            this.txtADSEDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtADSEDesc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtADSEDesc.Location = new System.Drawing.Point(226, 134);
            this.txtADSEDesc.Name = "txtADSEDesc";
            this.txtADSEDesc.Size = new System.Drawing.Size(238, 27);
            this.txtADSEDesc.TabIndex = 10;
            // 
            // dtpDesc
            // 
            this.dtpDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDesc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDesc.Location = new System.Drawing.Point(226, 63);
            this.dtpDesc.Name = "dtpDesc";
            this.dtpDesc.Size = new System.Drawing.Size(238, 27);
            this.dtpDesc.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nº ADSE/Serviços Sociais:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Data de Nascimento:";
            // 
            // txtNDesc
            // 
            this.txtNDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNDesc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNDesc.Location = new System.Drawing.Point(226, 27);
            this.txtNDesc.Name = "txtNDesc";
            this.txtNDesc.Size = new System.Drawing.Size(466, 27);
            this.txtNDesc.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nome Completo:";
            // 
            // servicos_SociaisDataSet
            // 
            this.servicos_SociaisDataSet.DataSetName = "Servicos_SociaisDataSet";
            this.servicos_SociaisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // descendentesBindingSource
            // 
            this.descendentesBindingSource.DataMember = "Descendentes";
            this.descendentesBindingSource.DataSource = this.servicos_SociaisDataSet;
            // 
            // descendentesTableAdapter
            // 
            this.descendentesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AssistenciasTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ComparticipacoesTableAdapter = null;
            this.tableAdapterManager.ConjugeTableAdapter = null;
            this.tableAdapterManager.DescendentesTableAdapter = this.descendentesTableAdapter;
            this.tableAdapterManager.EstadoCivilTableAdapter = null;
            this.tableAdapterManager.GeneroTableAdapter = null;
            this.tableAdapterManager.ParentescoTableAdapter = this.parentescoTableAdapter;
            this.tableAdapterManager.ServiçoTableAdapter = null;
            this.tableAdapterManager.SistemaSaudeTableAdapter = null;
            this.tableAdapterManager.SóciosTableAdapter = this.sóciosTableAdapter;
            this.tableAdapterManager.UpdateOrder = Serviços_Sociais___Gestão.Servicos_SociaisDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // parentescoTableAdapter
            // 
            this.parentescoTableAdapter.ClearBeforeFill = true;
            // 
            // sóciosTableAdapter
            // 
            this.sóciosTableAdapter.ClearBeforeFill = true;
            // 
            // parentescoBindingSource
            // 
            this.parentescoBindingSource.DataMember = "Parentesco";
            this.parentescoBindingSource.DataSource = this.servicos_SociaisDataSet;
            // 
            // sóciosBindingSource
            // 
            this.sóciosBindingSource.DataMember = "Sócios";
            this.sóciosBindingSource.DataSource = this.servicos_SociaisDataSet;
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.DarkKhaki;
            this.btCancelar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(518, 142);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(84, 33);
            this.btCancelar.TabIndex = 17;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // RegDesc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(1058, 676);
            this.ControlBox = false;
            this.Controls.Add(this.gbDesc);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RegDesc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.RegDesc_Load);
            this.gbDesc.ResumeLayout(false);
            this.gbDesc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicos_SociaisDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descendentesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentescoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sóciosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDesc;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.ComboBox cbParent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtADSEDesc;
        private System.Windows.Forms.DateTimePicker dtpDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNDesc;
        private System.Windows.Forms.Label label6;
        private Servicos_SociaisDataSet servicos_SociaisDataSet;
        private System.Windows.Forms.BindingSource descendentesBindingSource;
        private Servicos_SociaisDataSetTableAdapters.DescendentesTableAdapter descendentesTableAdapter;
        private Servicos_SociaisDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Servicos_SociaisDataSetTableAdapters.ParentescoTableAdapter parentescoTableAdapter;
        private System.Windows.Forms.BindingSource parentescoBindingSource;
        private Servicos_SociaisDataSetTableAdapters.SóciosTableAdapter sóciosTableAdapter;
        private System.Windows.Forms.BindingSource sóciosBindingSource;
        private System.Windows.Forms.Button btCancelar;
    }
}