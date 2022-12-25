using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursinis.Forms
{
    public partial class FormProfilis : Form
    {
        public FormProfilis()
        {
            InitializeComponent();
        }


        public string username { get; set; }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=db_user.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();





        private void FormProfilis_Load(object sender, EventArgs e)
        {
            con.Open();
            string login = "SELECT * FROM tbl_userData WHERE username='"+ username + "'";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();




            if (dr.Read() == true) {
                tel_nr.Text = dr[1].ToString();
                adresas.Text = dr[2].ToString();
                veisle.Text = dr[3].ToString();
                amzius.Text = dr[4].ToString();
                svoris.Text = dr[5].ToString();
                alergija.Text = dr[6].ToString();
                vardas.Text = dr[8].ToString();
                pavarde.Text = dr[9].ToString();


                if(dr[7].ToString() == "1")
                {
                    draugiskas.Checked = true;
                }
                else
                {
                    nedraugiskas.Checked = true;
                }


                button_save.Visible = false;

            }


            con.Close();


                
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if(!draugiskas.Checked && !nedraugiskas.Checked)
                MessageBox.Show("Būtina pažymėti ar augintinis draugiškas ar ne", "Pranesimas", MessageBoxButtons.OK, MessageBoxIcon.Error);



            string draugiskumas = "0";

            if (draugiskas.Checked)
            {
                draugiskumas = "1";
            }

            con.Open();

            string register = "INSERT INTO tbl_userData VALUES ('" + username + "', '" + tel_nr.Text + "', " +
                "'" + adresas.Text + "', '" + veisle.Text + "', '" + amzius.Text +
                "' , '" + svoris.Text + "', '" + alergija.Text + "', '" + draugiskumas + "', '" + vardas.Text + "', '" + pavarde.Text + "' )";


            cmd = new OleDbCommand(register, con);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Vartotojo duomenys sėkmingai išsaugoti", "Testi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            button_save.Visible = false;

        }

        private void tel_nr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '+') && ((sender as TextBox).Text.Length == 0))
            {

                e.Handled = false;
                return;
            }

           


            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void vardas_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void pavarde_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void veisle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = false;
                return;
            }
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void amzius_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void svoris_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        
    }
}
