using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sql_PARCIAL2
{
    public partial class Frm_productos : Form
    {
        public Frm_productos()
        {
            InitializeComponent();
        }

        private void Frm_productos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vENTASDataSet3.PRODUCTOS' Puede moverla o quitarla según sea necesario.
            this.pRODUCTOSTableAdapter.Fill(this.vENTASDataSet3.PRODUCTOS);

        }

        private void guardar()
        {
            SqlConnection conn = new SqlConnection(Conexion.conectar());
            SqlCommand cmd = new SqlCommand("", conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_PRODUCTO";
            cmd.Parameters.AddWithValue("@OP", 1);
            cmd.Parameters.AddWithValue("@PR_ID", txt_IdCliente.Text);
            cmd.Parameters.AddWithValue("@PR_NOMBRE", txt_NomCliente.Text);
            cmd.Parameters.AddWithValue("@PR_ID_UNIDAD", txt_UnidadPdto.Text);
            cmd.Parameters.AddWithValue("@PR_STOCK_MIN", txt_StockMin.Text);
            cmd.Parameters.AddWithValue("@PR_STOCK_MAX", txt_StockMax.Text);
            cmd.Parameters.AddWithValue("@PR_ID_TP", txt_IdTp.Text);
            cmd.Parameters.AddWithValue("@PR_PRECIO", txt_PrecioPdto.Text);
            cmd.Parameters.AddWithValue("@PR_IVA", txt_IvaCD.Text);
            MessageBox.Show("Sus datos se guardaron correctamente");

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron guardar los datos correctamente: " + ex);
            }

            finally
            {
                conn.Close();
            }


        }

        private void actualizar()
        {
            SqlConnection conn = new SqlConnection(Conexion.conectar());
            SqlCommand cmd = new SqlCommand("", conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_PRODUCTO";
            cmd.Parameters.AddWithValue("@OP", 2);
            cmd.Parameters.AddWithValue("@PR_ID", txt_IdCliente.Text);
            cmd.Parameters.AddWithValue("@PR_NOMBRE", txt_NomCliente.Text);
            cmd.Parameters.AddWithValue("@PR_ID_UNIDAD", txt_UnidadPdto.Text);
            cmd.Parameters.AddWithValue("@PR_STOCK_MIN", txt_StockMin.Text);
            cmd.Parameters.AddWithValue("@PR_STOCK_MAX", txt_StockMax.Text);
            cmd.Parameters.AddWithValue("@PR_ID_TP", txt_IdTp.Text);
            cmd.Parameters.AddWithValue("@PR_PRECIO", txt_PrecioPdto.Text);
            cmd.Parameters.AddWithValue("@PR_IVA", txt_IvaCD.Text);
            MessageBox.Show("Sus datos se actualizaron correctamente");


            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron actualizar los datos correctamente: " + ex);
            }

            finally
            {
                conn.Close();
            }
        }

       

        private void btn_RegistrarIdTp_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void btn_ActualizarIdTp_Click(object sender, EventArgs e)
        {
            
        }

        private void btnELIMINAR_Click(object sender, EventArgs e)
        {

        }

        private void btnACTUALIZAR_Click(object sender, EventArgs e)
        {
            actualizar();
        }
    }
}
