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
    public partial class InfoStudenti : Form
    {
        public InfoStudenti()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCodStudent_TextChanged(object sender, EventArgs e)
        {
            if (txtCodStudent.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = " data source = DESKTOP-OAK6S3P\\WINCC; database = Biblioteca; integrated security =True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from StudentNou where scod LIKE '" + txtCodStudent.Text + "%'";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                dataGridView2.DataSource = DS.Tables[0];
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = " data source = DESKTOP-OAK6S3P\\WINCC; database = Biblioteca; integrated security =True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from StudentNou";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                dataGridView2.DataSource = DS.Tables[0];
            }

        }

        private void InfoStudenti_Load(object sender, EventArgs e)
        {
            panel3.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = " data source = DESKTOP-OAK6S3P\\WINCC; database = Biblioteca; integrated security =True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from StudentNou";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGridView2.DataSource = DS.Tables[0];
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Datele nu vor fi salvate!", "Sunteti sigur?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {

                panel3.Visible = false;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            InfoStudenti_Load(this, null);
        }

        int bid;
        Int64 rowid;
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
                
            }

            panel3.Visible = true;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = " data source = DESKTOP-OAK6S3P\\WINCC; database = Biblioteca; integrated security =True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from StudentNou where stuid= " + bid + "";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            rowid = Int64.Parse(DS.Tables[0].Rows[0][0].ToString());


            txtNume.Text = DS.Tables[0].Rows[0][1].ToString();
            txtCod.Text = DS.Tables[0].Rows[0][2].ToString();
            txtFacultate.Text = DS.Tables[0].Rows[0][3].ToString();
            txtAn.Text = DS.Tables[0].Rows[0][4].ToString();
            txtTelefon.Text = DS.Tables[0].Rows[0][5].ToString();
            txtEmail.Text = DS.Tables[0].Rows[0][6].ToString();

        }

        private void btnActualizati_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Datele vor fi actualizate ! ", "Succes", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                String bNume = txtNume.Text;
                String bAutor = txtCod.Text;
                String bEditie = txtFacultate.Text;
                String bData = txtAn.Text;
                Int64 bPret = Int64.Parse(txtTelefon.Text);
                Int64 bCantitate = Int64.Parse(txtEmail.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = " data source = DESKTOP-OAK6S3P\\WINCC; database = Biblioteca; integrated security =True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "update StudentNou set snume= '" + bNume + "',scod ='" + bAutor + "', sfacultate ='" + bEditie + "' , san='" + bData + "',stelefon=" + bPret + ",semail=" + bCantitate + " where stuid =" + rowid + "  ";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                InfoStudenti_Load(this, null);
            }
        }

        private void btnStergeti_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Datele vor fi sterse! ", "Stergere", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {


                SqlConnection con = new SqlConnection();
                con.ConnectionString = " data source = DESKTOP-OAK6S3P\\WINCC; database = Biblioteca; integrated security =True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "delete from StudentNou where stuid =" + rowid + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
            }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Datele nu se vor salva!", "Doriti sa iesiti?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)

            {
                this.Close();
            }
        }
    }
}
