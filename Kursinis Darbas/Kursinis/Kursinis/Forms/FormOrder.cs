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
    public partial class FormOrder : Form
    {
        public FormOrder()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=db_user.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();


        public string admin { get; set; }
        public string user { get; set; }


        private void FormOrder_Load(object sender, EventArgs e)
        {
            if(admin == "1")
            {
                con.Open();
                string login = "SELECT * FROM tbl_order ";
                cmd = new OleDbCommand(login, con);
                OleDbDataReader dr = cmd.ExecuteReader();


                data.ColumnHeadersHeight = 40;

                while (dr.Read())
                {
                    string draugikas = "Ne";

                    if (dr[12].ToString() == "1")
                        draugikas = "Taip";

                    string kur = "";

                    if (dr[2].ToString() == "Atvykti")
                    {
                        kur = "Pas savininka";
                    }
                    else
                    {
                        kur = "Pas prižiūrėtoja";
                    }



                    data.Rows.Add(dr[1].ToString(), kur, dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(),
                        dr[7].ToString(), dr[8].ToString(), dr[9].ToString(), dr[10].ToString(), dr[11].ToString(), draugikas);

                   

                }

                con.Close();
            }
            else
            {




                con.Open();
                string login = "SELECT * FROM tbl_order WHERE username = '" + user + "'";
                cmd = new OleDbCommand(login, con);
                OleDbDataReader dr = cmd.ExecuteReader();

                data.ColumnHeadersHeight = 40;


                int kiekis = 0;


                while (dr.Read())
                {
                    kiekis += 1;

                    string draugikas = "Ne";

                    if (dr[12].ToString() == "1")
                        draugikas = "Taip";

                    string kur = "";

                    if(dr[2].ToString() == "Atvykti")
                    {
                        kur = "Pas savininka";
                    }
                    else
                    {
                        kur = "Pas prižiūrėtoja";
                    }


                    data.Rows.Add(dr[1].ToString(), kur, dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(),
                        dr[7].ToString(), dr[8].ToString(), dr[9].ToString(), dr[10].ToString(), dr[11].ToString(), draugikas);

                   

                }

                con.Close();

                if(kiekis == 0)
                {
                    data.Visible = false;
                    label1.Visible = true;

                }


            }
        
        }
    }
}
