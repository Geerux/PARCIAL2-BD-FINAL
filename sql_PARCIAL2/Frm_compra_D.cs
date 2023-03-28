using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sql_PARCIAL2
{
    public partial class Frm_compra_D : Form
    {
        public Frm_compra_D()
        {
            InitializeComponent();
        }

        private void Frm_compra_D_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vENTASDataSet11.TMP_COMPRA' Puede moverla o quitarla según sea necesario.
            this.tMP_COMPRATableAdapter2.Fill(this.vENTASDataSet11.TMP_COMPRA);
            // TODO: esta línea de código carga datos en la tabla 'vENTASDataSet10.TMP_COMPRA' Puede moverla o quitarla según sea necesario.
            this.tMP_COMPRATableAdapter1.Fill(this.vENTASDataSet10.TMP_COMPRA);
            // TODO: esta línea de código carga datos en la tabla 'vENTASDataSet9.TMP_COMPRA' Puede moverla o quitarla según sea necesario.
            this.tMP_COMPRATableAdapter.Fill(this.vENTASDataSet9.TMP_COMPRA);
            // TODO: esta línea de código carga datos en la tabla 'vENTASDataSet5.COMPRAS_DETALLE' Puede moverla o quitarla según sea necesario.
            this.cOMPRAS_DETALLETableAdapter.Fill(this.vENTASDataSet5.COMPRAS_DETALLE);

        }

        private void btn_RegistrarCD_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(Conexion.conectar());
            SqlCommand command = new SqlCommand("SP_WRITE_COMPRAS2", conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OP", 1);
            command.Parameters.AddWithValue("@CD_FOLIO","");
            command.Parameters.AddWithValue("@CD_SERIE", txt_SerieCD.Text);
            command.Parameters.AddWithValue("@CD_ID_TIPODUCTO", txt_IdTipoDctoCD.Text);
            command.Parameters.AddWithValue("@CD_ID_PRODUCTO", txt_IdProducto.Text);
            command.Parameters.AddWithValue("@CD_CANTIDAD", txt_CantidadCD.Text);
            command.Parameters.AddWithValue("@CD_IMPORTE", txt_ImporteCD.Text);
            command.Parameters.AddWithValue("@CD_IVA", txt_IvaCD.Text);
            command.Parameters.AddWithValue("@CD_UBICACION", txt_UbicacionCD.Text);

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Sus datos se guardaron correctamente");
                this.tMP_COMPRATableAdapter2.Fill(this.vENTASDataSet11.TMP_COMPRA);
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
       
        

        private void btn_RegistrarCD_Click_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(Conexion.conectar());
            SqlCommand command = new SqlCommand("SP_WRITE_COMPRAS2", conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OP", 1);
            command.Parameters.AddWithValue("@TMP_CO_FOLIO", txtFOLIO.Text);
            command.Parameters.AddWithValue("@TMP_CO_SERIE", txt_SerieCD.Text);
            command.Parameters.AddWithValue("@TMP_CO_ID_TIPODOCTO", txt_IdTipoDctoCD.Text);
            command.Parameters.AddWithValue("@TMP_CO_ID_PRODUCTO", txt_IdProducto.Text);
            command.Parameters.AddWithValue("@TMP_CO_MONTO", txtMONTO.Text);
            command.Parameters.AddWithValue("@TMP_CO_ID_PROVEEDOR", txtIDPROVEEDOR.Text);
            command.Parameters.AddWithValue("@TMP_CO_ID_ALMACEN", txtALMACEN.Text);
            command.Parameters.AddWithValue("@TMP_CO_FACTURA", txtFACTURA.Text);
            command.Parameters.AddWithValue("@TMP_CO_FECHA", txtFECHA.Text);
            command.Parameters.AddWithValue("@TMP_CD_IMPORTE", txt_ImporteCD.Text);
            command.Parameters.AddWithValue("@TMP_CD_IVA", txt_IvaCD.Text);
            command.Parameters.AddWithValue("@TMP_CD_UBICACION", txt_UbicacionCD.Text);

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Sus datos se guardaron correctamente");
                this.tMP_COMPRATableAdapter2.Fill(this.vENTASDataSet11.TMP_COMPRA);
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

    

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(Conexion.conectar());
            SqlCommand command = new SqlCommand("SP_WRITE_COMPRAS2", conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OP", 2);
            command.Parameters.AddWithValue("@TMP_CO_FOLIO", txtFOLIO.Text);
            command.Parameters.AddWithValue("@TMP_CO_SERIE", txt_SerieCD.Text);

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Sus datos se eliminaron correctamente");
                this.tMP_COMPRATableAdapter2.Fill(this.vENTASDataSet11.TMP_COMPRA);
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron eliminaron los datos correctamente: " + ex);
            }

            finally
            {
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(Conexion.conectar());
            SqlCommand command = new SqlCommand("SP_WRITE_COMPRAS2", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@OP", 3);

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Sus datos se pasaron a venta correctamente");
                this.tMP_COMPRATableAdapter2.Fill(this.vENTASDataSet11.TMP_COMPRA);
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron pasar los datos a venta: " + ex);
            }

            finally
            {
                conn.Close();
            }
        }
    }

}
