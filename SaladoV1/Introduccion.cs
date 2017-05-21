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
    public partial class Introduccion : Form
    {
        public Introduccion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Nivel a = new Nivel();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HistoriaNIvel1 a = new HistoriaNIvel1();
            a.Show();
        }
    }
}
