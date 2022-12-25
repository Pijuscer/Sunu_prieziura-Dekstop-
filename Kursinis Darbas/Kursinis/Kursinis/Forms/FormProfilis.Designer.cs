namespace Kursinis.Forms
{
    partial class FormProfilis
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
            this.alergija = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.svoris = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.amzius = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.veisle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.adresas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tel_nr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nedraugiskas = new System.Windows.Forms.CheckBox();
            this.draugiskas = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.vardas = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pavarde = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // alergija
            // 
            this.alergija.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.alergija.Location = new System.Drawing.Point(296, 264);
            this.alergija.Name = "alergija";
            this.alergija.Size = new System.Drawing.Size(288, 20);
            this.alergija.TabIndex = 46;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label11.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label11.Location = new System.Drawing.Point(344, 236);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(201, 16);
            this.label11.TabIndex = 45;
            this.label11.Text = "Ar yra alergiškas kam nors?";
            // 
            // svoris
            // 
            this.svoris.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.svoris.Location = new System.Drawing.Point(81, 418);
            this.svoris.Name = "svoris";
            this.svoris.Size = new System.Drawing.Size(133, 20);
            this.svoris.TabIndex = 44;
            this.svoris.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.svoris_KeyPress);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label10.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label10.Location = new System.Drawing.Point(95, 387);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 16);
            this.label10.TabIndex = 42;
            this.label10.Text = "Šuns svoris";
            // 
            // amzius
            // 
            this.amzius.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.amzius.Location = new System.Drawing.Point(81, 340);
            this.amzius.Name = "amzius";
            this.amzius.Size = new System.Drawing.Size(133, 20);
            this.amzius.TabIndex = 41;
            this.amzius.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amzius_KeyPress);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(286, 340);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(335, 16);
            this.label8.TabIndex = 40;
            this.label8.Text = "Ar draugiškas su žmonėmis ir su kitais šunimis?";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(95, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 16);
            this.label7.TabIndex = 39;
            this.label7.Text = "Šuns amžius";
            // 
            // button_save
            // 
            this.button_save.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.button_save.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_save.Location = new System.Drawing.Point(632, 366);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(120, 60);
            this.button_save.TabIndex = 38;
            this.button_save.Text = "Išsaugoti";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // veisle
            // 
            this.veisle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.veisle.Location = new System.Drawing.Point(81, 264);
            this.veisle.Name = "veisle";
            this.veisle.Size = new System.Drawing.Size(133, 20);
            this.veisle.TabIndex = 37;
            this.veisle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.veisle_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(101, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 36;
            this.label6.Text = "Šuns veislė";
            // 
            // adresas
            // 
            this.adresas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.adresas.Location = new System.Drawing.Point(589, 137);
            this.adresas.Name = "adresas";
            this.adresas.Size = new System.Drawing.Size(133, 20);
            this.adresas.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(611, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Adresas";
            // 
            // tel_nr
            // 
            this.tel_nr.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tel_nr.Location = new System.Drawing.Point(589, 61);
            this.tel_nr.Name = "tel_nr";
            this.tel_nr.Size = new System.Drawing.Size(133, 20);
            this.tel_nr.TabIndex = 31;
            this.tel_nr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tel_nr_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(586, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Telefono numeris";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(44, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 26);
            this.label1.TabIndex = 47;
            this.label1.Text = "Asmens duomenys";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(44, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 26);
            this.label2.TabIndex = 48;
            this.label2.Text = "Gyvūno duomenys";
            // 
            // nedraugiskas
            // 
            this.nedraugiskas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nedraugiskas.AutoSize = true;
            this.nedraugiskas.Location = new System.Drawing.Point(490, 409);
            this.nedraugiskas.Name = "nedraugiskas";
            this.nedraugiskas.Size = new System.Drawing.Size(15, 14);
            this.nedraugiskas.TabIndex = 50;
            this.nedraugiskas.UseVisualStyleBackColor = true;
            // 
            // draugiskas
            // 
            this.draugiskas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.draugiskas.AutoSize = true;
            this.draugiskas.Location = new System.Drawing.Point(490, 372);
            this.draugiskas.Name = "draugiskas";
            this.draugiskas.Size = new System.Drawing.Size(15, 14);
            this.draugiskas.TabIndex = 51;
            this.draugiskas.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(432, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 52;
            this.label5.Text = "Taip";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label9.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label9.Location = new System.Drawing.Point(432, 407);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 16);
            this.label9.TabIndex = 53;
            this.label9.Text = "Ne";
            // 
            // vardas
            // 
            this.vardas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.vardas.Location = new System.Drawing.Point(319, 61);
            this.vardas.Name = "vardas";
            this.vardas.Size = new System.Drawing.Size(133, 20);
            this.vardas.TabIndex = 55;
            this.vardas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vardas_KeyPress);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label12.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label12.Location = new System.Drawing.Point(354, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 16);
            this.label12.TabIndex = 54;
            this.label12.Text = "Vardas";
            // 
            // pavarde
            // 
            this.pavarde.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pavarde.Location = new System.Drawing.Point(319, 137);
            this.pavarde.Name = "pavarde";
            this.pavarde.Size = new System.Drawing.Size(133, 20);
            this.pavarde.TabIndex = 57;
            this.pavarde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pavarde_KeyPress);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label13.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label13.Location = new System.Drawing.Point(354, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 16);
            this.label13.TabIndex = 56;
            this.label13.Text = "Pavardė";
            // 
            // FormProfilis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pavarde);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.vardas);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.draugiskas);
            this.Controls.Add(this.nedraugiskas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.alergija);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.svoris);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.amzius);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.veisle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.adresas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tel_nr);
            this.Controls.Add(this.label3);
            this.Name = "FormProfilis";
            this.Text = "Profilis";
            this.Load += new System.EventHandler(this.FormProfilis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox alergija;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox svoris;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox amzius;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.TextBox veisle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox adresas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tel_nr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox nedraugiskas;
        private System.Windows.Forms.CheckBox draugiskas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox vardas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox pavarde;
        private System.Windows.Forms.Label label13;
    }
}