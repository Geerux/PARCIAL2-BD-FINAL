using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sql_PARCIAL2
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btn_Almaacenes_Click(object sender, EventArgs e)
        {
            FRM_ALMACENES fRM_ALMACENES = new FRM_ALMACENES();
            fRM_ALMACENES.Show();
            
        }

        private void btn_CompraD_Click(object sender, EventArgs e)
        {
            Frm_compra_D Frm_compra_D = new Frm_compra_D();
            Frm_compra_D.Show();
           
        }

        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            Frm_clientes Frm_clientes = new Frm_clientes();
            Frm_clientes.Show();
            
        }

        private void btn_Productos_Click(object sender, EventArgs e)
        {
            Frm_productos Frm_productos = new Frm_productos();
            Frm_productos.Show();
           
        }

        private void btn_Proveedores_Click(object sender, EventArgs e)
        {
            Frm_proveedores Frm_proveedores = new Frm_proveedores();
            Frm_proveedores.Show();
            
        }

        private void btn_Unidad_Click(object sender, EventArgs e)
        {
            Frm_unidad Frm_unidad = new Frm_unidad();
            Frm_unidad.Show();
           
        }

        private void btn_VentaD_Click(object sender, EventArgs e)
        {
            Frm_venta_D Frm_venta_D = new Frm_venta_D();
            Frm_venta_D.Show();
            
           
          
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_Reporte Frm_Reporte = new Frm_Reporte();
            Frm_Reporte.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_ReporteMasivo Frm_ReporteMasivo = new Frm_ReporteMasivo();
            Frm_ReporteMasivo.Show();
        }
    }
}
