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
    public partial class FormStatistika : Form
    {
        public FormStatistika()
        {
            InitializeComponent();
        }


        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=db_user.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();


        private void FormStatistika_Load(object sender, EventArgs e)
        {
            con.Open();
            string login = "SELECT * FROM tbl_order";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            double kiekisN = 0;
            double kiekisA = 0;


            while (dr.Read())
            {
                if (dr[2].ToString() == "Atvykti")
                    kiekisA += 1;
                else
                    kiekisN += 1;

            }

            con.Close();


            double bendras = kiekisA + kiekisN;

            double procN = (kiekisN / bendras) * 100;
            double procA = 100 - procN;



            bar_namuose.Value = (int)procN;

            bar_atvykstant.Value = (int)procA;


        }
    }
}
