namespace sql_PARCIAL2
{
    partial class Frm_productos
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
            this.txt_NomCliente = new System.Windows.Forms.TextBox();
            this.lbl_NomPdto = new System.Windows.Forms.Label();
            this.txt_IdCliente = new System.Windows.Forms.TextBox();
            this.lbl_IdProducto = new System.Windows.Forms.Label();
            this.txt_IvaCD = new System.Windows.Forms.TextBox();
            this.lbl_IvaPdto = new System.Windows.Forms.Label();
            this.txt_PrecioPdto = new System.Windows.Forms.TextBox();
            this.lbl_Pdto = new System.Windows.Forms.Label();
            this.txt_UnidadPdto = new System.Windows.Forms.TextBox();
            this.lbl_UnidadPdto = new System.Windows.Forms.Label();
            this.txt_StockMin = new System.Windows.Forms.TextBox();
            this.lbl_StockMin = new System.Windows.Forms.Label();
            this.txt_StockMax = new System.Windows.Forms.TextBox();
            this.lbl_StockMax = new System.Windows.Forms.Label();
            this.txt_IdTp = new System.Windows.Forms.TextBox();
            this.lbl_IdTp = new System.Windows.Forms.Label();
            this.btn_ActualizarIdTp = new System.Windows.Forms.Button();
            this.btn_RegistrarIdTp = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pRIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRNOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRIDUNIDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRSTOCKMINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRSTOCKMAXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRIDTPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRPRECIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRIVADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vENTASDataSet3 = new sql_PARCIAL2.VENTASDataSet3();
            this.pRODUCTOSTableAdapter = new sql_PARCIAL2.VENTASDataSet3TableAdapters.PRODUCTOSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_NomCliente
            // 
            this.txt_NomCliente.Location = new System.Drawing.Point(118, 39);
            this.txt_NomCliente.Name = "txt_NomCliente";
            this.txt_NomCliente.Size = new System.Drawing.Size(69, 20);
            this.txt_NomCliente.TabIndex = 13;
            // 
            // lbl_NomPdto
            // 
            this.lbl_NomPdto.AutoSize = true;
            this.lbl_NomPdto.Location = new System.Drawing.Point(126, 23);
            this.lbl_NomPdto.Name = "lbl_NomPdto";
            this.lbl_NomPdto.Size = new System.Drawing.Size(44, 13);
            this.lbl_NomPdto.TabIndex = 12;
            this.lbl_NomPdto.Text = "Nombre";
            // 
            // txt_IdCliente
            // 
            this.txt_IdCliente.Location = new System.Drawing.Point(23, 39);
            this.txt_IdCliente.Name = "txt_IdCliente";
            this.txt_IdCliente.Size = new System.Drawing.Size(69, 20);
            this.txt_IdCliente.TabIndex = 11;
            // 
            // lbl_IdProducto
            // 
            this.lbl_IdProducto.AutoSize = true;
            this.lbl_IdProducto.Location = new System.Drawing.Point(29, 23);
            this.lbl_IdProducto.Name = "lbl_IdProducto";
            this.lbl_IdProducto.Size = new System.Drawing.Size(62, 13);
            this.lbl_IdProducto.TabIndex = 10;
            this.lbl_IdProducto.Text = "Id Producto";
            // 
            // txt_IvaCD
            // 
            this.txt_IvaCD.Location = new System.Drawing.Point(217, 93);
            this.txt_IvaCD.Name = "txt_IvaCD";
            this.txt_IvaCD.Size = new System.Drawing.Size(83, 20);
            this.txt_IvaCD.TabIndex = 73;
            // 
            // lbl_IvaPdto
            // 
            this.lbl_IvaPdto.AutoSize = true;
            this.lbl_IvaPdto.Location = new System.Drawing.Point(245, 77);
            this.lbl_IvaPdto.Name = "lbl_IvaPdto";
            this.lbl_IvaPdto.Size = new System.Drawing.Size(22, 13);
            this.lbl_IvaPdto.TabIndex = 72;
            this.lbl_IvaPdto.Text = "Iva";
            // 
            // txt_PrecioPdto
            // 
            this.txt_PrecioPdto.Location = new System.Drawing.Point(129, 94);
            this.txt_PrecioPdto.Name = "txt_PrecioPdto";
            this.txt_PrecioPdto.Size = new System.Drawing.Size(79, 20);
            this.txt_PrecioPdto.TabIndex = 71;
            // 
            // lbl_Pdto
            // 
            this.lbl_Pdto.AutoSize = true;
            this.lbl_Pdto.Location = new System.Drawing.Point(126, 77);
            this.lbl_Pdto.Name = "lbl_Pdto";
            this.lbl_Pdto.Size = new System.Drawing.Size(37, 13);
            this.lbl_Pdto.TabIndex = 70;
            this.lbl_Pdto.Text = "Precio";
            // 
            // txt_UnidadPdto
            // 
            this.txt_UnidadPdto.Location = new System.Drawing.Point(204, 39);
            this.txt_UnidadPdto.Name = "txt_UnidadPdto";
            this.txt_UnidadPdto.Size = new System.Drawing.Size(69, 20);
            this.txt_UnidadPdto.TabIndex = 75;
            // 
            // lbl_UnidadPdto
            // 
            this.lbl_UnidadPdto.AutoSize = true;
            this.lbl_UnidadPdto.Location = new System.Drawing.Point(214, 23);
            this.lbl_UnidadPdto.Name = "lbl_UnidadPdto";
            this.lbl_UnidadPdto.Size = new System.Drawing.Size(41, 13);
            this.lbl_UnidadPdto.TabIndex = 74;
            this.lbl_UnidadPdto.Text = "Unidad";
            // 
            // txt_StockMin
            // 
            this.txt_StockMin.Location = new System.Drawing.Point(290, 39);
            this.txt_StockMin.Name = "txt_StockMin";
            this.txt_StockMin.Size = new System.Drawing.Size(69, 20);
            this.txt_StockMin.TabIndex = 77;
            // 
            // lbl_StockMin
            // 
            this.lbl_StockMin.AutoSize = true;
            this.lbl_StockMin.Location = new System.Drawing.Point(288, 23);
            this.lbl_StockMin.Name = "lbl_StockMin";
            this.lbl_StockMin.Size = new System.Drawing.Size(71, 13);
            this.lbl_StockMin.TabIndex = 76;
            this.lbl_StockMin.Text = "Stock Minimo";
            // 
            // txt_StockMax
            // 
            this.txt_StockMax.Location = new System.Drawing.Point(379, 39);
            this.txt_StockMax.Name = "txt_StockMax";
            this.txt_StockMax.Size = new System.Drawing.Size(84, 20);
            this.txt_StockMax.TabIndex = 79;
            // 
            // lbl_StockMax
            // 
            this.lbl_StockMax.AutoSize = true;
            this.lbl_StockMax.Location = new System.Drawing.Point(389, 23);
            this.lbl_StockMax.Name = "lbl_StockMax";
            this.lbl_StockMax.Size = new System.Drawing.Size(74, 13);
            this.lbl_StockMax.TabIndex = 78;
            this.lbl_StockMax.Text = "Stock Maximo";
            // 
            // txt_IdTp
            // 
            this.txt_IdTp.Location = new System.Drawing.Point(32, 93);
            this.txt_IdTp.Name = "txt_IdTp";
            this.txt_IdTp.Size = new System.Drawing.Size(69, 20);
            this.txt_IdTp.TabIndex = 81;
            // 
            // lbl_IdTp
            // 
            this.lbl_IdTp.AutoSize = true;
            this.lbl_IdTp.Location = new System.Drawing.Point(38, 77);
            this.lbl_IdTp.Name = "lbl_IdTp";
            this.lbl_IdTp.Size = new System.Drawing.Size(40, 13);
            this.lbl_IdTp.TabIndex = 80;
            this.lbl_IdTp.Text = "Id Tipo";
            // 
            // btn_ActualizarIdTp
            // 
            this.btn_ActualizarIdTp.Location = new System.Drawing.Point(437, 94);
            this.btn_ActualizarIdTp.Name = "btn_ActualizarIdTp";
            this.btn_ActualizarIdTp.Size = new System.Drawing.Size(75, 23);
            this.btn_ActualizarIdTp.TabIndex = 83;
            this.btn_ActualizarIdTp.Text = "ELIMINAR";
            this.btn_ActualizarIdTp.UseVisualStyleBackColor = true;
            this.btn_ActualizarIdTp.Click += new System.EventHandler(this.btn_ActualizarIdTp_Click);
            // 
            // btn_RegistrarIdTp
            // 
            this.btn_RegistrarIdTp.Location = new System.Drawing.Point(338, 94);
            this.btn_RegistrarIdTp.Name = "btn_RegistrarIdTp";
            this.btn_RegistrarIdTp.Size = new System.Drawing.Size(75, 23);
            this.btn_RegistrarIdTp.TabIndex = 82;
            this.btn_RegistrarIdTp.Text = "Registrar";
            this.btn_RegistrarIdTp.UseVisualStyleBackColor = true;
            this.btn_RegistrarIdTp.Click += new System.EventHandler(this.btn_RegistrarIdTp_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pRIDDataGridViewTextBoxColumn,
            this.pRNOMBREDataGridViewTextBoxColumn,
            this.pRIDUNIDADDataGridViewTextBoxColumn,
            this.pRSTOCKMINDataGridViewTextBoxColumn,
            this.pRSTOCKMAXDataGridViewTextBoxColumn,
            this.pRIDTPDataGridViewTextBoxColumn,
            this.pRPRECIODataGridViewTextBoxColumn,
            this.pRIVADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pRODUCTOSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(891, 150);
            this.dataGridView1.TabIndex = 84;
            // 
            // pRIDDataGridViewTextBoxColumn
            // 
            this.pRIDDataGridViewTextBoxColumn.DataPropertyName = "PR_ID";
            this.pRIDDataGridViewTextBoxColumn.HeaderText = "PR_ID";
            this.pRIDDataGridViewTextBoxColumn.Name = "pRIDDataGridViewTextBoxColumn";
            // 
            // pRNOMBREDataGridViewTextBoxColumn
            // 
            this.pRNOMBREDataGridViewTextBoxColumn.DataPropertyName = "PR_NOMBRE";
            this.pRNOMBREDataGridViewTextBoxColumn.HeaderText = "PR_NOMBRE";
            this.pRNOMBREDataGridViewTextBoxColumn.Name = "pRNOMBREDataGridViewTextBoxColumn";
            // 
            // pRIDUNIDADDataGridViewTextBoxColumn
            // 
            this.pRIDUNIDADDataGridViewTextBoxColumn.DataPropertyName = "PR_ID_UNIDAD";
            this.pRIDUNIDADDataGridViewTextBoxColumn.HeaderText = "PR_ID_UNIDAD";
            this.pRIDUNIDADDataGridViewTextBoxColumn.Name = "pRIDUNIDADDataGridViewTextBoxColumn";
            // 
            // pRSTOCKMINDataGridViewTextBoxColumn
            // 
            this.pRSTOCKMINDataGridViewTextBoxColumn.DataPropertyName = "PR_STOCK_MIN";
            this.pRSTOCKMINDataGridViewTextBoxColumn.HeaderText = "PR_STOCK_MIN";
            this.pRSTOCKMINDataGridViewTextBoxColumn.Name = "pRSTOCKMINDataGridViewTextBoxColumn";
            // 
            // pRSTOCKMAXDataGridViewTextBoxColumn
            // 
            this.pRSTOCKMAXDataGridViewTextBoxColumn.DataPropertyName = "PR_STOCK_MAX";
            this.pRSTOCKMAXDataGridViewTextBoxColumn.HeaderText = "PR_STOCK_MAX";
            this.pRSTOCKMAXDataGridViewTextBoxColumn.Name = "pRSTOCKMAXDataGridViewTextBoxColumn";
            // 
            // pRIDTPDataGridViewTextBoxColumn
            // 
            this.pRIDTPDataGridViewTextBoxColumn.DataPropertyName = "PR_ID_TP";
            this.pRIDTPDataGridViewTextBoxColumn.HeaderText = "PR_ID_TP";
            this.pRIDTPDataGridViewTextBoxColumn.Name = "pRIDTPDataGridViewTextBoxColumn";
            // 
            // pRPRECIODataGridViewTextBoxColumn
            // 
            this.pRPRECIODataGridViewTextBoxColumn.DataPropertyName = "PR_PRECIO";
            this.pRPRECIODataGridViewTextBoxColumn.HeaderText = "PR_PRECIO";
            this.pRPRECIODataGridViewTextBoxColumn.Name = "pRPRECIODataGridViewTextBoxColumn";
            // 
            // pRIVADataGridViewTextBoxColumn
            // 
            this.pRIVADataGridViewTextBoxColumn.DataPropertyName = "PR_IVA";
            this.pRIVADataGridViewTextBoxColumn.HeaderText = "PR_IVA";
            this.pRIVADataGridViewTextBoxColumn.Name = "pRIVADataGridViewTextBoxColumn";
            // 
            // pRODUCTOSBindingSource
            // 
            this.pRODUCTOSBindingSource.DataMember = "PRODUCTOS";
            this.pRODUCTOSBindingSource.DataSource = this.vENTASDataSet3;
            // 
            // vENTASDataSet3
            // 
            this.vENTASDataSet3.DataSetName = "VENTASDataSet3";
            this.vENTASDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRODUCTOSTableAdapter
            // 
            this.pRODUCTOSTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 362);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_ActualizarIdTp);
            this.Controls.Add(this.btn_RegistrarIdTp);
            this.Controls.Add(this.txt_IdTp);
            this.Controls.Add(this.lbl_IdTp);
            this.Controls.Add(this.txt_StockMax);
            this.Controls.Add(this.lbl_StockMax);
            this.Controls.Add(this.txt_StockMin);
            this.Controls.Add(this.lbl_StockMin);
            this.Controls.Add(this.txt_UnidadPdto);
            this.Controls.Add(this.lbl_UnidadPdto);
            this.Controls.Add(this.txt_IvaCD);
            this.Controls.Add(this.lbl_IvaPdto);
            this.Controls.Add(this.txt_PrecioPdto);
            this.Controls.Add(this.lbl_Pdto);
            this.Controls.Add(this.txt_NomCliente);
            this.Controls.Add(this.lbl_NomPdto);
            this.Controls.Add(this.txt_IdCliente);
            this.Controls.Add(this.lbl_IdProducto);
            this.Name = "Frm_productos";
            this.Text = "Frm_productos";
            this.Load += new System.EventHandler(this.Frm_productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUCTOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_NomCliente;
        private System.Windows.Forms.Label lbl_NomPdto;
        private System.Windows.Forms.TextBox txt_IdCliente;
        private System.Windows.Forms.Label lbl_IdProducto;
        private System.Windows.Forms.TextBox txt_IvaCD;
        private System.Windows.Forms.Label lbl_IvaPdto;
        private System.Windows.Forms.TextBox txt_PrecioPdto;
        private System.Windows.Forms.Label lbl_Pdto;
        private System.Windows.Forms.TextBox txt_UnidadPdto;
        private System.Windows.Forms.Label lbl_UnidadPdto;
        private System.Windows.Forms.TextBox txt_StockMin;
        private System.Windows.Forms.Label lbl_StockMin;
        private System.Windows.Forms.TextBox txt_StockMax;
        private System.Windows.Forms.Label lbl_StockMax;
        private System.Windows.Forms.TextBox txt_IdTp;
        private System.Windows.Forms.Label lbl_IdTp;
        private System.Windows.Forms.Button btn_ActualizarIdTp;
        private System.Windows.Forms.Button btn_RegistrarIdTp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private VENTASDataSet3 vENTASDataSet3;
        private System.Windows.Forms.BindingSource pRODUCTOSBindingSource;
        private VENTASDataSet3TableAdapters.PRODUCTOSTableAdapter pRODUCTOSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRNOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRIDUNIDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRSTOCKMINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRSTOCKMAXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRIDTPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRPRECIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRIVADataGridViewTextBoxColumn;
    }
}