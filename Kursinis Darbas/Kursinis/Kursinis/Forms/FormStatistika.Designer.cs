namespace Kursinis.Forms
{
    partial class FormStatistika
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bar_atvykstant = new System.Windows.Forms.ProgressBar();
            this.bar_namuose = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(49, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(372, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Šunis prižiūrėtojas prižiūri savininko namuose";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(49, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Šunys prižiūrimi prižiūrėtojo namuose";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(127, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(557, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Statistika parodo kurią paslaugą vartotojai užsisako dažniau\r\n";
            // 
            // bar_atvykstant
            // 
            this.bar_atvykstant.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bar_atvykstant.Location = new System.Drawing.Point(445, 295);
            this.bar_atvykstant.Name = "bar_atvykstant";
            this.bar_atvykstant.Size = new System.Drawing.Size(285, 40);
            this.bar_atvykstant.Step = 1;
            this.bar_atvykstant.TabIndex = 6;
            this.bar_atvykstant.Value = 30;
            // 
            // bar_namuose
            // 
            this.bar_namuose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bar_namuose.Location = new System.Drawing.Point(445, 155);
            this.bar_namuose.Name = "bar_namuose";
            this.bar_namuose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bar_namuose.Size = new System.Drawing.Size(280, 40);
            this.bar_namuose.Step = 1;
            this.bar_namuose.TabIndex = 10;
            this.bar_namuose.Value = 80;
            // 
            // FormStatistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bar_atvykstant);
            this.Controls.Add(this.bar_namuose);
            this.Name = "FormStatistika";
            this.Text = "Statistika";
            this.Load += new System.EventHandler(this.FormStatistika_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar bar_atvykstant;
        private System.Windows.Forms.ProgressBar bar_namuose;
    }
}