using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaladoV1
{
    public partial class HistoriaNIvel2 : Form
    {
        public HistoriaNIvel2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PreguntasNiel1 a = new PreguntasNiel1();
            a.Show();
        }
    }
}
