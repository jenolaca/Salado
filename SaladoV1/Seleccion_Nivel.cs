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
            HistoriaNIvel2 frm = new HistoriaNIvel2();
            frm.Show();
            this.Visible = false;
        }

        private void Bnt2_Click(object sender, EventArgs e)
        {
            Introduccion a = new Introduccion();
            a.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            Introduccion a = new Introduccion();
            a.Show();
            this.Visible = false;

        }
    }
}
