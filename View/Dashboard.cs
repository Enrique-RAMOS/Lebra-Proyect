using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lebra.View
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MostrarUsuarios frm = new MostrarUsuarios();
            frm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RegistroEmpleados frm2 = new RegistroEmpleados();
            frm2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
            MostrarEmpleados frm1 = new MostrarEmpleados();
            frm1.ShowDialog();
        }
    }
}
