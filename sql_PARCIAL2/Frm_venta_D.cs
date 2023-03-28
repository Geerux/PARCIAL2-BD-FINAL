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
    public partial class Frm_venta_D : Form
    {
        public Frm_venta_D()
        {
            InitializeComponent();
        }

        private void Frm_venta_D_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vENTASDataSet8.TMPVENTA_DETALLE' Puede moverla o quitarla según sea necesario.
            this.tMPVENTA_DETALLETableAdapter1.Fill(this.vENTASDataSet8.TMPVENTA_DETALLE);
            // TODO: esta línea de código carga datos en la tabla 'vENTASDataSet7.TMPVENTA_DETALLE' Puede moverla o quitarla según sea necesario.
  
            // TODO: esta línea de código carga datos en la tabla 'vENTASDataSet6.VENTAS_DETALLE' Puede moverla o quitarla según sea necesario.
            this.vENTAS_DETALLETableAdapter.Fill(this.vENTASDataSet6.VENTAS_DETALLE);

        }

        private void btn_RegistrarCD_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(Conexion.conectar());
            SqlCommand command = new SqlCommand("SP_WRITE_VENTAS", conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OP", 1);
            command.Parameters.AddWithValue("TMP_ID_CLIENTE", txtCLIENTE.Text);
            command.Parameters.AddWithValue("TMP_ID_ALMACEN", txtALMACEN.Text);
            command.Parameters.AddWithValue("TMP_FOLIO", txtFOLIO.Text);
            command.Parameters.AddWithValue("TMP_SERIE", txtSERIE.Text);
            command.Parameters.AddWithValue("TMP_ID_TIPODOCTO", txtTIPODOC.Text);
            command.Parameters.AddWithValue("TMP_ID_PRODUCTO", txtPRODUCTO.Text);
            command.Parameters.AddWithValue("TMP_CANTIDAD", txtCANTIDAD.Text);
            command.Parameters.AddWithValue("TMP_IMPORTE", txtIMPORTE.Text);
            command.Parameters.AddWithValue("TMP_IVA", txtIVA.Text);
            command.Parameters.AddWithValue("TMP_FECHA", txtFECHA.Text);
            command.Parameters.AddWithValue("TMP_MONTO", txtMONTO.Text);

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Sus datos se guardaron correctamente");
                this.tMPVENTA_DETALLETableAdapter1.Fill(this.vENTASDataSet8.TMPVENTA_DETALLE);
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

        

        private void eliminar()
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(Conexion.conectar());
            SqlCommand command = new SqlCommand("SP_WRITE_VENTAS", conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@VA", "byEliminar");
            command.Parameters.AddWithValue("@VD_FOLIO", "");
          
            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Sus datos se borraron correctamente");
                dataGridView1.Refresh();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron borrar los datos correctamente: " + ex);
            }

            finally
            {
                conn.Close();
            }
        }

        private void btnACT_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(Conexion.conectar());
            SqlCommand command = new SqlCommand("SP_WRITE_VENTAS", conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OP", 2);
            command.Parameters.AddWithValue("@TMP_FOLIO", txtFOLIO.Text);
            command.Parameters.AddWithValue("@TMP_SERIE", txtSERIE.Text);

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Sus datos se borraron correctamente");
                dataGridView1.Refresh();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron borrar los datos correctamente: " + ex);
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
            SqlCommand command = new SqlCommand("SP_WRITE_VENTAS", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@OP", 3);

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Sus datos se pasaron a venta correctamente");
                dataGridView1.Refresh();
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

