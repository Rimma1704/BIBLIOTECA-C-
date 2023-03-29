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
    public partial class Eliberare : Form
    {
        public Eliberare()
        {
            InitializeComponent();
        }

        private void Eliberare_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = " data source = DESKTOP-OAK6S3P\\WINCC; database = Biblioteca; integrated security =True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd= new SqlCommand("select bNume from CarteNoua", con);
            SqlDataReader Sdr = cmd.ExecuteReader();

            while (Sdr.Read())
            {
                for(int i=0;i<Sdr.FieldCount;i++)
                {
                    txtDenumireCarte.Items.Add(Sdr.GetString(i));
                }
            }
            Sdr.Close();
            con.Close();
           


        }

        int count;
        private void btnCautareStudent_Click(object sender, EventArgs e)
        {

            if (txtCodStudent.Text != "")
            {
                String eid = txtCodStudent.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = " data source = DESKTOP-OAK6S3P\\WINCC; database = Biblioteca; integrated security =True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from StudentNou where scod ='" + eid  +"'";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);


                //------------------------------------------------------
                //Cod cautare cate carti a luat 1 student
                cmd.CommandText = "select count(stcod) from Eliberare where stcod ='" +eid + "' and creturnare is null";
                SqlDataAdapter DA2 = new SqlDataAdapter(cmd);
                DataSet DS2 = new DataSet();
                DA2.Fill(DS2);

                count = int.Parse(DS2.Tables[0].Rows[0][0].ToString());


                //***********************************************************


                if (DS.Tables[0].Rows.Count!=0)
                {
                    txtNume.Text = DS.Tables[0].Rows[0][1].ToString();
                    txtFacultate.Text = DS.Tables[0].Rows[0][2].ToString();
                    txtAn.Text = DS.Tables[0].Rows[0][4].ToString();
                    txtTelefon.Text = DS.Tables[0].Rows[0][5].ToString();
                    txtEmail.Text = DS.Tables[0].Rows[0][6].ToString();
                    

                }
                else
                {
                    txtNume.Clear();
                    txtFacultate.Clear();
                    txtAn.Clear();
                    txtTelefon.Clear();
                    txtEmail.Clear();
                    MessageBox.Show("Codul Nu Exista !", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
               
            }
            
        }

        private void btnEliberareCarte_Click(object sender, EventArgs e)
        {
            if (txtNume.Text != "")
            {
                if (txtDenumireCarte.SelectedIndex != -1 && count <= 4)
                {
                    String scod = txtCodStudent.Text;
                    String snume = txtNume.Text;
                    String sfacultate = txtFacultate.Text;
                    String san = txtAn.Text;
                    Int64 stelefon = Int64.Parse(txtTelefon.Text);
                    String semail = txtEmail.Text;
                    String cdenumire = txtDenumireCarte.Text;
                    String celiberare = dateTimePicker1.Text;

                    String eid = txtCodStudent.Text;
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = " data source = DESKTOP-OAK6S3P\\WINCC; database = Biblioteca; integrated security =True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandText = "insert into Eliberare(stcod,stnume,stfacultate,stan,sttelefon,stemail,cdenumire,celiberare) values ('" + scod + "','" + snume + "','" + sfacultate + "','" + san + "','" + stelefon + "','" + semail + "','" + cdenumire + "','" + celiberare + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Eliberare Carte !", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Maxim 5 Carti !", "Ati ales deja 5 carti", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            
            
            }
        }

        private void txtCodStudent_TextChanged(object sender, EventArgs e)
        {
            if(txtCodStudent.Text =="")
            {
                txtNume.Clear();
                txtFacultate.Clear();
                txtAn.Clear();
                txtTelefon.Clear();
                txtEmail.Clear();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtCodStudent.Clear();
        }

        private void btnIesire_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Doriti sa iesiti?", "Iesire", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)==DialogResult.OK)
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
