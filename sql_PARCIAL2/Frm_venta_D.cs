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

        }

        private void btn_RegistrarCD_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(Conexion.conectar());
            SqlCommand command = new SqlCommand("SP_WRITE_VENTAS", conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@VA", "byGuardar");
            command.Parameters.AddWithValue("@VD_FOLIO", "");
            command.Parameters.AddWithValue("@VD_SERIE", txt_SerieVD.Text);
            command.Parameters.AddWithValue("@VD_ID_TIPODUCTO", txt_IdTipoDctoVD.Text);
            command.Parameters.AddWithValue("@VD_ID_PRODUCTO", txt_IdProducto.Text);
            command.Parameters.AddWithValue("@VD_CANTIDAD", txt_CantidadVD.Text);
            command.Parameters.AddWithValue("@VD_IMPORTE", txt_ImporteVD.Text);
            command.Parameters.AddWithValue("@VD_IVA", txt_IvaVD.Text);

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Sus datos se guardaron correctamente");
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
    }
}
