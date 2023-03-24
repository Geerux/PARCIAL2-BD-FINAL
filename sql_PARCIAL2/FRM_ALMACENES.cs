using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}
