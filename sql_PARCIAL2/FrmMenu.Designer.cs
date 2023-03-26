namespace sql_PARCIAL2
{
    partial class FrmMenu
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
            this.btn_Almaacenes = new System.Windows.Forms.Button();
            this.btn_Clientes = new System.Windows.Forms.Button();
            this.btn_CompraD = new System.Windows.Forms.Button();
            this.btn_Productos = new System.Windows.Forms.Button();
            this.btn_Proveedores = new System.Windows.Forms.Button();
            this.btn_Unidad = new System.Windows.Forms.Button();
            this.btn_VentaD = new System.Windows.Forms.Button();
            this.lbl_Menu = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Almaacenes
            // 
            this.btn_Almaacenes.Location = new System.Drawing.Point(22, 38);
            this.btn_Almaacenes.Name = "btn_Almaacenes";
            this.btn_Almaacenes.Size = new System.Drawing.Size(75, 23);
            this.btn_Almaacenes.TabIndex = 0;
            this.btn_Almaacenes.Text = "Almacenes";
            this.btn_Almaacenes.UseVisualStyleBackColor = true;
            this.btn_Almaacenes.Click += new System.EventHandler(this.btn_Almaacenes_Click);
            // 
            // btn_Clientes
            // 
            this.btn_Clientes.Location = new System.Drawing.Point(22, 67);
            this.btn_Clientes.Name = "btn_Clientes";
            this.btn_Clientes.Size = new System.Drawing.Size(75, 23);
            this.btn_Clientes.TabIndex = 1;
            this.btn_Clientes.Text = "Clientes";
            this.btn_Clientes.UseVisualStyleBackColor = true;
            this.btn_Clientes.Click += new System.EventHandler(this.btn_Clientes_Click);
            // 
            // btn_CompraD
            // 
            this.btn_CompraD.Location = new System.Drawing.Point(142, 38);
            this.btn_CompraD.Name = "btn_CompraD";
            this.btn_CompraD.Size = new System.Drawing.Size(75, 23);
            this.btn_CompraD.TabIndex = 2;
            this.btn_CompraD.Text = "Compra D";
            this.btn_CompraD.UseVisualStyleBackColor = true;
            this.btn_CompraD.Click += new System.EventHandler(this.btn_CompraD_Click);
            // 
            // btn_Productos
            // 
            this.btn_Productos.Location = new System.Drawing.Point(142, 67);
            this.btn_Productos.Name = "btn_Productos";
            this.btn_Productos.Size = new System.Drawing.Size(75, 23);
            this.btn_Productos.TabIndex = 3;
            this.btn_Productos.Text = "Productos";
            this.btn_Productos.UseVisualStyleBackColor = true;
            this.btn_Productos.Click += new System.EventHandler(this.btn_Productos_Click);
            // 
            // btn_Proveedores
            // 
            this.btn_Proveedores.Location = new System.Drawing.Point(22, 96);
            this.btn_Proveedores.Name = "btn_Proveedores";
            this.btn_Proveedores.Size = new System.Drawing.Size(75, 23);
            this.btn_Proveedores.TabIndex = 4;
            this.btn_Proveedores.Text = "Proveedores";
            this.btn_Proveedores.UseVisualStyleBackColor = true;
            this.btn_Proveedores.Click += new System.EventHandler(this.btn_Proveedores_Click);
            // 
            // btn_Unidad
            // 
            this.btn_Unidad.Location = new System.Drawing.Point(142, 96);
            this.btn_Unidad.Name = "btn_Unidad";
            this.btn_Unidad.Size = new System.Drawing.Size(75, 23);
            this.btn_Unidad.TabIndex = 5;
            this.btn_Unidad.Text = "Unidad";
            this.btn_Unidad.UseVisualStyleBackColor = true;
            this.btn_Unidad.Click += new System.EventHandler(this.btn_Unidad_Click);
            // 
            // btn_VentaD
            // 
            this.btn_VentaD.Location = new System.Drawing.Point(83, 125);
            this.btn_VentaD.Name = "btn_VentaD";
            this.btn_VentaD.Size = new System.Drawing.Size(75, 23);
            this.btn_VentaD.TabIndex = 6;
            this.btn_VentaD.Text = "Venta D";
            this.btn_VentaD.UseVisualStyleBackColor = true;
            this.btn_VentaD.Click += new System.EventHandler(this.btn_VentaD_Click);
            // 
            // lbl_Menu
            // 
            this.lbl_Menu.AutoSize = true;
            this.lbl_Menu.Location = new System.Drawing.Point(101, 6);
            this.lbl_Menu.Name = "lbl_Menu";
            this.lbl_Menu.Size = new System.Drawing.Size(39, 13);
            this.lbl_Menu.TabIndex = 8;
            this.lbl_Menu.Text = "MENU";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 46);
            this.button1.TabIndex = 9;
            this.button1.Text = "Reporte Masivo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 46);
            this.button2.TabIndex = 10;
            this.button2.Text = "Reporte Individual";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 294);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_Menu);
            this.Controls.Add(this.btn_VentaD);
            this.Controls.Add(this.btn_Unidad);
            this.Controls.Add(this.btn_Proveedores);
            this.Controls.Add(this.btn_Productos);
            this.Controls.Add(this.btn_CompraD);
            this.Controls.Add(this.btn_Clientes);
            this.Controls.Add(this.btn_Almaacenes);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Almaacenes;
        private System.Windows.Forms.Button btn_Clientes;
        private System.Windows.Forms.Button btn_CompraD;
        private System.Windows.Forms.Button btn_Productos;
        private System.Windows.Forms.Button btn_Proveedores;
        private System.Windows.Forms.Button btn_Unidad;
        private System.Windows.Forms.Button btn_VentaD;
        private System.Windows.Forms.Label lbl_Menu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}