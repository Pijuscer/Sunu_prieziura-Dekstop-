using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kursinis
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=db_user.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();



        private void button_login_Click(object sender, EventArgs e)
        {
            con.Open();
            string login = "SELECT * FROM tbl_users WHERE username= '" + txtUsername.Text + "' and password = '" + txtPassword.Text + "'";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();


            

            if(dr.Read() == true)
            {

                string type = dr[2].ToString();
                string usr = dr[0].ToString();


                con.Close();

                FormUserPanel user = new FormUserPanel();
                user.username = usr;
                user.admin = type;


                if(type == "1")
                {
                    type = "0";
                }
                else
                {
                    type = "-1";
                }
               

                user.type = type;
                user.Show();

                this.Hide();
            }

            else
            {
                con.Close();
                MessageBox.Show("Neteisingas vartotojo vardas arba slaptažodis", "Prisijungti nepavyko", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();
            }


        }

        private void label6_Click(object sender, EventArgs e)
        {
            new FormRegister().Show();
            this.Hide();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
