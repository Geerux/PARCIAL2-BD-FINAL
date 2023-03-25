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
    public partial class FRM_ALMACENES : Form
    {
        public FRM_ALMACENES()
        {
            InitializeComponent();
        }

        private void FRM_ALMACENES_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vENTASDataSet1.ALMACENES' Puede moverla o quitarla según sea necesario.
            this.aLMACENESTableAdapter.Fill(this.vENTASDataSet1.ALMACENES);

        }

        private void guardar()
        {
            SqlConnection conn = new SqlConnection(Conexion.conectar());
            SqlCommand cmd = new SqlCommand("", conn);


            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_ALMACENN";
            cmd.Parameters.AddWithValue("@OP", 1);
            cmd.Parameters.AddWithValue("@AL_ID",txt_IdAlmacen.Text);
            cmd.Parameters.AddWithValue("@AL_NOMBRE",txt_NomAlmacen.Text);
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
            cmd.CommandText = "SP_ALMACENN";
            cmd.Parameters.AddWithValue("@OP", 2);
            cmd.Parameters.AddWithValue("@AL_ID", txt_IdAlmacen.Text);
            cmd.Parameters.AddWithValue("@AL_NOMBRE",txt_NomAlmacen.Text);
            MessageBox.Show("Se actualizaron los datos");

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se actualizaron los datos: " + ex);
            }

            finally
            {
                conn.Close();
            }

        }

        private void btn_RegistrarA_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void BTNACTUALIZAR_Click(object sender, EventArgs e)
        {
            actualizar();
        }
    }
}
