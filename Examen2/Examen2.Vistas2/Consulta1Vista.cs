using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Examen2.Bss;
namespace Examen2.Vistas2
{
    public partial class Consulta1Vista : Form
    {
        public Consulta1Vista()
        {
            InitializeComponent();
        }
        ClienteBss bss = new ClienteBss();
     

        private void Consulta1Vista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ClienteListarBss();
        }
    }
}
