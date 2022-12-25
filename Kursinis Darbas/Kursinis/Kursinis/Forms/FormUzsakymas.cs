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
    public partial class FormUzsakymas : Form
    {
        public FormUzsakymas()
        {
            InitializeComponent();
        }


        public string username { get; set; }

        private List<Diena> pateiktosDienos = new List<Diena>();

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=db_user.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();


        private void FormUzsakymas_Load(object sender, EventArgs e)
        {
            data.Rows.Clear();
            pateiktosDienos.Clear();


            con.Open();
            string login = "SELECT * FROM tbl_laisvumas";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            DateTime today = DateTime.Now;

            int siandienMenesis = today.Month;
            int siandienDiena = today.Day;

            while (dr.Read())
            {
                int menesis = int.Parse(dr[1].ToString());
                int diena = int.Parse(dr[2].ToString());
                string laisv = dr[3].ToString();


            if ((siandienMenesis == menesis && siandienDiena <= diena) || siandienMenesis < menesis)
                {
                    if (laisv.Count() != 0)
                    {
                        if (!(laisv == "Nebėra vietu"))
                        {
                            pateiktosDienos.Add(new Diena(menesis, diena, laisv));

                            data.Rows.Add(diena, menesis, laisv);
                        }


                    }

                }
                
            }

            con.Close();


            DateTime dirbuNuo = new DateTime(2000, 12, 3, 8, 0, 0);
            DateTime dirbuIki = new DateTime(2000, 12, 3, 20, 0, 0);

 
            DateTime todayAdded = today.AddHours(3);


            menesis.Text = today.Month.ToString();
            diena.Text = today.Day.ToString();


            if(dirbuNuo.Hour > today.Hour)
            {
                nuo.Text = dirbuNuo.Hour.ToString();
                DateTime naujas = dirbuNuo.AddHours(2);
                iki.Text = naujas.Hour.ToString();

            }
            else if(dirbuIki.Hour < today.Hour)
            {
                DateTime naujas = today.AddDays(1);
                menesis.Text = naujas.Month.ToString();
                diena.Text = naujas.Day.ToString();


                nuo.Text = dirbuNuo.Hour.ToString();


                DateTime naujass = dirbuNuo.AddHours(2);

                iki.Text = naujass.Hour.ToString();
            }
            else
            {
                nuo.Text = today.Hour.ToString();
                iki.Text = todayAdded.Hour.ToString();
            }

        }

        private void buttonPaslaugasUzsisakytiAdmin_Click(object sender, EventArgs e)
        {
            if(!Namuose.Checked && !Atvykus.Checked)
            {
                MessageBox.Show("Prašome pažymėti kur paliksite augintini", "Gerai", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                int men = int.Parse(menesis.Text);
                int dd = int.Parse(diena.Text);

                int nu = int.Parse(nuo.Text);
                int ik = int.Parse(iki.Text);

                string laisv = "";
                List<int> laikai = new List<int>();

                for (int i = nu; i < ik + 1; i++)
                {
                    laikai.Add(i);
                    laisv += i + " ";

                }


                if (!arLaisva(men, dd, laisv))
                {
                    MessageBox.Show("Šis laikas nėra galimas", "Gerai", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int id = max_id();
                    id += 1;

                    int mx = laikai.Max();
                    int mm = laikai.Min();


                    int kiekis = mx - mm;


                    string kada = men + "-" + dd + " " + mm + ":00-" + mx + ":00 ";

                    string kur = "";

                    if (Namuose.Checked)
                        kur = "Namuose";
                    else
                        kur = "Atvykti";

                    string kaina = gauti_kaina(kur, kiekis).ToString();




                    string tel_nr = "";
                    string adresas = "";
                    string veisle = "";
                    string amzius = "";
                    string svoris = "";
                    string alergija = "";
                    string draugiskas = "";
                    string vardas = "";
                    string pavarde = "";


                    con.Open();
                    string login = "SELECT * FROM tbl_userData WHERE username= '" + username + "'";
                    cmd = new OleDbCommand(login, con);
                    OleDbDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        tel_nr = dr[1].ToString();
                        adresas = dr[2].ToString();
                        veisle = dr[3].ToString();
                        amzius = dr[4].ToString();
                        svoris = dr[5].ToString();
                        alergija = dr[6].ToString();
                        draugiskas = dr[7].ToString();
                        vardas = dr[8].ToString();
                        pavarde = dr[9].ToString();

                    }

                    con.Close();


                    con.Open();
                    string register = "INSERT INTO tbl_order VALUES ('" + id + "', '" + kada + "', '" + kur + "'," +
                        " '" + adresas + "', '" + kaina + "', '" + tel_nr + "'," +
                        " '" + vardas + "', '" + pavarde + "', '" + veisle + "'," +
                        " '" + amzius + "', '" + svoris + "', '" + alergija + "', '" + draugiskas + "', '" + username + "')";


                    cmd = new OleDbCommand(register, con);
                    cmd.ExecuteNonQuery();
                    con.Close();


                    MessageBox.Show("Užsakymas patvirtintas, Jūsų kaina " + kaina, "Testi", MessageBoxButtons.OK, MessageBoxIcon.Information);



                    object objektas = null;
                    EventArgs ex = null;
                    this.FormUzsakymas_Load(objektas, ex);






                }



            }





        }

        private int gauti_kaina(string kur, int kiekis)
        {
            string kk = "";

            int kaina = 0;

            if (kur == "Namuose")
                kk = "kaina_N";
            else
                kk = "kaina_A";


            con.Open();
            string getData = "SELECT * FROM tbl_prop WHERE tipas=  '" + kk + "'";
            cmd = new OleDbCommand(getData, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                int kainaH = int.Parse(dr[1].ToString());

                kaina = kainaH * kiekis;

                if (kaina == 0)
                    kaina = kainaH;
            }

            con.Close();


            return kaina;
        }


        private int max_id()
        {
            int id = 0;

            con.Open();
            string login = "SELECT * FROM tbl_order";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                int idd = int.Parse(dr[0].ToString());

                if(id < idd)
                {
                    id = idd;
                }
            }

            con.Close();

            return id;
        }


        private bool arLaisva(int menesis, int diena, string laikas)
        {
            foreach (Diena item in pateiktosDienos)
            {
                if(menesis == item.menesis && diena == item.diena)
                {
                    string[] valandosP = item.laisvumas.Split(' ');
                    string[] valandosN = laikas.Split(' ');


                    if (valandosP.Count() < valandosN.Count())
                        return false;


                    List<int> valP = new List<int>();
                    List<int> valN = new List<int>();


                    foreach (string valanda in valandosP)
                    {
                        if(valanda != "")
                        {
                            int vv = int.Parse(valanda);
                            valP.Add(vv);

                        }

                    }

                    foreach (string valanda in valandosN)
                    {
                        if(valanda != "")
                        {
                            int vv = int.Parse(valanda);
                            valN.Add(vv);
                        }


                       
                    }


                    foreach (int valanda in valN)
                    {
                        if (!valP.Contains(valanda))
                        {
                            return false;
                        }
                    }


                    foreach (int valanda in valN)
                    {
                        valP.Remove(valanda);
                    }


                    string laisvumas = "";

                    foreach (int valanda in valP)
                    {
                        laisvumas = laisvumas + valanda.ToString() + " ";
                    }



                    con.Open();

                    if(laisvumas.Count() == 0)
                    {
                        laisvumas = "Nebera vietu";
                    }

                    string update = "UPDATE tbl_laisvumas SET laisvas= '" + laisvumas + "' WHERE menesis= '" + menesis.ToString() + "' AND diena= '" + diena.ToString() + "'";
                    cmd = new OleDbCommand(update, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    return true;
                }


            }


            return false;
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
    }
}
