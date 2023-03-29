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
    public partial class Returnare : Form
    {
        public Returnare()
        {
            InitializeComponent();
        }

        private void btnCautareStudent_Click(object sender, EventArgs e)
        {


            String eid = txtCodStudent.Text;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = " data source = DESKTOP-OAK6S3P\\WINCC; database = Biblioteca; integrated security =True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from Eliberare where stcod = '" + eid + "' and creturnare is null";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {
                dataGridView3.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Codul Nu Exista !", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }




        }

        private void Returnare_Load(object sender, EventArgs e)
        {
            panel3.Visible = false;
            txtCodStudent.Clear();
        }

        String bNume;
        String bData;
        Int64 rowid;

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel3.Visible = true;

            if (dataGridView3.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                rowid = Int64.Parse(dataGridView3.Rows[e.RowIndex].Cells[0].Value.ToString());
                bNume = dataGridView3.Rows[e.RowIndex].Cells[7].Value.ToString();
                bData = dataGridView3.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
            txtDenumireCarte.Text = bNume;
            txtEliberareData.Text = bData;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnReturnare_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = " data source = DESKTOP-OAK6S3P\\WINCC; database = Biblioteca; integrated security =True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd.CommandText = "update Eliberare set creturnare = '" + dateTimePicker1.Text + "' where stcod = '" + txtCodStudent.Text + "' and id = " + rowid + " ";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Returnate cu Succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Returnare_Load(this, null);
        }

        private void txtCodStudent_TextChanged(object sender, EventArgs e)
        {
            if (txtCodStudent.Text != "")
            {
                panel3.Visible = false;
                dataGridView3.DataSource = null;
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtCodStudent.Clear();
        }

        private void btnIesire_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Doriti sa iesiti?", "Iesire", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
            
                panel3.Visible = false;
            
        }
    }
}
