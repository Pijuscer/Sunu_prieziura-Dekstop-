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
    public partial class FormPaslaugos : Form
    {
        public FormPaslaugos()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=db_user.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();


        public string admin { get; set; }
        public string username { get; set; }

        private int max_namie = 0;
        private int max_atvykus = 0;




        private void FormPaslaugos_Load(object sender, EventArgs e)
        {
            string Namuose = "";
            string Atvykstant = "";


            if(admin == "1")
            {
                button_prideti.Visible = true;
                button_pridetiA.Visible = true;
                button_salinti.Visible = true;
                button_salintiA.Visible = true;

                text_prideti.Visible = true;
                text_pridetiA.Visible = true;
                text_salinti.Visible = true;
                text_salintiA.Visible = true;

                label5.Visible = true;
                label6.Visible = true;
            }







            con.Open();
            string gautiNamie = "SELECT * FROM tbl_pNamie";
            cmd = new OleDbCommand(gautiNamie, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if(admin == "1")
                {
                    Namuose += dr[1].ToString() + " ID= " + dr[0].ToString()  + "\n\n";
                }
                else
                {
                    Namuose += dr[1].ToString() + "\n\n";
                }


                int ID = int.Parse(dr[0].ToString());

                if(max_namie < ID){
                    max_namie = ID;
                }

            }

            con.Close();



            con.Open();
            string gautiAtvykus = "SELECT * FROM tbl_pAtvykus";
            cmd = new OleDbCommand(gautiAtvykus, con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (admin == "1")
                {
                    Atvykstant += dr[1].ToString() + " ID= " + dr[0].ToString() + "\n\n";
                }
                else
                {
                    Atvykstant += dr[1].ToString() + "\n\n";
                }

                int ID = int.Parse(dr[0].ToString());

                if (max_atvykus < ID)
                {
                    max_atvykus = ID;
                }

            }

            con.Close();



            label2.Text = Namuose;
            label4.Text = Atvykstant;
        }

        private void button_prideti_Click(object sender, EventArgs e)
        {
            
            max_namie += 1;

            con.Open();
            string prideti = "INSERT INTO tbl_pNamie VALUES ('" + max_namie + "', '" + text_prideti.Text + "')";
            cmd = new OleDbCommand(prideti, con);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Sekmingai prideta ID= " + max_namie, "Testi", MessageBoxButtons.OK, MessageBoxIcon.Information);


            object objektas = null;
            EventArgs ex = null;
            this.FormPaslaugos_Load(objektas, ex);

        }

        private void button_pridetiA_Click(object sender, EventArgs e)
        {
            max_atvykus += 1;

            con.Open();
            string prideti = "INSERT INTO tbl_pAtvykus VALUES ('" + max_atvykus + "', '" + text_pridetiA.Text + "')";
            cmd = new OleDbCommand(prideti, con);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Sekmingai prideta ID= " +max_atvykus, "Testi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            object objektas = null;
            EventArgs ex = null;
            this.FormPaslaugos_Load(objektas, ex);
        }

        private void button_salinti_Click(object sender, EventArgs e)
        {
           
            if(text_salinti.Text == "")
            {
                MessageBox.Show("Prašome įvesti ID prieš šalinant", "Testi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                text_salinti.Focus();
            }


            else if (onlyDigits(text_salinti.Text))
            {

                int id = int.Parse(text_salinti.Text);

                con.Open();
                string salinti = "DELETE FROM tbl_pNamie WHERE ID = '" + id + "'";
                cmd = new OleDbCommand(salinti, con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Sekmingai pašalinta ID= " + text_salinti.Text, "Testi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                object objektas = null;
                EventArgs ex = null;
                this.FormPaslaugos_Load(objektas, ex);
            }

            else
            {
                MessageBox.Show("Prašome įvesti tik ID", "Testi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

       

        private void button_salintiA_Click(object sender, EventArgs e)
        {
            if (text_salintiA.Text == "")
            {
                MessageBox.Show("Prašome įvesti ID prieš šalinant", "Testi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                text_salintiA.Focus();
            }


            else if (onlyDigits(text_salintiA.Text))
            {

                int id = int.Parse(text_salintiA.Text);

                con.Open();
                string salinti = "DELETE FROM tbl_pAtvykus WHERE ID = '" + id + "'";
                cmd = new OleDbCommand(salinti, con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Sėkmingai pašalinta ID= " + text_salintiA.Text, "Testi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                object objektas = null;
                EventArgs ex = null;
                this.FormPaslaugos_Load(objektas, ex);
            }

            else
            {
                MessageBox.Show("Prašome įvesti tik ID", "Testi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private Boolean onlyDigits(string line)
        {
            return line.All(char.IsDigit);
        }

        private void buttonPaslaugosDominaUser_Click(object sender, EventArgs e)
        {
            FormUzsakymas order = new FormUzsakymas();
            order.username = username;

            order.TopLevel = false;
            order.FormBorderStyle = FormBorderStyle.None;
            order.Dock = DockStyle.Fill;

            this.panelDesktop.Controls.Add(order);
            this.panelDesktop.Tag = order;
            order.BringToFront();
            order.Show();

        }

        private void text_salinti_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void text_salintiA_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
