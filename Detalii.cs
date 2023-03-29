using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class Detalii : Form
    {
        public Detalii()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                DetaliiEliberare detE= new DetaliiEliberare();
                detE.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DetaliiReturnare detR = new DetaliiReturnare();
            detR.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Doriti sa iesiti?", "Iesire", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
