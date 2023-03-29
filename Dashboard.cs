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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Doriti sa iesiti ? "," Iesire",MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                Application.Exit();
            }
            

        }

        private void adaugaCarteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void vizualizeazaCartiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VizualizareCarti vc = new VizualizareCarti();
            vc.Show();
        }

        private void studentiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void adaugaStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdaugStudent ads = new AdaugStudent();
            ads.Show();
           
        }

        private void studentiInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoStudenti info = new InfoStudenti();
            info.Show();
        }

        private void issueBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Eliberare el = new Eliberare();
            el.Show();
        }

        private void returnBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Returnare ret = new Returnare();
            ret.Show();
        }

        private void detaliiCarteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Detalii det = new Detalii();
            det.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajutor ajutor = new Ajutor();
            ajutor.Show();
        }
    }
}
