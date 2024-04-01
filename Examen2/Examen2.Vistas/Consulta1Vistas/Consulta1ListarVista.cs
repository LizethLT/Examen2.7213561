using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Examen2.Vistas.Consulta1Vistas
{
    public partial class Consulta1ListarVista : Form
    {
        public Consulta1ListarVista()
        {
            InitializeComponent();
        }
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1.DataSource = bss.Consulta1DatosBss();
        }

        private void Consulta1ListarVista_Load(object sender, EventArgs e)
        {

        }
    }
}
