using Examen2.Bss;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2.Vistas2
{
    public partial class Consulta4Vista : Form
    {
        public Consulta4Vista()
        {
            InitializeComponent();
        }
        ProductoFecBss bss = new ProductoFecBss();
        private void Consulta4Vista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ProductoDatosBss();
        }
    }
}
