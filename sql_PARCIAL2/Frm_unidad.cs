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
    public partial class Frm_unidad : Form
    {
        public Frm_unidad()
        {
            InitializeComponent();
        }

        private void Frm_unidad_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vENTASDataSet4.UNIDAD' Puede moverla o quitarla según sea necesario.
            this.uNIDADTableAdapter.Fill(this.vENTASDataSet4.UNIDAD);

        }

        private void guardar_actualizar()
        {
            SqlConnection conn = new SqlConnection(Conexion.conectar());
            SqlCommand cmd = new SqlCommand("", conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_UNIDAD";
            cmd.Parameters.AddWithValue("@OP", 1);
            cmd.Parameters.AddWithValue("@UN_ID",TXTUNIDAD.Text);
            cmd.Parameters.AddWithValue("UN_DESCRIPCION",TXTDESCRIPCION.Text);
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

        private void eliminar()
        {
            SqlConnection conn = new SqlConnection(Conexion.conectar());
            SqlCommand cmd = new SqlCommand("", conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_UNIDAD";
            cmd.Parameters.AddWithValue("@OP", 2);
            cmd.Parameters.AddWithValue("UN_ID",TXTUNIDAD.Text);
            MessageBox.Show("Los datos se borraron");


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

        private void BTNREGISTRAR_Click(object sender, EventArgs e)
        {
            guardar_actualizar();
        }

        private void BTNELIMINAR_Click(object sender, EventArgs e)
        {
            eliminar();
        }
    }
}
