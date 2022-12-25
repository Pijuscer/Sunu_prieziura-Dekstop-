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
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();

           

        }


        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=db_user.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();


       

      

        private void button_register_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "" || txtRepeatPassword.Text == "")
            {
                MessageBox.Show("Prašome užpildyti visus langus", "Registracija nesėkminga", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txtPassword.Text != txtRepeatPassword.Text)
            {
                MessageBox.Show("Slaptažodžiai nesutampa", "Registracija nesėkminga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtRepeatPassword.Text = "";
                txtPassword.Focus();
            }
            else
            {
                con.Open();

               
                string login = "SELECT * FROM tbl_users WHERE username= '" + txtUsername.Text +  "'";
                cmd = new OleDbCommand(login, con);
                OleDbDataReader dr = cmd.ExecuteReader();

                

                if (dr.Read())
                {
                    MessageBox.Show("Vartotojas su šiuo vardu jau užregistruotas", "Gerai", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtRepeatPassword.Text = "";

                    txtUsername.Focus();


                    con.Close();
                }


                else
                {
                    

                    string register = "INSERT INTO tbl_users VALUES ('" + txtUsername.Text + "', '" + txtPassword.Text + "', '0')";
                    cmd = new OleDbCommand(register, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Vartotojas užregistruotas sėkmingai", "Testi", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    new FormLogin().Show();
                    this.Hide();
                }

            }

        }

        private void label6_Click(object sender, EventArgs e)
        {
            new FormLogin().Show();
            this.Hide();
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
