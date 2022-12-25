namespace Kursinis.Forms
{
    partial class FormPaslaugos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.buttonPaslaugosDominaUser = new System.Windows.Forms.Button();
            this.panelPaslaugosUser2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.text_salintiA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_pridetiA = new System.Windows.Forms.TextBox();
            this.button_salintiA = new System.Windows.Forms.Button();
            this.button_pridetiA = new System.Windows.Forms.Button();
            this.panelPaslaugosUser = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.text_salinti = new System.Windows.Forms.TextBox();
            this.text_prideti = new System.Windows.Forms.TextBox();
            this.button_salinti = new System.Windows.Forms.Button();
            this.button_prideti = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDesktop.SuspendLayout();
            this.panelPaslaugosUser2.SuspendLayout();
            this.panelPaslaugosUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.buttonPaslaugosDominaUser);
            this.panelDesktop.Controls.Add(this.panelPaslaugosUser2);
            this.panelDesktop.Controls.Add(this.panelPaslaugosUser);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(800, 450);
            this.panelDesktop.TabIndex = 0;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // buttonPaslaugosDominaUser
            // 
            this.buttonPaslaugosDominaUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonPaslaugosDominaUser.BackColor = System.Drawing.SystemColors.Control;
            this.buttonPaslaugosDominaUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPaslaugosDominaUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonPaslaugosDominaUser.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonPaslaugosDominaUser.Location = new System.Drawing.Point(331, 388);
            this.buttonPaslaugosDominaUser.Name = "buttonPaslaugosDominaUser";
            this.buttonPaslaugosDominaUser.Size = new System.Drawing.Size(117, 45);
            this.buttonPaslaugosDominaUser.TabIndex = 8;
            this.buttonPaslaugosDominaUser.Text = "Domina";
            this.buttonPaslaugosDominaUser.UseVisualStyleBackColor = false;
            this.buttonPaslaugosDominaUser.Click += new System.EventHandler(this.buttonPaslaugosDominaUser_Click);
            // 
            // panelPaslaugosUser2
            // 
            this.panelPaslaugosUser2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelPaslaugosUser2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelPaslaugosUser2.Controls.Add(this.label6);
            this.panelPaslaugosUser2.Controls.Add(this.label4);
            this.panelPaslaugosUser2.Controls.Add(this.text_salintiA);
            this.panelPaslaugosUser2.Controls.Add(this.label3);
            this.panelPaslaugosUser2.Controls.Add(this.text_pridetiA);
            this.panelPaslaugosUser2.Controls.Add(this.button_salintiA);
            this.panelPaslaugosUser2.Controls.Add(this.button_pridetiA);
            this.panelPaslaugosUser2.Location = new System.Drawing.Point(430, 18);
            this.panelPaslaugosUser2.Name = "panelPaslaugosUser2";
            this.panelPaslaugosUser2.Size = new System.Drawing.Size(320, 364);
            this.panelPaslaugosUser2.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Brown;
            this.label6.Location = new System.Drawing.Point(22, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Nurodykite ID kurį pašalinti";
            this.label6.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label4.Location = new System.Drawing.Point(59, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 176);
            this.label4.TabIndex = 1;
            this.label4.Text = "Šuns prižiūrėjimas\r\n\r\nPavedžiojimas\r\n\r\nJeigu reikės ir paduodama valgyti\r\n\r\nUžsiė" +
    "mimas su šunimi\r\n\r\nŠuns iškrovimas protine veikla\r\n\r\nŠuns iškrovimas fizine veik" +
    "la";
            // 
            // text_salintiA
            // 
            this.text_salintiA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.text_salintiA.Location = new System.Drawing.Point(25, 330);
            this.text_salintiA.Name = "text_salintiA";
            this.text_salintiA.Size = new System.Drawing.Size(154, 20);
            this.text_salintiA.TabIndex = 14;
            this.text_salintiA.Visible = false;
            this.text_salintiA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_salintiA_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(80, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 48);
            this.label3.TabIndex = 0;
            this.label3.Text = "Šuns prižiūrėjimas\r\nsavininko namuose";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_pridetiA
            // 
            this.text_pridetiA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.text_pridetiA.Location = new System.Drawing.Point(25, 290);
            this.text_pridetiA.Name = "text_pridetiA";
            this.text_pridetiA.Size = new System.Drawing.Size(154, 20);
            this.text_pridetiA.TabIndex = 13;
            this.text_pridetiA.Visible = false;
            // 
            // button_salintiA
            // 
            this.button_salintiA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_salintiA.BackColor = System.Drawing.SystemColors.Control;
            this.button_salintiA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_salintiA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.button_salintiA.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_salintiA.Location = new System.Drawing.Point(211, 330);
            this.button_salintiA.Name = "button_salintiA";
            this.button_salintiA.Size = new System.Drawing.Size(82, 25);
            this.button_salintiA.TabIndex = 12;
            this.button_salintiA.Text = "Šalinti";
            this.button_salintiA.UseVisualStyleBackColor = false;
            this.button_salintiA.Visible = false;
            this.button_salintiA.Click += new System.EventHandler(this.button_salintiA_Click);
            // 
            // button_pridetiA
            // 
            this.button_pridetiA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_pridetiA.BackColor = System.Drawing.SystemColors.Control;
            this.button_pridetiA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_pridetiA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.button_pridetiA.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_pridetiA.Location = new System.Drawing.Point(211, 290);
            this.button_pridetiA.Name = "button_pridetiA";
            this.button_pridetiA.Size = new System.Drawing.Size(82, 25);
            this.button_pridetiA.TabIndex = 11;
            this.button_pridetiA.Text = "Pridėti";
            this.button_pridetiA.UseVisualStyleBackColor = false;
            this.button_pridetiA.Visible = false;
            this.button_pridetiA.Click += new System.EventHandler(this.button_pridetiA_Click);
            // 
            // panelPaslaugosUser
            // 
            this.panelPaslaugosUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelPaslaugosUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelPaslaugosUser.Controls.Add(this.label5);
            this.panelPaslaugosUser.Controls.Add(this.text_salinti);
            this.panelPaslaugosUser.Controls.Add(this.text_prideti);
            this.panelPaslaugosUser.Controls.Add(this.button_salinti);
            this.panelPaslaugosUser.Controls.Add(this.button_prideti);
            this.panelPaslaugosUser.Controls.Add(this.label2);
            this.panelPaslaugosUser.Controls.Add(this.label1);
            this.panelPaslaugosUser.Location = new System.Drawing.Point(50, 18);
            this.panelPaslaugosUser.Name = "panelPaslaugosUser";
            this.panelPaslaugosUser.Size = new System.Drawing.Size(320, 364);
            this.panelPaslaugosUser.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(36, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nurodykite ID kurį pašalinti";
            this.label5.Visible = false;
            // 
            // text_salinti
            // 
            this.text_salinti.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.text_salinti.Location = new System.Drawing.Point(39, 325);
            this.text_salinti.Name = "text_salinti";
            this.text_salinti.Size = new System.Drawing.Size(154, 20);
            this.text_salinti.TabIndex = 9;
            this.text_salinti.Visible = false;
            this.text_salinti.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_salinti_KeyPress);
            // 
            // text_prideti
            // 
            this.text_prideti.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.text_prideti.Location = new System.Drawing.Point(39, 285);
            this.text_prideti.Name = "text_prideti";
            this.text_prideti.Size = new System.Drawing.Size(154, 20);
            this.text_prideti.TabIndex = 8;
            this.text_prideti.Visible = false;
            // 
            // button_salinti
            // 
            this.button_salinti.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_salinti.BackColor = System.Drawing.SystemColors.Control;
            this.button_salinti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_salinti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.button_salinti.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_salinti.Location = new System.Drawing.Point(225, 325);
            this.button_salinti.Name = "button_salinti";
            this.button_salinti.Size = new System.Drawing.Size(82, 25);
            this.button_salinti.TabIndex = 7;
            this.button_salinti.Text = "Šalinti";
            this.button_salinti.UseVisualStyleBackColor = false;
            this.button_salinti.Visible = false;
            this.button_salinti.Click += new System.EventHandler(this.button_salinti_Click);
            // 
            // button_prideti
            // 
            this.button_prideti.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_prideti.BackColor = System.Drawing.SystemColors.Control;
            this.button_prideti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_prideti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.button_prideti.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_prideti.Location = new System.Drawing.Point(225, 285);
            this.button_prideti.Name = "button_prideti";
            this.button_prideti.Size = new System.Drawing.Size(82, 25);
            this.button_prideti.TabIndex = 6;
            this.button_prideti.Text = "Pridėti";
            this.button_prideti.UseVisualStyleBackColor = false;
            this.button_prideti.Visible = false;
            this.button_prideti.Click += new System.EventHandler(this.button_prideti_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.Location = new System.Drawing.Point(36, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 176);
            this.label2.TabIndex = 1;
            this.label2.Text = "Šuns prižiūrėjimas\r\n\r\nPavedžiojimas\r\n\r\nJeigu reikės ir paduodama valgyti\r\n\r\nUžsiė" +
    "mimas su šunimi\r\n\r\nŠuns iškrovimas protine veikla\r\n\r\nŠuns iškrovimas fizine veik" +
    "la";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(63, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Šuns prižiūrėjimas \r\nprižiūrėtojo namuose";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormPaslaugos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDesktop);
            this.Name = "FormPaslaugos";
            this.Text = "Paslaugos";
            this.Load += new System.EventHandler(this.FormPaslaugos_Load);
            this.panelDesktop.ResumeLayout(false);
            this.panelPaslaugosUser2.ResumeLayout(false);
            this.panelPaslaugosUser2.PerformLayout();
            this.panelPaslaugosUser.ResumeLayout(false);
            this.panelPaslaugosUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Button buttonPaslaugosDominaUser;
        private System.Windows.Forms.Panel panelPaslaugosUser2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_salintiA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_pridetiA;
        private System.Windows.Forms.Button button_salintiA;
        private System.Windows.Forms.Button button_pridetiA;
        private System.Windows.Forms.Panel panelPaslaugosUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_salinti;
        private System.Windows.Forms.TextBox text_prideti;
        private System.Windows.Forms.Button button_salinti;
        private System.Windows.Forms.Button button_prideti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}