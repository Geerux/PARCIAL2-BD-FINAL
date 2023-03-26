namespace sql_PARCIAL2
{
    partial class FRM_ALMACENES
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
            this.lbl_IdAlmacen = new System.Windows.Forms.Label();
            this.txt_IdAlmacen = new System.Windows.Forms.TextBox();
            this.txt_NomAlmacen = new System.Windows.Forms.TextBox();
            this.lbl_NomAlmacen = new System.Windows.Forms.Label();
            this.btn_RegistrarA = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aLIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLNOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLMACENESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vENTASDataSet1 = new sql_PARCIAL2.VENTASDataSet1();
            this.vENTASDataSet = new sql_PARCIAL2.VENTASDataSet();
            this.vENTASDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aLMACENESTableAdapter = new sql_PARCIAL2.VENTASDataSet1TableAdapters.ALMACENESTableAdapter();
            this.BTNACTUALIZAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLMACENESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_IdAlmacen
            // 
            this.lbl_IdAlmacen.AutoSize = true;
            this.lbl_IdAlmacen.Location = new System.Drawing.Point(19, 10);
            this.lbl_IdAlmacen.Name = "lbl_IdAlmacen";
            this.lbl_IdAlmacen.Size = new System.Drawing.Size(72, 13);
            this.lbl_IdAlmacen.TabIndex = 0;
            this.lbl_IdAlmacen.Text = "ID ALMACEN";
            // 
            // txt_IdAlmacen
            // 
            this.txt_IdAlmacen.Location = new System.Drawing.Point(22, 26);
            this.txt_IdAlmacen.Name = "txt_IdAlmacen";
            this.txt_IdAlmacen.Size = new System.Drawing.Size(69, 20);
            this.txt_IdAlmacen.TabIndex = 1;
            // 
            // txt_NomAlmacen
            // 
            this.txt_NomAlmacen.Location = new System.Drawing.Point(136, 26);
            this.txt_NomAlmacen.Name = "txt_NomAlmacen";
            this.txt_NomAlmacen.Size = new System.Drawing.Size(69, 20);
            this.txt_NomAlmacen.TabIndex = 3;
            // 
            // lbl_NomAlmacen
            // 
            this.lbl_NomAlmacen.AutoSize = true;
            this.lbl_NomAlmacen.Location = new System.Drawing.Point(133, 10);
            this.lbl_NomAlmacen.Name = "lbl_NomAlmacen";
            this.lbl_NomAlmacen.Size = new System.Drawing.Size(44, 13);
            this.lbl_NomAlmacen.TabIndex = 2;
            this.lbl_NomAlmacen.Text = "Nombre";
            // 
            // btn_RegistrarA
            // 
            this.btn_RegistrarA.Location = new System.Drawing.Point(15, 78);
            this.btn_RegistrarA.Name = "btn_RegistrarA";
            this.btn_RegistrarA.Size = new System.Drawing.Size(75, 23);
            this.btn_RegistrarA.TabIndex = 4;
            this.btn_RegistrarA.Text = "Registrar";
            this.btn_RegistrarA.UseVisualStyleBackColor = true;
            this.btn_RegistrarA.Click += new System.EventHandler(this.btn_RegistrarA_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aLIDDataGridViewTextBoxColumn,
            this.aLNOMBREDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aLMACENESBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(171, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(303, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // aLIDDataGridViewTextBoxColumn
            // 
            this.aLIDDataGridViewTextBoxColumn.DataPropertyName = "AL_ID";
            this.aLIDDataGridViewTextBoxColumn.HeaderText = "AL_ID";
            this.aLIDDataGridViewTextBoxColumn.Name = "aLIDDataGridViewTextBoxColumn";
            // 
            // aLNOMBREDataGridViewTextBoxColumn
            // 
            this.aLNOMBREDataGridViewTextBoxColumn.DataPropertyName = "AL_NOMBRE";
            this.aLNOMBREDataGridViewTextBoxColumn.HeaderText = "AL_NOMBRE";
            this.aLNOMBREDataGridViewTextBoxColumn.Name = "aLNOMBREDataGridViewTextBoxColumn";
            // 
            // aLMACENESBindingSource
            // 
            this.aLMACENESBindingSource.DataMember = "ALMACENES";
            this.aLMACENESBindingSource.DataSource = this.vENTASDataSet1;
            // 
            // vENTASDataSet1
            // 
            this.vENTASDataSet1.DataSetName = "VENTASDataSet1";
            this.vENTASDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.vENTASDataSetBindingSource.CurrentChanged += new System.EventHandler(this.vENTASDataSetBindingSource_CurrentChanged);
            // 
            // aLMACENESTableAdapter
            // 
            this.aLMACENESTableAdapter.ClearBeforeFill = true;
            // 
            // BTNACTUALIZAR
            // 
            this.BTNACTUALIZAR.Location = new System.Drawing.Point(183, 78);
            this.BTNACTUALIZAR.Name = "BTNACTUALIZAR";
            this.BTNACTUALIZAR.Size = new System.Drawing.Size(75, 23);
            this.BTNACTUALIZAR.TabIndex = 7;
            this.BTNACTUALIZAR.Text = "ACTULIZAR";
            this.BTNACTUALIZAR.UseVisualStyleBackColor = true;
            this.BTNACTUALIZAR.Click += new System.EventHandler(this.BTNACTUALIZAR_Click);
            // 
            // FRM_ALMACENES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 335);
            this.Controls.Add(this.BTNACTUALIZAR);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_RegistrarA);
            this.Controls.Add(this.txt_NomAlmacen);
            this.Controls.Add(this.lbl_NomAlmacen);
            this.Controls.Add(this.txt_IdAlmacen);
            this.Controls.Add(this.lbl_IdAlmacen);
            this.Name = "FRM_ALMACENES";
            this.Text = "FRM_ALMACENES";
            this.Load += new System.EventHandler(this.FRM_ALMACENES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLMACENESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_IdAlmacen;
        private System.Windows.Forms.TextBox txt_IdAlmacen;
        private System.Windows.Forms.TextBox txt_NomAlmacen;
        private System.Windows.Forms.Label lbl_NomAlmacen;
        private System.Windows.Forms.Button btn_RegistrarA;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource vENTASDataSetBindingSource;
        private VENTASDataSet vENTASDataSet;
        private VENTASDataSet1 vENTASDataSet1;
        private System.Windows.Forms.BindingSource aLMACENESBindingSource;
        private VENTASDataSet1TableAdapters.ALMACENESTableAdapter aLMACENESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLNOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BTNACTUALIZAR;
    }
}