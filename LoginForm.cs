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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsername_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            
                txtParola.PasswordChar = '*';
            
        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = " data source = DESKTOP-OAK6S3P\\WINCC; database=Biblioteca; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from loogTable where username='"+txtUtilizator.Text+"'and pass= '"+txtParola.Text+"'";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if(ds.Tables[0].Rows.Count != 0)
            {
                this.Hide();
                Dashboard dh = new Dashboard();
                dh.Show();
            }
            else
            {
                MessageBox.Show("Utilizatorul sau parola gresita !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Doriti sa iesiti ? ", " Iesire", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

            {
                this.Close();
            }
            }

            private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
