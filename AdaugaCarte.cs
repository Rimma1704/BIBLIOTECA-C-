using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Biblioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            if (txtDenumire.Text != "" && txtAutor.Text != "" && txtEditie.Text != "" && txtPret.Text != "" && txtCant.Text != "")
            {


                String bnume = txtDenumire.Text;
                String bautor = txtAutor.Text;
                String beditie = txtEditie.Text;
                String bdata = dateTimePicker1.Text;
                Int64 bpret = Int64.Parse(txtPret.Text);
                Int64 bcantitate = Int64.Parse(txtCant.Text);
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-OAK6S3P\\WINCC; database=biblioteca; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = " insert into CarteNoua (bNume,bAutor,bEditie,bData,bPret,bCantitate) values ('" + bnume + "','" + bautor + "','" + beditie + "','" + bdata + "'," + bpret + "," + bcantitate + ")";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Salvate cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDenumire.Clear();
                txtAutor.Clear();
                txtEditie.Clear();
                txtPret.Clear();
                txtCant.Clear();
            }
            else
            {
                MessageBox.Show("Completati Spatiile Goale !","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Datele nu se vor salva!", "Doriti sa iesiti?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)

            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Datele nu se vor salva!", "Doriti sa iesiti?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)

            {
                this.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvare_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            if (txtDenumire.Text != "" && txtAutor.Text != "" && txtEditie.Text != "" && txtPret.Text != "" && txtCant.Text != "")
            {


                String bnume = txtDenumire.Text;
                String bautor = txtAutor.Text;
                String beditie = txtEditie.Text;
                String bdata = dateTimePicker1.Text;
                Int64 bpret = Int64.Parse(txtPret.Text);
                Int64 bcantitate = Int64.Parse(txtCant.Text);
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-OAK6S3P\\WINCC; database=biblioteca; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = " insert into CarteNoua (bNume,bAutor,bEditie,bData,bPret,bCantitate) values ('" + bnume + "','" + bautor + "','" + beditie + "','" + bdata + "'," + bpret + "," + bcantitate + ")";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Salvate cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDenumire.Clear();
                txtAutor.Clear();
                txtEditie.Clear();
                txtPret.Clear();
                txtCant.Clear();
            }
            else
            {
                MessageBox.Show("Completati Spatiile Goale !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
    }
}
