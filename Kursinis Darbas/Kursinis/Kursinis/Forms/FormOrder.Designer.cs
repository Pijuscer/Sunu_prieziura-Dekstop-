namespace Kursinis.Forms
{
    partial class FormOrder
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
            this.data = new System.Windows.Forms.DataGridView();
            this.kada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kaina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vardas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pavarde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veisle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amzius = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.svoris = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alergija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.draugiskas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // data
            // 
            this.data.AllowUserToAddRows = false;
            this.data.AllowUserToDeleteRows = false;
            this.data.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kada,
            this.kur,
            this.adresas,
            this.kaina,
            this.tel,
            this.vardas,
            this.pavarde,
            this.veisle,
            this.amzius,
            this.svoris,
            this.alergija,
            this.draugiskas});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data.DefaultCellStyle = dataGridViewCellStyle2;
            this.data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data.GridColor = System.Drawing.Color.Maroon;
            this.data.Location = new System.Drawing.Point(0, 0);
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.RowHeadersWidth = 40;
            this.data.RowTemplate.Height = 40;
            this.data.Size = new System.Drawing.Size(800, 450);
            this.data.TabIndex = 0;
            // 
            // kada
            // 
            this.kada.HeaderText = "Kada";
            this.kada.Name = "kada";
            this.kada.ReadOnly = true;
            this.kada.Width = 150;
            // 
            // kur
            // 
            this.kur.HeaderText = "Kur";
            this.kur.Name = "kur";
            this.kur.ReadOnly = true;
            this.kur.Width = 200;
            // 
            // adresas
            // 
            this.adresas.HeaderText = "Adresas";
            this.adresas.Name = "adresas";
            this.adresas.ReadOnly = true;
            this.adresas.Width = 300;
            // 
            // kaina
            // 
            this.kaina.HeaderText = "Kaina";
            this.kaina.Name = "kaina";
            this.kaina.ReadOnly = true;
            // 
            // tel
            // 
            this.tel.HeaderText = "Telefonas";
            this.tel.Name = "tel";
            this.tel.ReadOnly = true;
            this.tel.Width = 150;
            // 
            // vardas
            // 
            this.vardas.HeaderText = "Vardas";
            this.vardas.Name = "vardas";
            this.vardas.ReadOnly = true;
            // 
            // pavarde
            // 
            this.pavarde.HeaderText = "Pavardė";
            this.pavarde.Name = "pavarde";
            this.pavarde.ReadOnly = true;
            // 
            // veisle
            // 
            this.veisle.HeaderText = "Veislė";
            this.veisle.Name = "veisle";
            this.veisle.ReadOnly = true;
            // 
            // amzius
            // 
            this.amzius.HeaderText = "Amžius";
            this.amzius.Name = "amzius";
            this.amzius.ReadOnly = true;
            // 
            // svoris
            // 
            this.svoris.HeaderText = "Svoris";
            this.svoris.Name = "svoris";
            this.svoris.ReadOnly = true;
            this.svoris.Width = 80;
            // 
            // alergija
            // 
            this.alergija.HeaderText = "Alergija";
            this.alergija.Name = "alergija";
            this.alergija.ReadOnly = true;
            // 
            // draugiskas
            // 
            this.draugiskas.HeaderText = "Draugiškas";
            this.draugiskas.Name = "draugiskas";
            this.draugiskas.ReadOnly = true;
            this.draugiskas.Width = 130;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(184, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Neturite jokių atliktų užsakymų";
            this.label1.Visible = false;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data);
            this.Name = "FormOrder";
            this.Text = "Užsakymai";
            this.Load += new System.EventHandler(this.FormOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kada;
        private System.Windows.Forms.DataGridViewTextBoxColumn kur;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresas;
        private System.Windows.Forms.DataGridViewTextBoxColumn kaina;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn vardas;
        private System.Windows.Forms.DataGridViewTextBoxColumn pavarde;
        private System.Windows.Forms.DataGridViewTextBoxColumn veisle;
        private System.Windows.Forms.DataGridViewTextBoxColumn amzius;
        private System.Windows.Forms.DataGridViewTextBoxColumn svoris;
        private System.Windows.Forms.DataGridViewTextBoxColumn alergija;
        private System.Windows.Forms.DataGridViewTextBoxColumn draugiskas;
    }
}