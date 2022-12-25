using Kursinis.Forms;


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursinis
{
    public partial class FormUserPanel : Form
    {
        public Button currentButton;
        public Random random;
        public int tempIndex;
        public Form activeForm;

        public string username { get; set; }
        public string admin { get; set; }
        public string type { get; set; }



        public FormUserPanel()
        {
            InitializeComponent();
            random = new Random();
            buttonClose.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);



        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);

            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }

            tempIndex = index;

            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);

        }

        private void ActivateButton(object btnSerner)
        {
            if (btnSerner != null)
            {
                if (currentButton != (Button)btnSerner)
                {
                    DisableButton();

                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSerner;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.DimGray;
                    currentButton.Font = new System.Drawing.Font("Century", 14.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
                    panelTitleBar.BackColor = color;

                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    button_uzsakymai.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);

                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);

                    buttonClose.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control preiviousBtn in panelMenu.Controls)
            {
                if (preiviousBtn.GetType() == typeof(Button))
                {
                    preiviousBtn.BackColor = Color.FromArgb(111, 150, 247);
                    preiviousBtn.ForeColor = Color.White;
                    preiviousBtn.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
                }
            }
        }


        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            labelTitle.Text = childForm.Text;

        }



        private void button1_Click(object sender, EventArgs e)
        {
            //FormApieUser labas = new FormAbout();

            OpenChildForm(new FormAbout(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormKontaktai(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormKainos kainos = new FormKainos();
            kainos.admin = admin;


            OpenChildForm(kainos, sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormProfilis profilis = new FormProfilis();

            profilis.username = username;


            OpenChildForm(profilis, sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormPaslaugos paslaugos = new FormPaslaugos();
            paslaugos.admin = admin;
            paslaugos.username = username;

            OpenChildForm(paslaugos, sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormStatistika(), sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new FormLogin().Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormLaisvumas laisvumas = new FormLaisvumas();
            OpenChildForm(laisvumas, sender);

        }

        private void FormUserPanel_Load(object sender, EventArgs e)
        {
            labelUsername.Text = username;
            button_uzsakymai.Visible = true;

            if (admin == "1")
            {
                labelTitle.Text = "Admin panele";
                button4.Visible = false;
                
            }
            else
            {
                labelTitle.Text = "Sveiki";
                button8.Visible = false;
            }

            if (type == "0" || type == "1")
            {
                button_pereiti.Visible = true;
            }
                
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            if(activeForm != null)
            {
                activeForm.Close();
                
            }
            Reset();
        }

        private void Reset()
        {
            DisableButton();

            if(admin == "1")
            {
                labelTitle.Text = "Admin panele";
            }
            else
                labelTitle.Text = "Sveiki";


            panelTitleBar.BackColor = Color.FromArgb(118, 116, 242);
            panelLogo.BackColor = Color.RoyalBlue;
            button_uzsakymai.BackColor = Color.RoyalBlue;
            currentButton = null;
            buttonClose.Visible = false;
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_max_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void button_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button_uzsakymai_Click(object sender, EventArgs e)
        {

            FormOrder order = new FormOrder();

            order.admin = admin;
            order.user = username;
            OpenChildForm(order, sender);




            //OpenChildForm(new FormLaisvumas(), sender);

        }

        private void button_pereiti_Click(object sender, EventArgs e)
        {
            FormUserPanel user = new FormUserPanel();
            user.username = username;


            if(admin == "1" && type == "0")
            {
                user.admin = type;
                user.type = admin;
            }
            else if (admin == "0" && type == "1")
            {
                user.admin = type;
                user.type = admin;
            }


            user.Show();
            this.Hide();
        }
    }
}
