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
    public partial class AdaugStudent : Form
    {
        public AdaugStudent()
        {
            InitializeComponent();
        }

        private void btnIesire_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Doriti sa iesiti?", "Iesire", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtNume.Clear();
            txtCod.Clear();
            txtFacultate.Clear();
            txtStudii.Clear();
            txtTelefon.Clear();
            txtEmail.Clear();
            
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            if (txtNume.Text != "" && txtCod.Text != "" && txtFacultate.Text != "" && txtStudii.Text != "" && txtTelefon.Text != "" && txtEmail.Text != "")
            {
                String nume = txtNume.Text;
                String cod = txtCod.Text;
                String facultate = txtFacultate.Text;
                String an = txtStudii.Text;
                Int64 telefon = Int64.Parse(txtTelefon.Text);
                String email = txtTelefon.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-OAK6S3P\\WINCC; database=biblioteca; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = " insert into StudentNou (snume, scod,sfacultate,san,stelefon,semail) values ('" + nume + "','" + cod + "','" + facultate + "','" + an + "'," + telefon + "," + email + ")";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Salvate cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Completati Spatiile Goale !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Datele nu se vor salva!", "Doriti sa iesiti?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)

            {
                this.Close();
            }
        }

        private void txtCod_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
