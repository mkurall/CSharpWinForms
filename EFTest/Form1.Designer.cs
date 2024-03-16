namespace EFTest
{
    partial class Form1
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
            btnKurslariGetir = new Button();
            label1 = new Label();
            cbKurslar = new ComboBox();
            label2 = new Label();
            txtKursAd = new TextBox();
            btnEkle = new Button();
            btnKursGuncelle = new Button();
            btnKursSil = new Button();
            SuspendLayout();
            // 
            // btnKurslariGetir
            // 
            btnKurslariGetir.Location = new Point(126, 30);
            btnKurslariGetir.Name = "btnKurslariGetir";
            btnKurslariGetir.Size = new Size(168, 29);
            btnKurslariGetir.TabIndex = 5;
            btnKurslariGetir.Text = "Kursları Getir";
            btnKurslariGetir.UseVisualStyleBackColor = true;
            btnKurslariGetir.Click += btnKurslariGetir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 30);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 4;
            label1.Text = "Kurslar";
            // 
            // cbKurslar
            // 
            cbKurslar.FormattingEnabled = true;
            cbKurslar.Location = new Point(34, 62);
            cbKurslar.Name = "cbKurslar";
            cbKurslar.Size = new Size(260, 28);
            cbKurslar.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 104);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 6;
            label2.Text = "Kurs Adı";
            // 
            // txtKursAd
            // 
            txtKursAd.Location = new Point(34, 127);
            txtKursAd.Name = "txtKursAd";
            txtKursAd.Size = new Size(251, 27);
            txtKursAd.TabIndex = 7;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(176, 160);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(109, 29);
            btnEkle.TabIndex = 8;
            btnEkle.Text = "Kurs Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnKursGuncelle
            // 
            btnKursGuncelle.Location = new Point(117, 195);
            btnKursGuncelle.Name = "btnKursGuncelle";
            btnKursGuncelle.Size = new Size(168, 29);
            btnKursGuncelle.TabIndex = 9;
            btnKursGuncelle.Text = "Kursu Güncelle";
            btnKursGuncelle.UseVisualStyleBackColor = true;
            btnKursGuncelle.Click += btnKursGuncelle_Click;
            // 
            // btnKursSil
            // 
            btnKursSil.Location = new Point(155, 230);
            btnKursSil.Name = "btnKursSil";
            btnKursSil.Size = new Size(130, 29);
            btnKursSil.TabIndex = 10;
            btnKursSil.Text = "Kursu Sil";
            btnKursSil.UseVisualStyleBackColor = true;
            btnKursSil.Click += btnKursSil_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnKursSil);
            Controls.Add(btnKursGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(txtKursAd);
            Controls.Add(label2);
            Controls.Add(btnKurslariGetir);
            Controls.Add(label1);
            Controls.Add(cbKurslar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKurslariGetir;
        private Label label1;
        private ComboBox cbKurslar;
        private Label label2;
        private TextBox txtKursAd;
        private Button btnEkle;
        private Button btnKursGuncelle;
        private Button btnKursSil;
    }
}
