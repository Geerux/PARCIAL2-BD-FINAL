namespace sql_PARCIAL2
{
    partial class Frm_clientes
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
            this.btn_ActualizarC = new System.Windows.Forms.Button();
            this.btn_RegistrarC = new System.Windows.Forms.Button();
            this.txt_NomCliente = new System.Windows.Forms.TextBox();
            this.lbl_NomCliente = new System.Windows.Forms.Label();
            this.txt_IdCliente = new System.Windows.Forms.TextBox();
            this.lbl_IdCliente = new System.Windows.Forms.Label();
            this.txt_CorreoC = new System.Windows.Forms.TextBox();
            this.lbl_CorreoC = new System.Windows.Forms.Label();
            this.txt_RfcC = new System.Windows.Forms.TextBox();
            this.lbl_RfcC = new System.Windows.Forms.Label();
            this.txt_TelefonoC = new System.Windows.Forms.TextBox();
            this.lbl_TelefonoC = new System.Windows.Forms.Label();
            this.txt_LadaC = new System.Windows.Forms.TextBox();
            this.lbl_LadaC = new System.Windows.Forms.Label();
            this.txt_RegimenC = new System.Windows.Forms.TextBox();
            this.lbl_RegimenC = new System.Windows.Forms.Label();
            this.txt_TelContactoC = new System.Windows.Forms.TextBox();
            this.lbl_TelContactoC = new System.Windows.Forms.Label();
            this.txt_ContactoC = new System.Windows.Forms.TextBox();
            this.lbl_ContactoC = new System.Windows.Forms.Label();
            this.txt_CtaBcaC = new System.Windows.Forms.TextBox();
            this.lbl_CtaBcaC = new System.Windows.Forms.Label();
            this.txt_NumExtC = new System.Windows.Forms.TextBox();
            this.lbl_NumExtC = new System.Windows.Forms.Label();
            this.txt_CalleC = new System.Windows.Forms.TextBox();
            this.lbl_CalleC = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cLIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLNOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLRFCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLCORREODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLLADADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLTELEFONODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLCALLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLNUMEROEXTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLCTABANCARIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLCONTACTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLTELEFCONTACTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLREGIMENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIENTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vENTASDataSet2 = new sql_PARCIAL2.VENTASDataSet2();
            this.vENTASDataSet = new sql_PARCIAL2.VENTASDataSet();
            this.vENTASDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTESTableAdapter = new sql_PARCIAL2.VENTASDataSet2TableAdapters.CLIENTESTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ActualizarC
            // 
            this.btn_ActualizarC.Location = new System.Drawing.Point(559, 76);
            this.btn_ActualizarC.Name = "btn_ActualizarC";
            this.btn_ActualizarC.Size = new System.Drawing.Size(75, 23);
            this.btn_ActualizarC.TabIndex = 11;
            this.btn_ActualizarC.Text = "ELIMINAR";
            this.btn_ActualizarC.UseVisualStyleBackColor = true;
            this.btn_ActualizarC.Click += new System.EventHandler(this.btn_ActualizarC_Click);
            // 
            // btn_RegistrarC
            // 
            this.btn_RegistrarC.Location = new System.Drawing.Point(531, 28);
            this.btn_RegistrarC.Name = "btn_RegistrarC";
            this.btn_RegistrarC.Size = new System.Drawing.Size(75, 23);
            this.btn_RegistrarC.TabIndex = 10;
            this.btn_RegistrarC.Text = "Registrar";
            this.btn_RegistrarC.UseVisualStyleBackColor = true;
            this.btn_RegistrarC.Click += new System.EventHandler(this.btn_RegistrarC_Click);
            // 
            // txt_NomCliente
            // 
            this.txt_NomCliente.Location = new System.Drawing.Point(117, 31);
            this.txt_NomCliente.Name = "txt_NomCliente";
            this.txt_NomCliente.Size = new System.Drawing.Size(69, 20);
            this.txt_NomCliente.TabIndex = 9;
            // 
            // lbl_NomCliente
            // 
            this.lbl_NomCliente.AutoSize = true;
            this.lbl_NomCliente.Location = new System.Drawing.Point(125, 15);
            this.lbl_NomCliente.Name = "lbl_NomCliente";
            this.lbl_NomCliente.Size = new System.Drawing.Size(44, 13);
            this.lbl_NomCliente.TabIndex = 8;
            this.lbl_NomCliente.Text = "Nombre";
            // 
            // txt_IdCliente
            // 
            this.txt_IdCliente.Location = new System.Drawing.Point(22, 31);
            this.txt_IdCliente.Name = "txt_IdCliente";
            this.txt_IdCliente.Size = new System.Drawing.Size(69, 20);
            this.txt_IdCliente.TabIndex = 7;
            // 
            // lbl_IdCliente
            // 
            this.lbl_IdCliente.AutoSize = true;
            this.lbl_IdCliente.Location = new System.Drawing.Point(28, 15);
            this.lbl_IdCliente.Name = "lbl_IdCliente";
            this.lbl_IdCliente.Size = new System.Drawing.Size(51, 13);
            this.lbl_IdCliente.TabIndex = 6;
            this.lbl_IdCliente.Text = "Id Cliente";
            // 
            // txt_CorreoC
            // 
            this.txt_CorreoC.Location = new System.Drawing.Point(289, 31);
            this.txt_CorreoC.Name = "txt_CorreoC";
            this.txt_CorreoC.Size = new System.Drawing.Size(69, 20);
            this.txt_CorreoC.TabIndex = 15;
            // 
            // lbl_CorreoC
            // 
            this.lbl_CorreoC.AutoSize = true;
            this.lbl_CorreoC.Location = new System.Drawing.Point(299, 15);
            this.lbl_CorreoC.Name = "lbl_CorreoC";
            this.lbl_CorreoC.Size = new System.Drawing.Size(38, 13);
            this.lbl_CorreoC.TabIndex = 14;
            this.lbl_CorreoC.Text = "Correo";
            // 
            // txt_RfcC
            // 
            this.txt_RfcC.Location = new System.Drawing.Point(205, 30);
            this.txt_RfcC.Name = "txt_RfcC";
            this.txt_RfcC.Size = new System.Drawing.Size(69, 20);
            this.txt_RfcC.TabIndex = 13;
            // 
            // lbl_RfcC
            // 
            this.lbl_RfcC.AutoSize = true;
            this.lbl_RfcC.Location = new System.Drawing.Point(212, 15);
            this.lbl_RfcC.Name = "lbl_RfcC";
            this.lbl_RfcC.Size = new System.Drawing.Size(28, 13);
            this.lbl_RfcC.TabIndex = 12;
            this.lbl_RfcC.Text = "RFC";
            // 
            // txt_TelefonoC
            // 
            this.txt_TelefonoC.Location = new System.Drawing.Point(456, 30);
            this.txt_TelefonoC.Name = "txt_TelefonoC";
            this.txt_TelefonoC.Size = new System.Drawing.Size(69, 20);
            this.txt_TelefonoC.TabIndex = 19;
            // 
            // lbl_TelefonoC
            // 
            this.lbl_TelefonoC.AutoSize = true;
            this.lbl_TelefonoC.Location = new System.Drawing.Point(466, 14);
            this.lbl_TelefonoC.Name = "lbl_TelefonoC";
            this.lbl_TelefonoC.Size = new System.Drawing.Size(49, 13);
            this.lbl_TelefonoC.TabIndex = 18;
            this.lbl_TelefonoC.Text = "Telefono";
            // 
            // txt_LadaC
            // 
            this.txt_LadaC.Location = new System.Drawing.Point(371, 30);
            this.txt_LadaC.Name = "txt_LadaC";
            this.txt_LadaC.Size = new System.Drawing.Size(69, 20);
            this.txt_LadaC.TabIndex = 17;
            // 
            // lbl_LadaC
            // 
            this.lbl_LadaC.AutoSize = true;
            this.lbl_LadaC.Location = new System.Drawing.Point(377, 14);
            this.lbl_LadaC.Name = "lbl_LadaC";
            this.lbl_LadaC.Size = new System.Drawing.Size(31, 13);
            this.lbl_LadaC.TabIndex = 16;
            this.lbl_LadaC.Text = "Lada";
            // 
            // txt_RegimenC
            // 
            this.txt_RegimenC.Location = new System.Drawing.Point(484, 79);
            this.txt_RegimenC.Name = "txt_RegimenC";
            this.txt_RegimenC.Size = new System.Drawing.Size(69, 20);
            this.txt_RegimenC.TabIndex = 31;
            // 
            // lbl_RegimenC
            // 
            this.lbl_RegimenC.AutoSize = true;
            this.lbl_RegimenC.Location = new System.Drawing.Point(494, 63);
            this.lbl_RegimenC.Name = "lbl_RegimenC";
            this.lbl_RegimenC.Size = new System.Drawing.Size(49, 13);
            this.lbl_RegimenC.TabIndex = 30;
            this.lbl_RegimenC.Text = "Regimen";
            // 
            // txt_TelContactoC
            // 
            this.txt_TelContactoC.Location = new System.Drawing.Point(384, 79);
            this.txt_TelContactoC.Name = "txt_TelContactoC";
            this.txt_TelContactoC.Size = new System.Drawing.Size(83, 20);
            this.txt_TelContactoC.TabIndex = 29;
            // 
            // lbl_TelContactoC
            // 
            this.lbl_TelContactoC.AutoSize = true;
            this.lbl_TelContactoC.Location = new System.Drawing.Point(390, 63);
            this.lbl_TelContactoC.Name = "lbl_TelContactoC";
            this.lbl_TelContactoC.Size = new System.Drawing.Size(77, 13);
            this.lbl_TelContactoC.TabIndex = 28;
            this.lbl_TelContactoC.Text = "Contacto Telef";
            // 
            // txt_ContactoC
            // 
            this.txt_ContactoC.Location = new System.Drawing.Point(302, 80);
            this.txt_ContactoC.Name = "txt_ContactoC";
            this.txt_ContactoC.Size = new System.Drawing.Size(69, 20);
            this.txt_ContactoC.TabIndex = 27;
            // 
            // lbl_ContactoC
            // 
            this.lbl_ContactoC.AutoSize = true;
            this.lbl_ContactoC.Location = new System.Drawing.Point(312, 64);
            this.lbl_ContactoC.Name = "lbl_ContactoC";
            this.lbl_ContactoC.Size = new System.Drawing.Size(50, 13);
            this.lbl_ContactoC.TabIndex = 26;
            this.lbl_ContactoC.Text = "Contacto";
            // 
            // txt_CtaBcaC
            // 
            this.txt_CtaBcaC.Location = new System.Drawing.Point(205, 79);
            this.txt_CtaBcaC.Name = "txt_CtaBcaC";
            this.txt_CtaBcaC.Size = new System.Drawing.Size(83, 20);
            this.txt_CtaBcaC.TabIndex = 25;
            // 
            // lbl_CtaBcaC
            // 
            this.lbl_CtaBcaC.AutoSize = true;
            this.lbl_CtaBcaC.Location = new System.Drawing.Point(202, 63);
            this.lbl_CtaBcaC.Name = "lbl_CtaBcaC";
            this.lbl_CtaBcaC.Size = new System.Drawing.Size(86, 13);
            this.lbl_CtaBcaC.TabIndex = 24;
            this.lbl_CtaBcaC.Text = "Cuenta Bancaria";
            // 
            // txt_NumExtC
            // 
            this.txt_NumExtC.Location = new System.Drawing.Point(117, 80);
            this.txt_NumExtC.Name = "txt_NumExtC";
            this.txt_NumExtC.Size = new System.Drawing.Size(79, 20);
            this.txt_NumExtC.TabIndex = 23;
            // 
            // lbl_NumExtC
            // 
            this.lbl_NumExtC.AutoSize = true;
            this.lbl_NumExtC.Location = new System.Drawing.Point(114, 63);
            this.lbl_NumExtC.Name = "lbl_NumExtC";
            this.lbl_NumExtC.Size = new System.Drawing.Size(82, 13);
            this.lbl_NumExtC.TabIndex = 22;
            this.lbl_NumExtC.Text = "Numero Exterior";
            // 
            // txt_CalleC
            // 
            this.txt_CalleC.Location = new System.Drawing.Point(22, 80);
            this.txt_CalleC.Name = "txt_CalleC";
            this.txt_CalleC.Size = new System.Drawing.Size(69, 20);
            this.txt_CalleC.TabIndex = 21;
            // 
            // lbl_CalleC
            // 
            this.lbl_CalleC.AutoSize = true;
            this.lbl_CalleC.Location = new System.Drawing.Point(28, 64);
            this.lbl_CalleC.Name = "lbl_CalleC";
            this.lbl_CalleC.Size = new System.Drawing.Size(30, 13);
            this.lbl_CalleC.TabIndex = 20;
            this.lbl_CalleC.Text = "Calle";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cLIDDataGridViewTextBoxColumn,
            this.cLNOMBREDataGridViewTextBoxColumn,
            this.cLRFCDataGridViewTextBoxColumn,
            this.cLCORREODataGridViewTextBoxColumn,
            this.cLLADADataGridViewTextBoxColumn,
            this.cLTELEFONODataGridViewTextBoxColumn,
            this.cLCALLEDataGridViewTextBoxColumn,
            this.cLNUMEROEXTDataGridViewTextBoxColumn,
            this.cLCTABANCARIADataGridViewTextBoxColumn,
            this.cLCONTACTODataGridViewTextBoxColumn,
            this.cLTELEFCONTACTODataGridViewTextBoxColumn,
            this.cLREGIMENDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cLIENTESBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(34, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1262, 150);
            this.dataGridView1.TabIndex = 32;
            // 
            // cLIDDataGridViewTextBoxColumn
            // 
            this.cLIDDataGridViewTextBoxColumn.DataPropertyName = "CL_ID";
            this.cLIDDataGridViewTextBoxColumn.HeaderText = "CL_ID";
            this.cLIDDataGridViewTextBoxColumn.Name = "cLIDDataGridViewTextBoxColumn";
            // 
            // cLNOMBREDataGridViewTextBoxColumn
            // 
            this.cLNOMBREDataGridViewTextBoxColumn.DataPropertyName = "CL_NOMBRE";
            this.cLNOMBREDataGridViewTextBoxColumn.HeaderText = "CL_NOMBRE";
            this.cLNOMBREDataGridViewTextBoxColumn.Name = "cLNOMBREDataGridViewTextBoxColumn";
            // 
            // cLRFCDataGridViewTextBoxColumn
            // 
            this.cLRFCDataGridViewTextBoxColumn.DataPropertyName = "CL_RFC";
            this.cLRFCDataGridViewTextBoxColumn.HeaderText = "CL_RFC";
            this.cLRFCDataGridViewTextBoxColumn.Name = "cLRFCDataGridViewTextBoxColumn";
            // 
            // cLCORREODataGridViewTextBoxColumn
            // 
            this.cLCORREODataGridViewTextBoxColumn.DataPropertyName = "CL_CORREO";
            this.cLCORREODataGridViewTextBoxColumn.HeaderText = "CL_CORREO";
            this.cLCORREODataGridViewTextBoxColumn.Name = "cLCORREODataGridViewTextBoxColumn";
            // 
            // cLLADADataGridViewTextBoxColumn
            // 
            this.cLLADADataGridViewTextBoxColumn.DataPropertyName = "CL_LADA";
            this.cLLADADataGridViewTextBoxColumn.HeaderText = "CL_LADA";
            this.cLLADADataGridViewTextBoxColumn.Name = "cLLADADataGridViewTextBoxColumn";
            // 
            // cLTELEFONODataGridViewTextBoxColumn
            // 
            this.cLTELEFONODataGridViewTextBoxColumn.DataPropertyName = "CL_TELEFONO";
            this.cLTELEFONODataGridViewTextBoxColumn.HeaderText = "CL_TELEFONO";
            this.cLTELEFONODataGridViewTextBoxColumn.Name = "cLTELEFONODataGridViewTextBoxColumn";
            // 
            // cLCALLEDataGridViewTextBoxColumn
            // 
            this.cLCALLEDataGridViewTextBoxColumn.DataPropertyName = "CL_CALLE";
            this.cLCALLEDataGridViewTextBoxColumn.HeaderText = "CL_CALLE";
            this.cLCALLEDataGridViewTextBoxColumn.Name = "cLCALLEDataGridViewTextBoxColumn";
            // 
            // cLNUMEROEXTDataGridViewTextBoxColumn
            // 
            this.cLNUMEROEXTDataGridViewTextBoxColumn.DataPropertyName = "CL_NUMERO_EXT";
            this.cLNUMEROEXTDataGridViewTextBoxColumn.HeaderText = "CL_NUMERO_EXT";
            this.cLNUMEROEXTDataGridViewTextBoxColumn.Name = "cLNUMEROEXTDataGridViewTextBoxColumn";
            // 
            // cLCTABANCARIADataGridViewTextBoxColumn
            // 
            this.cLCTABANCARIADataGridViewTextBoxColumn.DataPropertyName = "CL_CTABANCARIA";
            this.cLCTABANCARIADataGridViewTextBoxColumn.HeaderText = "CL_CTABANCARIA";
            this.cLCTABANCARIADataGridViewTextBoxColumn.Name = "cLCTABANCARIADataGridViewTextBoxColumn";
            // 
            // cLCONTACTODataGridViewTextBoxColumn
            // 
            this.cLCONTACTODataGridViewTextBoxColumn.DataPropertyName = "CL_CONTACTO";
            this.cLCONTACTODataGridViewTextBoxColumn.HeaderText = "CL_CONTACTO";
            this.cLCONTACTODataGridViewTextBoxColumn.Name = "cLCONTACTODataGridViewTextBoxColumn";
            // 
            // cLTELEFCONTACTODataGridViewTextBoxColumn
            // 
            this.cLTELEFCONTACTODataGridViewTextBoxColumn.DataPropertyName = "CL_TELEF_CONTACTO";
            this.cLTELEFCONTACTODataGridViewTextBoxColumn.HeaderText = "CL_TELEF_CONTACTO";
            this.cLTELEFCONTACTODataGridViewTextBoxColumn.Name = "cLTELEFCONTACTODataGridViewTextBoxColumn";
            // 
            // cLREGIMENDataGridViewTextBoxColumn
            // 
            this.cLREGIMENDataGridViewTextBoxColumn.DataPropertyName = "CL_REGIMEN";
            this.cLREGIMENDataGridViewTextBoxColumn.HeaderText = "CL_REGIMEN";
            this.cLREGIMENDataGridViewTextBoxColumn.Name = "cLREGIMENDataGridViewTextBoxColumn";
            // 
            // cLIENTESBindingSource
            // 
            this.cLIENTESBindingSource.DataMember = "CLIENTES";
            this.cLIENTESBindingSource.DataSource = this.vENTASDataSet2;
            // 
            // vENTASDataSet2
            // 
            this.vENTASDataSet2.DataSetName = "VENTASDataSet2";
            this.vENTASDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vENTASDataSet
            // 
            this.vENTASDataSet.DataSetName = "VENTASDataSet";
            this.vENTASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vENTASDataSetBindingSource
            // 
            this.vENTASDataSetBindingSource.DataSource = this.vENTASDataSet;
            this.vENTASDataSetBindingSource.Position = 0;
            // 
            // cLIENTESTableAdapter
            // 
            this.cLIENTESTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 398);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_RegimenC);
            this.Controls.Add(this.lbl_RegimenC);
            this.Controls.Add(this.txt_TelContactoC);
            this.Controls.Add(this.lbl_TelContactoC);
            this.Controls.Add(this.txt_ContactoC);
            this.Controls.Add(this.lbl_ContactoC);
            this.Controls.Add(this.txt_CtaBcaC);
            this.Controls.Add(this.lbl_CtaBcaC);
            this.Controls.Add(this.txt_NumExtC);
            this.Controls.Add(this.lbl_NumExtC);
            this.Controls.Add(this.txt_CalleC);
            this.Controls.Add(this.lbl_CalleC);
            this.Controls.Add(this.txt_TelefonoC);
            this.Controls.Add(this.lbl_TelefonoC);
            this.Controls.Add(this.txt_LadaC);
            this.Controls.Add(this.lbl_LadaC);
            this.Controls.Add(this.txt_CorreoC);
            this.Controls.Add(this.lbl_CorreoC);
            this.Controls.Add(this.txt_RfcC);
            this.Controls.Add(this.lbl_RfcC);
            this.Controls.Add(this.btn_ActualizarC);
            this.Controls.Add(this.btn_RegistrarC);
            this.Controls.Add(this.txt_NomCliente);
            this.Controls.Add(this.lbl_NomCliente);
            this.Controls.Add(this.txt_IdCliente);
            this.Controls.Add(this.lbl_IdCliente);
            this.Name = "Frm_clientes";
            this.Text = "Frm_clientes";
            this.Load += new System.EventHandler(this.Frm_clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ActualizarC;
        private System.Windows.Forms.Button btn_RegistrarC;
        private System.Windows.Forms.TextBox txt_NomCliente;
        private System.Windows.Forms.Label lbl_NomCliente;
        private System.Windows.Forms.TextBox txt_IdCliente;
        private System.Windows.Forms.Label lbl_IdCliente;
        private System.Windows.Forms.TextBox txt_CorreoC;
        private System.Windows.Forms.Label lbl_CorreoC;
        private System.Windows.Forms.TextBox txt_RfcC;
        private System.Windows.Forms.Label lbl_RfcC;
        private System.Windows.Forms.TextBox txt_TelefonoC;
        private System.Windows.Forms.Label lbl_TelefonoC;
        private System.Windows.Forms.TextBox txt_LadaC;
        private System.Windows.Forms.Label lbl_LadaC;
        private System.Windows.Forms.TextBox txt_RegimenC;
        private System.Windows.Forms.Label lbl_RegimenC;
        private System.Windows.Forms.TextBox txt_TelContactoC;
        private System.Windows.Forms.Label lbl_TelContactoC;
        private System.Windows.Forms.TextBox txt_ContactoC;
        private System.Windows.Forms.Label lbl_ContactoC;
        private System.Windows.Forms.TextBox txt_CtaBcaC;
        private System.Windows.Forms.Label lbl_CtaBcaC;
        private System.Windows.Forms.TextBox txt_NumExtC;
        private System.Windows.Forms.Label lbl_NumExtC;
        private System.Windows.Forms.TextBox txt_CalleC;
        private System.Windows.Forms.Label lbl_CalleC;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource vENTASDataSetBindingSource;
        private VENTASDataSet vENTASDataSet;
        private VENTASDataSet2 vENTASDataSet2;
        private System.Windows.Forms.BindingSource cLIENTESBindingSource;
        private VENTASDataSet2TableAdapters.CLIENTESTableAdapter cLIENTESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLNOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLRFCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLCORREODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLLADADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLTELEFONODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLCALLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLNUMEROEXTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLCTABANCARIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLCONTACTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLTELEFCONTACTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLREGIMENDataGridViewTextBoxColumn;
    }
}