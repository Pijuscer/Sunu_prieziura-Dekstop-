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
    public partial class FormLaisvumas : Form
    {
        public FormLaisvumas()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=db_user.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();


        private int max_id = 0;
        private List<Diena> uzpildytosdienos = new List<Diena>();


        private void FormLaisvumas_Load(object sender, EventArgs e)
        {

            data.Rows.Clear();
            uzpildytosdienos.Clear();
            con.Open();
            string login = "SELECT * FROM tbl_laisvumas";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();


            while (dr.Read())
            {
                int id = int.Parse(dr[0].ToString());

                if(max_id < id)
                {
                    max_id = id;
                }


                int diena = int.Parse(dr[2].ToString());
                int menesis = int.Parse(dr[1].ToString());

                if (!(dr[3].ToString() == "Nebera vietu")) 
                {
                    uzpildytosdienos.Add(new Diena(menesis, diena));


                    data.Rows.Add(dr[2].ToString(), dr[1].ToString(), dr[3].ToString());
                }

                   
            }

            con.Close();

            max_id += 1;

            DateTime today = DateTime.Now; // 12/20/2015 11:48:09 AM
            DateTime dirbuNuo = new DateTime(2000, 12, 3, 8, 0, 0);
            DateTime dirbuIki = new DateTime(2000, 12, 3, 20, 0, 0);

            menesis.Text = today.Month.ToString();
            diena.Text = today.Day.ToString();

            nuo.Text = dirbuNuo.Hour.ToString();
            iki.Text = dirbuIki.Hour.ToString();


        }

        private bool contains(Diena norima, List<Diena> esamosDienos)
        {
            foreach (Diena item in esamosDienos)
                if(norima.diena == item.diena && norima.menesis == item.menesis)
                    return true;

            return false;
        }


        private void button_prideti_Click(object sender, EventArgs e)
        {
            int norimaDiena = int.Parse(diena.Text);
            int norimasMenuo = int.Parse(menesis.Text);

            Diena norima = new Diena(norimasMenuo, norimaDiena);

            if(contains(norima, uzpildytosdienos))
            {
                MessageBox.Show("Ši data jau egzistuoja", "Gerai", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string laisvas = "";


                string pasalinti = isskyrus.Text;

                if(pasalinti == "")
                {
                    pasalinti = "0";
                }

                string[] words = pasalinti.Split(' ');
                List<int> netinkami = new List<int>();


                foreach (var word in words)
                {
                    int sk = int.Parse(word);
                    netinkami.Add(sk);
                }


                int pradeda = int.Parse(nuo.Text);
                int pabaigia = int.Parse(iki.Text);


                for (int i = pradeda; i < pabaigia + 1; i++)
                {
                    if (!netinkami.Contains(i))
                    {
                        laisvas += i + " ";
                    }
                }


                con.Open();

                string insert = "INSERT INTO tbl_laisvumas VALUES ('" + max_id + "', '" + menesis.Text + "', '" + diena.Text + "', '" + laisvas + "')";
                cmd = new OleDbCommand(insert, con);
                cmd.ExecuteNonQuery();
                con.Close();



                MessageBox.Show("Sėkmingai pridėtas laikas ", "Gerai", MessageBoxButtons.OK, MessageBoxIcon.Information);


                //this.Refresh();
                object objektas = null; 
                EventArgs ex = null;
                this.FormLaisvumas_Load(objektas, ex);

            }

        }

        private void menesis_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void diena_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void nuo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void iki_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void isskyrus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {

                e.Handled = false;
                return;
            }


            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
