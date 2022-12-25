namespace Kursinis.Forms
{
    partial class FormLaisvumas
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
            this.menesis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.diena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nuo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.iki = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.isskyrus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.DataGridView();
            this.button_prideti = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.men = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laisvas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // menesis
            // 
            this.menesis.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.menesis.Location = new System.Drawing.Point(49, 287);
            this.menesis.Name = "menesis";
            this.menesis.Size = new System.Drawing.Size(100, 20);
            this.menesis.TabIndex = 25;
            this.menesis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.menesis_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(44, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "Mėnesis";
            // 
            // diena
            // 
            this.diena.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.diena.Location = new System.Drawing.Point(212, 287);
            this.diena.Name = "diena";
            this.diena.Size = new System.Drawing.Size(100, 20);
            this.diena.TabIndex = 27;
            this.diena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.diena_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(207, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Diena";
            // 
            // nuo
            // 
            this.nuo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nuo.Location = new System.Drawing.Point(374, 287);
            this.nuo.Name = "nuo";
            this.nuo.Size = new System.Drawing.Size(100, 20);
            this.nuo.TabIndex = 29;
            this.nuo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nuo_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(371, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nuo";
            // 
            // iki
            // 
            this.iki.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iki.Location = new System.Drawing.Point(555, 287);
            this.iki.Name = "iki";
            this.iki.Size = new System.Drawing.Size(100, 20);
            this.iki.TabIndex = 31;
            this.iki.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.iki_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(550, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 25);
            this.label3.TabIndex = 30;
            this.label3.Text = "Iki";
            // 
            // isskyrus
            // 
            this.isskyrus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.isskyrus.Location = new System.Drawing.Point(308, 388);
            this.isskyrus.Name = "isskyrus";
            this.isskyrus.Size = new System.Drawing.Size(100, 20);
            this.isskyrus.TabIndex = 33;
            this.isskyrus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.isskyrus_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(303, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 32;
            this.label5.Text = "Išskyrus";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(271, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 25);
            this.label6.TabIndex = 34;
            this.label6.Text = "Laisvumo grafikas";
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
            this.data.Location = new System.Drawing.Point(151, 55);
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
            this.data.Size = new System.Drawing.Size(448, 150);
            this.data.TabIndex = 35;
            this.data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellContentClick);
            // 
            // button_prideti
            // 
            this.button_prideti.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_prideti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_prideti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.button_prideti.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_prideti.Location = new System.Drawing.Point(574, 356);
            this.button_prideti.Name = "button_prideti";
            this.button_prideti.Size = new System.Drawing.Size(118, 52);
            this.button_prideti.TabIndex = 36;
            this.button_prideti.Text = "Pridėti";
            this.button_prideti.UseVisualStyleBackColor = true;
            this.button_prideti.Click += new System.EventHandler(this.button_prideti_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(305, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Pavizdys: 14 15 16";
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
            // FormLaisvumas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_prideti);
            this.Controls.Add(this.data);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.isskyrus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.iki);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nuo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.diena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menesis);
            this.Controls.Add(this.label4);
            this.Name = "FormLaisvumas";
            this.Text = "Laisvumo grafikas";
            this.Load += new System.EventHandler(this.FormLaisvumas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox menesis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox diena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nuo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox iki;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox isskyrus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Button button_prideti;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dd;
        private System.Windows.Forms.DataGridViewTextBoxColumn men;
        private System.Windows.Forms.DataGridViewTextBoxColumn laisvas;
    }
}