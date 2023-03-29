using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Biblioteca
{
    public partial class Ajutor : Form
    {
        public Ajutor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Iesire", "Doriti sa iesiti?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)

            {
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private const string FilePath = @"D:\\Ajutor.txt";
        private void textBox1_Click(object sender, EventArgs e)
        {
            File.WriteAllText(FilePath, textBox1.Text);
        }
    }
}
