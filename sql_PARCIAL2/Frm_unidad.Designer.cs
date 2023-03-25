namespace sql_PARCIAL2
{
    partial class Frm_unidad
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTUNIDAD = new System.Windows.Forms.TextBox();
            this.TXTDESCRIPCION = new System.Windows.Forms.TextBox();
            this.BTNREGISTRAR = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uNIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uNDESCRIPCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uNIDADBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vENTASDataSet4 = new sql_PARCIAL2.VENTASDataSet4();
            this.uNIDADTableAdapter = new sql_PARCIAL2.VENTASDataSet4TableAdapters.UNIDADTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNIDADBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Unidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // TXTUNIDAD
            // 
            this.TXTUNIDAD.Location = new System.Drawing.Point(97, 93);
            this.TXTUNIDAD.Name = "TXTUNIDAD";
            this.TXTUNIDAD.Size = new System.Drawing.Size(100, 20);
            this.TXTUNIDAD.TabIndex = 2;
            // 
            // TXTDESCRIPCION
            // 
            this.TXTDESCRIPCION.Location = new System.Drawing.Point(242, 93);
            this.TXTDESCRIPCION.Name = "TXTDESCRIPCION";
            this.TXTDESCRIPCION.Size = new System.Drawing.Size(100, 20);
            this.TXTDESCRIPCION.TabIndex = 3;
            // 
            // BTNREGISTRAR
            // 
            this.BTNREGISTRAR.Location = new System.Drawing.Point(59, 167);
            this.BTNREGISTRAR.Name = "BTNREGISTRAR";
            this.BTNREGISTRAR.Size = new System.Drawing.Size(75, 23);
            this.BTNREGISTRAR.TabIndex = 4;
            this.BTNREGISTRAR.Text = "Registrar";
            this.BTNREGISTRAR.UseVisualStyleBackColor = true;
            this.BTNREGISTRAR.Click += new System.EventHandler(this.BTNREGISTRAR_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uNIDDataGridViewTextBoxColumn,
            this.uNDESCRIPCIONDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.uNIDADBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(87, 260);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(538, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // uNIDDataGridViewTextBoxColumn
            // 
            this.uNIDDataGridViewTextBoxColumn.DataPropertyName = "UN_ID";
            this.uNIDDataGridViewTextBoxColumn.HeaderText = "UN_ID";
            this.uNIDDataGridViewTextBoxColumn.Name = "uNIDDataGridViewTextBoxColumn";
            // 
            // uNDESCRIPCIONDataGridViewTextBoxColumn
            // 
            this.uNDESCRIPCIONDataGridViewTextBoxColumn.DataPropertyName = "UN_DESCRIPCION";
            this.uNDESCRIPCIONDataGridViewTextBoxColumn.HeaderText = "UN_DESCRIPCION";
            this.uNDESCRIPCIONDataGridViewTextBoxColumn.Name = "uNDESCRIPCIONDataGridViewTextBoxColumn";
            // 
            // uNIDADBindingSource
            // 
            this.uNIDADBindingSource.DataMember = "UNIDAD";
            this.uNIDADBindingSource.DataSource = this.vENTASDataSet4;
            // 
            // vENTASDataSet4
            // 
            this.vENTASDataSet4.DataSetName = "VENTASDataSet4";
            this.vENTASDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uNIDADTableAdapter
            // 
            this.uNIDADTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_unidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BTNREGISTRAR);
            this.Controls.Add(this.TXTDESCRIPCION);
            this.Controls.Add(this.TXTUNIDAD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_unidad";
            this.Text = "Frm_unidad";
            this.Load += new System.EventHandler(this.Frm_unidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNIDADBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTUNIDAD;
        private System.Windows.Forms.TextBox TXTDESCRIPCION;
        private System.Windows.Forms.Button BTNREGISTRAR;
        private System.Windows.Forms.DataGridView dataGridView1;
        private VENTASDataSet4 vENTASDataSet4;
        private System.Windows.Forms.BindingSource uNIDADBindingSource;
        private VENTASDataSet4TableAdapters.UNIDADTableAdapter uNIDADTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNDESCRIPCIONDataGridViewTextBoxColumn;
    }
}