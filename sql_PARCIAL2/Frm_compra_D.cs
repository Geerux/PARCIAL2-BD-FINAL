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
    public partial class Frm_compra_D : Form
    {
        public Frm_compra_D()
        {
            InitializeComponent();
        }

        private void Frm_compra_D_Load(object sender, EventArgs e)
        {

        }

        private void btn_RegistrarCD_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(Conexion.conectar());
            SqlCommand command = new SqlCommand("SP_WRITE_COMPRAS", conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@VA", "byGuardar");
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
