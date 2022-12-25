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
    public partial class FormKainos : Form
    {
        public FormKainos()
        {
            InitializeComponent();
        }

        private string kaina_N;
        private string kaina_NP;
        private string kaina_A;
        private string kaina_AP;


        public string admin { get; set; }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=db_user.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();



        private void FormKainos_Load(object sender, EventArgs e)
        {

            label5.Visible = false;
            label7.Visible = false;


            con.Open();
            string getData = "SELECT * FROM tbl_prop";
            cmd = new OleDbCommand(getData, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string tipas = dr[0].ToString();
                string gautaKaina = dr[1].ToString();

                switch (tipas)
                {
                    case "kaina_N" : kaina_N = gautaKaina; break;
                    case "kaina_NP": kaina_NP = gautaKaina; break;
                    case "kaina_A": kaina_A = gautaKaina; break;
                    case "kaina_AP": kaina_AP = gautaKaina; break;

                    default:
                        break;
                }
            }


            con.Close();


            if (admin == "1")
            {
                button_redaguoti_atvykus.Visible = true;
                button_redaguoti_namie.Visible = true;

                valandos.Visible = true;
               
                valandos_A.Visible = true;
                

                valandos.Text = kaina_N;
                paros.Text = kaina_NP;

                valandos_A.Text = kaina_A;
                paros_A.Text = kaina_AP;
            }

            else
            {
                // Pigesnis
                label4.Text = label4.Text + " " + kaina_N;
                label5.Text = label5.Text + " " + kaina_NP;


                // Brangesnis
                label6.Text = label6.Text + " " + kaina_A;
                label7.Text = label7.Text + " " + kaina_AP;
            }
        }

        private void button_redaguoti_namie_Click(object sender, EventArgs e)
        {
            con.Open();
            string update = "UPDATE tbl_prop SET reiksme= '" + valandos.Text + "' WHERE tipas= 'kaina_N'";
            cmd = new OleDbCommand(update, con);
            cmd.ExecuteNonQuery();
            con.Close();

            con.Open();
            string update2 = "UPDATE tbl_prop SET reiksme= '" + paros.Text + "' WHERE tipas= 'kaina_NP'";
            cmd = new OleDbCommand(update2, con);
            cmd.ExecuteNonQuery();
            con.Close();




            MessageBox.Show("Kaina namuose atnaujinta sėkmingai", "Testi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button_redaguoti_atvykus_Click(object sender, EventArgs e)
        {
            con.Open();
            string update = "UPDATE tbl_prop SET reiksme= '" + valandos_A.Text + "' WHERE tipas= 'kaina_A'";
            cmd = new OleDbCommand(update, con);
            cmd.ExecuteNonQuery();
            con.Close();

            con.Open();
            string update2 = "UPDATE tbl_prop SET reiksme= '" + paros_A.Text + "' WHERE tipas= 'kaina_AP'";
            cmd = new OleDbCommand(update2, con);
            cmd.ExecuteNonQuery();
            con.Close();




            MessageBox.Show("Kaina atvykstant atnaujinta sėkmingai", "Testi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void valandos_KeyPress(object sender, KeyPressEventArgs e)
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

        private void paros_KeyPress(object sender, KeyPressEventArgs e)
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

        private void valandos_A_KeyPress(object sender, KeyPressEventArgs e)
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

        private void paros_A_KeyPress(object sender, KeyPressEventArgs e)
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
