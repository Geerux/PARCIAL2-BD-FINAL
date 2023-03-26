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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sql_PARCIAL2
{
    public partial class Frm_ReporteMasivo : Form
    {
        public Frm_ReporteMasivo()
        {
            InitializeComponent();
        }

        private void Frm_ReporteMasivo_Load(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(Conexion.conectar());
            conn.Open();

            SqlCommand cmd = new SqlCommand("SP_EXISTENCIAS", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@VA", "masiva");
            cmd.Parameters.AddWithValue("@id_producto", 0);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
            conn.Close();
        }
    }
}
