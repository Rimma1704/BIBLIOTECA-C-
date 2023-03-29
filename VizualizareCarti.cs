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
    public partial class VizualizareCarti : Form
    {
        public VizualizareCarti()
        {
            InitializeComponent();
        }

        private void VizualizareCarti_Load(object sender, EventArgs e)
        {


            panel22.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = " data source = DESKTOP-OAK6S3P\\WINCC; database = Biblioteca; integrated security =True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from CarteNoua";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        int bid;
        Int64 rowid;


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value!=null)
            {
                bid =int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                //MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel22.Visible = true;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = " data source = DESKTOP-OAK6S3P\\WINCC; database = Biblioteca; integrated security =True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from CarteNoua where bid= "+ bid + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString()); 


            txtDenumire.Text = ds.Tables[0].Rows[0][1].ToString();
            txtAutor.Text = ds.Tables[0].Rows[0][2].ToString();
            txtEditie.Text = ds.Tables[0].Rows[0][3].ToString();
            txtData.Text= ds.Tables[0].Rows[0][4].ToString();
            txtPret.Text= ds.Tables[0].Rows[0][5].ToString();
            txtCantitate.Text= ds.Tables[0].Rows[0][6].ToString(); 

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel22.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(txtDenumireCarte.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = " data source = DESKTOP-OAK6S3P\\WINCC; database = Biblioteca; integrated security =True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from CarteNoua where bNume LIKE '" +txtDenumireCarte.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = " data source = DESKTOP-OAK6S3P\\WINCC; database = Biblioteca; integrated security =True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from CarteNoua";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtDenumireCarte.Clear();
            panel22.Visible = false;
        }

        private void btnActualizati_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Datele vor fi actualizate ! ", "Succes", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                String bNume = txtDenumire.Text;
                String bAutor = txtAutor.Text;
                String bEditie = txtEditie.Text;
                String bData = txtData.Text;
                Int64 bPret = Int64.Parse(txtPret.Text);
                Int64 bCantitate = Int64.Parse(txtCantitate.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = " data source = DESKTOP-OAK6S3P\\WINCC; database = Biblioteca; integrated security =True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "update CarteNoua set bNume= '" + bNume + "',bAutor ='" + bAutor + "', bEditie ='" + bEditie + "' , bData='" + bData + "',bPret=" + bPret + ",bCantitate=" + bCantitate + " where bid =" + rowid + "  ";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Datele vor fi sterse! ", "Stergere", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
               

                SqlConnection con = new SqlConnection();
                con.ConnectionString = " data source = DESKTOP-OAK6S3P\\WINCC; database = Biblioteca; integrated security =True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "delete from CarteNoua where bid=" + rowid + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Datele nu se vor salva!", "Doriti sa iesiti?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)

            {
                this.Close();
            }
        }
    }
}
