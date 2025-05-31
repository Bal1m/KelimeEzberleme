namespace KelimeEzberleme
{
    partial class SoruFormu
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
            lblSoru = new Label();
            btnSecenek1 = new Button();
            btnSecenek2 = new Button();
            btnSecenek3 = new Button();
            btnSecenek4 = new Button();
            lblPuan = new Label();
            lblSoruNo = new Label();
            lblDogruYanlis = new Label();
            SuspendLayout();
            // 
            // lblSoru
            // 
            lblSoru.AccessibleDescription = "İngilizce kelimeler burada";
            lblSoru.AutoSize = true;
            lblSoru.Location = new Point(352, 50);
            lblSoru.Name = "lblSoru";
            lblSoru.Size = new Size(18, 20);
            lblSoru.TabIndex = 0;
            lblSoru.Text = "...";
            lblSoru.Click += lblSoru_Click;
            // 
            // btnSecenek1
            // 
            btnSecenek1.AccessibleDescription = "4 adet seçenek olacak";
            btnSecenek1.BackColor = Color.Lavender;
            btnSecenek1.Location = new Point(57, 116);
            btnSecenek1.Name = "btnSecenek1";
            btnSecenek1.Size = new Size(257, 66);
            btnSecenek1.TabIndex = 1;
            btnSecenek1.Text = "Seçenek 1";
            btnSecenek1.UseVisualStyleBackColor = false;
            btnSecenek1.Click += btnSecenek1_Click;
            // 
            // btnSecenek2
            // 
            btnSecenek2.BackColor = Color.Lavender;
            btnSecenek2.Location = new Point(57, 216);
            btnSecenek2.Name = "btnSecenek2";
            btnSecenek2.Size = new Size(257, 66);
            btnSecenek2.TabIndex = 2;
            btnSecenek2.Text = "Seçenek 2";
            btnSecenek2.UseVisualStyleBackColor = false;
            btnSecenek2.Click += btnSecenek2_Click;
            // 
            // btnSecenek3
            // 
            btnSecenek3.BackColor = Color.Lavender;
            btnSecenek3.Location = new Point(397, 116);
            btnSecenek3.Name = "btnSecenek3";
            btnSecenek3.Size = new Size(257, 66);
            btnSecenek3.TabIndex = 3;
            btnSecenek3.Text = "Seçenek 3";
            btnSecenek3.UseVisualStyleBackColor = false;
            btnSecenek3.Click += btnSecenek3_Click;
            // 
            // btnSecenek4
            // 
            btnSecenek4.BackColor = Color.Lavender;
            btnSecenek4.Location = new Point(397, 216);
            btnSecenek4.Name = "btnSecenek4";
            btnSecenek4.Size = new Size(257, 66);
            btnSecenek4.TabIndex = 4;
            btnSecenek4.Text = "Seçenek 4";
            btnSecenek4.UseVisualStyleBackColor = false;
            btnSecenek4.Click += btnSecenek4_Click;
            // 
            // lblPuan
            // 
            lblPuan.AutoSize = true;
            lblPuan.BackColor = Color.Lavender;
            lblPuan.Location = new Point(598, 34);
            lblPuan.Name = "lblPuan";
            lblPuan.Size = new Size(56, 20);
            lblPuan.TabIndex = 6;
            lblPuan.Text = "Puan: 0";
            lblPuan.Click += lblPuan_Click;
            // 
            // lblSoruNo
            // 
            lblSoruNo.AutoSize = true;
            lblSoruNo.BackColor = Color.Lavender;
            lblSoruNo.Location = new Point(57, 34);
            lblSoruNo.Name = "lblSoruNo";
            lblSoruNo.Size = new Size(69, 20);
            lblSoruNo.TabIndex = 7;
            lblSoruNo.Text = "Soru: 1/X";
            lblSoruNo.Click += lblSoruNo_Click;
            // 
            // lblDogruYanlis
            // 
            lblDogruYanlis.AutoSize = true;
            lblDogruYanlis.BackColor = Color.Lavender;
            lblDogruYanlis.Location = new Point(511, 34);
            lblDogruYanlis.Name = "lblDogruYanlis";
            lblDogruYanlis.Size = new Size(64, 20);
            lblDogruYanlis.TabIndex = 8;
            lblDogruYanlis.Text = "D:0 / Y:0";
            lblDogruYanlis.Click += lblDogruYanlis_Click;
            // 
            // SoruFormu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDogruYanlis);
            Controls.Add(lblSoruNo);
            Controls.Add(lblPuan);
            Controls.Add(btnSecenek4);
            Controls.Add(btnSecenek3);
            Controls.Add(btnSecenek2);
            Controls.Add(btnSecenek1);
            Controls.Add(lblSoru);
            Name = "SoruFormu";
            Text = "Form2";
            FormClosed += SoruFormu_FormClosed;
            Load += SoruFormu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSoru;
        private Button btnSecenek1;
        private Button btnSecenek2;
        private Button btnSecenek3;
        private Button btnSecenek4;
        private Label lblPuan;
        private Label lblSoruNo;
        private Label lblDogruYanlis;
    }
}