namespace KelimeEzberleme
{
    partial class AnaForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnYukle = new Button();
            btnBaslat = new Button();
            cmbSozlukler = new ComboBox();
            panel1 = new Panel();
            btnCikis = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnYukle
            // 
            btnYukle.BackColor = Color.Lavender;
            btnYukle.Location = new Point(33, 101);
            btnYukle.Name = "btnYukle";
            btnYukle.Size = new Size(142, 46);
            btnYukle.TabIndex = 1;
            btnYukle.Text = "Yükle";
            btnYukle.UseVisualStyleBackColor = false;
            btnYukle.Click += btnYukle_Click;
            // 
            // btnBaslat
            // 
            btnBaslat.BackColor = Color.Lavender;
            btnBaslat.Enabled = false;
            btnBaslat.Location = new Point(208, 101);
            btnBaslat.Name = "btnBaslat";
            btnBaslat.Size = new Size(144, 46);
            btnBaslat.TabIndex = 2;
            btnBaslat.Text = "Başlat";
            btnBaslat.UseVisualStyleBackColor = false;
            btnBaslat.Click += btnBaslat_Click;
            // 
            // cmbSozlukler
            // 
            cmbSozlukler.BackColor = Color.Lavender;
            cmbSozlukler.FormattingEnabled = true;
            cmbSozlukler.Location = new Point(33, 29);
            cmbSozlukler.Name = "cmbSozlukler";
            cmbSozlukler.Size = new Size(319, 28);
            cmbSozlukler.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Azure;
            panel1.Controls.Add(btnCikis);
            panel1.Controls.Add(cmbSozlukler);
            panel1.Controls.Add(btnBaslat);
            panel1.Controls.Add(btnYukle);
            panel1.Location = new Point(207, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(391, 219);
            panel1.TabIndex = 4;
            // 
            // btnCikis
            // 
            btnCikis.BackColor = Color.Lavender;
            btnCikis.Location = new Point(258, 178);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(94, 29);
            btnCikis.TabIndex = 5;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click_1;
            // 
            // AnaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "AnaForm";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnYukle;
        private Button btnBaslat;
        private ComboBox cmbSozlukler;
        private Panel panel1;
        private Button btnCikis;
    }
}
