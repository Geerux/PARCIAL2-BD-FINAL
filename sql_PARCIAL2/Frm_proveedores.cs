using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sql_PARCIAL2
{
    public partial class Frm_proveedores : Form
    {
        public Frm_proveedores()
        {
            InitializeComponent();
        }

        private void lbl_RegimenP_Click(object sender, EventArgs e)
        {

        }

        private void Frm_proveedores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vENTASDataSet.PROVEEDORES' Puede moverla o quitarla según sea necesario.
            this.pROVEEDORESTableAdapter.Fill(this.vENTASDataSet.PROVEEDORES);
        }
      

        private void guardar()
        {
                SqlConnection conn = new SqlConnection(Conexion.conectar());
                SqlCommand cmd = new SqlCommand("", conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_PROVEEDORES";
            cmd.Parameters.AddWithValue("@OP", 1);
            cmd.Parameters.AddWithValue("@PRO_ID", txt_IdProveedor.Text);
            cmd.Parameters.AddWithValue("@PRO_NOMBRE",txt_NomProveedor.Text);
            cmd.Parameters.AddWithValue("@PRO_RFC", txt_RfcP.Text);
            cmd.Parameters.AddWithValue("@PRO_CORREO", txt_CorreoP.Text);
            cmd.Parameters.AddWithValue("@PRO_LADA", txt_LadaP.Text);
            cmd.Parameters.AddWithValue("@PRO_TELEFONO", txt_TelefonoP.Text);
            cmd.Parameters.AddWithValue("@PRO_CALLE", txt_CalleP.Text);
            cmd.Parameters.AddWithValue("@PRO_NUMERO_EXT", txt_NumExtP.Text);
            cmd.Parameters.AddWithValue("@PRO_CTABANCARIA", txt_CtaBcaP.Text);
            cmd.Parameters.AddWithValue("@PRO_CONTACTO", txt_ContactoP.Text);
            cmd.Parameters.AddWithValue("@PRO_TELEF_CONTACTO", txt_TelContactoP.Text);
            cmd.Parameters.AddWithValue("@PRO_REGIMEN", txt_RegimenP.Text);
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
            cmd.CommandText = "SP_PROVEEDORES";
            cmd.Parameters.AddWithValue("@OP", 2);
            cmd.Parameters.AddWithValue("@PRO_ID", txt_IdProveedor.Text);
            cmd.Parameters.AddWithValue("@PRO_NOMBRE", txt_NomProveedor.Text);
            cmd.Parameters.AddWithValue("@PRO_RFC", txt_RfcP.Text);
            cmd.Parameters.AddWithValue("@PRO_CORREO", txt_CorreoP.Text);
            cmd.Parameters.AddWithValue("@PRO_LADA", txt_LadaP.Text);
            cmd.Parameters.AddWithValue("@PRO_TELEFONO", txt_TelefonoP.Text);
            cmd.Parameters.AddWithValue("@PRO_CALLE", txt_CalleP.Text);
            cmd.Parameters.AddWithValue("@PRO_NUMERO_EXT", txt_NumExtP.Text);
            cmd.Parameters.AddWithValue("@PRO_CTABANCARIA", txt_CtaBcaP.Text);
            cmd.Parameters.AddWithValue("@PRO_CONTACTO", txt_ContactoP.Text);
            cmd.Parameters.AddWithValue("@PRO_TELEF_CONTACTO", txt_TelContactoP.Text);
            cmd.Parameters.AddWithValue("@PRO_REGIMEN", txt_RegimenP.Text);
            MessageBox.Show("Los datos se actualizaron correctamente");

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron actualizar los datos: " + ex);
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
            cmd.CommandText = "SP_PROVEEDORES";
            cmd.Parameters.AddWithValue("@OP", 3);
            cmd.Parameters.AddWithValue("@PRO_ID", txt_IdProveedor.Text);
            MessageBox.Show("Se elimino con exito");
            

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

        private void btn_RegistrarP_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void btn_ActualizarP_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void BTNACTUALIZAR_Click(object sender, EventArgs e)
        {
            actualizar();
        }
    }
}
