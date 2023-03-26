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
    public partial class Frm_Reporte : Form
    {
        public Frm_Reporte()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

         
            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(Conexion.conectar());
            SqlCommand command = new SqlCommand("SP_EXISTENCIAS", conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@VA", "boton");
            command.Parameters.AddWithValue("@id_producto", comboBox1.SelectedValue);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(dt);

            dataGridView1.DataSource = dt;

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
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

        private void Frm_Reporte_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();         

            SqlConnection conn = new SqlConnection(Conexion.conectar());
            conn.Open();

            SqlCommand cmd = new SqlCommand("SP_EXISTENCIAS", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@VA", "llenaCombo");
            cmd.Parameters.AddWithValue("@id_producto", 0);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);

            comboBox1.DisplayMember = "AL_NOMBRE";
            comboBox1.ValueMember = "AL_ID";
            comboBox1.DataSource = dt;

            conn.Close();




        }
    }
}
