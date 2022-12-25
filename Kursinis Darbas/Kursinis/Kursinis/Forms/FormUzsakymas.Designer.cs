namespace Kursinis.Forms
{
    partial class FormUzsakymas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonPaslaugasUzsisakytiAdmin = new System.Windows.Forms.Button();
            this.Atvykus = new System.Windows.Forms.CheckBox();
            this.Namuose = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menesis = new System.Windows.Forms.TextBox();
            this.diena = new System.Windows.Forms.TextBox();
            this.nuo = new System.Windows.Forms.TextBox();
            this.iki = new System.Windows.Forms.TextBox();
            this.data = new System.Windows.Forms.DataGridView();
            this.dd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.men = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laisvas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPaslaugasUzsisakytiAdmin
            // 
            this.buttonPaslaugasUzsisakytiAdmin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonPaslaugasUzsisakytiAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPaslaugasUzsisakytiAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonPaslaugasUzsisakytiAdmin.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonPaslaugasUzsisakytiAdmin.Location = new System.Drawing.Point(652, 375);
            this.buttonPaslaugasUzsisakytiAdmin.Name = "buttonPaslaugasUzsisakytiAdmin";
            this.buttonPaslaugasUzsisakytiAdmin.Size = new System.Drawing.Size(118, 52);
            this.buttonPaslaugasUzsisakytiAdmin.TabIndex = 18;
            this.buttonPaslaugasUzsisakytiAdmin.Text = "Užsisakyti";
            this.buttonPaslaugasUzsisakytiAdmin.UseVisualStyleBackColor = true;
            this.buttonPaslaugasUzsisakytiAdmin.Click += new System.EventHandler(this.buttonPaslaugasUzsisakytiAdmin_Click);
            // 
            // Atvykus
            // 
            this.Atvykus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Atvykus.AutoSize = true;
            this.Atvykus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Atvykus.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Atvykus.Location = new System.Drawing.Point(420, 375);
            this.Atvykus.Name = "Atvykus";
            this.Atvykus.Size = new System.Drawing.Size(160, 36);
            this.Atvykus.TabIndex = 17;
            this.Atvykus.Text = "Šuns prižiūrėjimas\r\nsavininko namuose";
            this.Atvykus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Atvykus.UseVisualStyleBackColor = true;
            // 
            // Namuose
            // 
            this.Namuose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Namuose.AutoSize = true;
            this.Namuose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Namuose.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Namuose.Location = new System.Drawing.Point(145, 375);
            this.Namuose.Name = "Namuose";
            this.Namuose.Size = new System.Drawing.Size(171, 36);
            this.Namuose.TabIndex = 16;
            this.Namuose.Text = "Šuns prižiūrėjimas \r\nprižiūrėtojo namuose";
            this.Namuose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Namuose.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(100, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(557, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Būtina pasirinkti kur šuo bus prižiūrimas, kitaip paslaugos užsisakyti negalėsite" +
    "";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(230, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Lentelėje pateikti laisvi laikai";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(100, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Mėnesis";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(244, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Diena";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(371, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Laikas nuo";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(545, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "Laikas iki";
            // 
            // menesis
            // 
            this.menesis.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menesis.Location = new System.Drawing.Point(100, 284);
            this.menesis.Name = "menesis";
            this.menesis.Size = new System.Drawing.Size(100, 20);
            this.menesis.TabIndex = 23;
            this.menesis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.menesis_KeyPress);
            // 
            // diena
            // 
            this.diena.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.diena.Location = new System.Drawing.Point(249, 284);
            this.diena.Name = "diena";
            this.diena.Size = new System.Drawing.Size(100, 20);
            this.diena.TabIndex = 24;
            this.diena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.diena_KeyPress);
            // 
            // nuo
            // 
            this.nuo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nuo.Location = new System.Drawing.Point(376, 284);
            this.nuo.Name = "nuo";
            this.nuo.Size = new System.Drawing.Size(100, 20);
            this.nuo.TabIndex = 25;
            this.nuo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nuo_KeyPress);
            // 
            // iki
            // 
            this.iki.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iki.Location = new System.Drawing.Point(550, 284);
            this.iki.Name = "iki";
            this.iki.Size = new System.Drawing.Size(100, 20);
            this.iki.TabIndex = 26;
            this.iki.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.iki_KeyPress);
            // 
            // data
            // 
            this.data.AllowUserToAddRows = false;
            this.data.AllowUserToDeleteRows = false;
            this.data.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.data.BackgroundColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dd,
            this.men,
            this.laisvas});
            this.data.Location = new System.Drawing.Point(157, 59);
            this.data.Name = "data";
            this.data.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.data.RowTemplate.Height = 40;
            this.data.Size = new System.Drawing.Size(445, 150);
            this.data.TabIndex = 36;
            // 
            // dd
            // 
            this.dd.HeaderText = "Diena";
            this.dd.Name = "dd";
            this.dd.ReadOnly = true;
            // 
            // men
            // 
            this.men.HeaderText = "Mėnesis";
            this.men.Name = "men";
            this.men.ReadOnly = true;
            // 
            // laisvas
            // 
            this.laisvas.HeaderText = "Laisvas";
            this.laisvas.Name = "laisvas";
            this.laisvas.ReadOnly = true;
            this.laisvas.Width = 200;
            // 
            // FormUzsakymas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.data);
            this.Controls.Add(this.iki);
            this.Controls.Add(this.nuo);
            this.Controls.Add(this.diena);
            this.Controls.Add(this.menesis);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonPaslaugasUzsisakytiAdmin);
            this.Controls.Add(this.Atvykus);
            this.Controls.Add(this.Namuose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "FormUzsakymas";
            this.Text = "FormUzsakymas";
            this.Load += new System.EventHandler(this.FormUzsakymas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPaslaugasUzsisakytiAdmin;
        private System.Windows.Forms.CheckBox Atvykus;
        private System.Windows.Forms.CheckBox Namuose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox menesis;
        private System.Windows.Forms.TextBox diena;
        private System.Windows.Forms.TextBox nuo;
        private System.Windows.Forms.TextBox iki;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.DataGridViewTextBoxColumn dd;
        private System.Windows.Forms.DataGridViewTextBoxColumn men;
        private System.Windows.Forms.DataGridViewTextBoxColumn laisvas;
    }
}