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
    public partial class Frm_clientes : Form
    {
        public Frm_clientes()
        {
            InitializeComponent();
        }

        private void Frm_clientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vENTASDataSet2.CLIENTES' Puede moverla o quitarla según sea necesario.
            this.cLIENTESTableAdapter.Fill(this.vENTASDataSet2.CLIENTES);

        }

        private void guardar()
        {
            SqlConnection conn = new SqlConnection(Conexion.conectar());
            SqlCommand cmd = new SqlCommand("", conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_CLIENTES_PARCIAL";
            cmd.Parameters.AddWithValue("@OP", 1);
            cmd.Parameters.AddWithValue("@CL_ID",txt_IdCliente.Text);
            cmd.Parameters.AddWithValue("@CL_NOMBRE",txt_NomCliente.Text);
            cmd.Parameters.AddWithValue("@CL_RFC", txt_RfcC.Text);
            cmd.Parameters.AddWithValue("@CL_CORREO", txt_CorreoC.Text);
            cmd.Parameters.AddWithValue("@CL_LADA", txt_LadaC.Text);
            cmd.Parameters.AddWithValue("@CL_TELEFONO", txt_TelefonoC.Text);
            cmd.Parameters.AddWithValue("@CL_CALLE", txt_CalleC.Text);
            cmd.Parameters.AddWithValue("@CL_NUMERO_EXT", txt_NumExtC.Text);
            cmd.Parameters.AddWithValue("@CL_CTABANCARIA", txt_CtaBcaC.Text);
            cmd.Parameters.AddWithValue("@CL_CONTACTO", txt_ContactoC.Text);
            cmd.Parameters.AddWithValue("@CL_TELEFONO_CONTACTO", txt_TelContactoC.Text);
            cmd.Parameters.AddWithValue("@CL_REGIMEN", txt_RegimenC.Text);
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
            cmd.CommandText = "SP_CLIENTES_PARCIAL";
            cmd.Parameters.AddWithValue("@OP", 2);
            cmd.Parameters.AddWithValue("@CL_ID", txt_IdCliente.Text);
            cmd.Parameters.AddWithValue("@CL_NOMBRE", txt_NomCliente.Text);
            cmd.Parameters.AddWithValue("@CL_RFC", txt_RfcC.Text);
            cmd.Parameters.AddWithValue("@CL_CORREO", txt_CorreoC.Text);
            cmd.Parameters.AddWithValue("@CL_LADA", txt_LadaC.Text);
            cmd.Parameters.AddWithValue("@CL_TELEFONO", txt_TelefonoC.Text);
            cmd.Parameters.AddWithValue("@CL_CALLE", txt_CalleC.Text);
            cmd.Parameters.AddWithValue("@CL_NUMERO_EXT", txt_NumExtC.Text);
            cmd.Parameters.AddWithValue("@CL_CTABANCARIA", txt_CtaBcaC.Text);
            cmd.Parameters.AddWithValue("@CL_CONTACTO", txt_ContactoC.Text);
            cmd.Parameters.AddWithValue("@CL_TELEFONO_CONTACTO", txt_TelContactoC.Text);
            cmd.Parameters.AddWithValue("@CL_REGIMEN", txt_RegimenC.Text);
            MessageBox.Show("se pudieron actualizar los datos");


            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron guardar los datos: " + ex);
            }

            finally
            {
                conn.Close();
            }

        }



        private void eliminar()
        {
            SqlConnection conn = new SqlConnection(Conexion.conectar());
            SqlCommand cmd = new SqlCommand("", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_CLIENTES_PARCIAL";
            cmd.Parameters.AddWithValue("@OP", 3);
            cmd.Parameters.AddWithValue("@CL_ID", txt_IdCliente.Text);
            MessageBox.Show("se eliminaron los datos");


            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron eliminar los datos: " + ex);
            }

            finally
            {
                conn.Close();
            }
        }

        private void btn_RegistrarC_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void btn_ActualizarC_Click(object sender, EventArgs e)
        {
            eliminar();

        }

        private void btnACT_Click(object sender, EventArgs e)
        {
            actualizar();
        }
    }


}
