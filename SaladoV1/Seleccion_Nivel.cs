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
    public partial class Nivel : Form
    {
        
        public Nivel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HistoriaNIvel1 frm = new HistoriaNIvel1();
            frm.Show();
        }

        private void Bnt2_Click(object sender, EventArgs e)
        {
            //PreguntasNivel11 a = new PreguntasNivel11();
            //a.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Introduccion a = new Introduccion();
            a.Show();
        }
    }
}
