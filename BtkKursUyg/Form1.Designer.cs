namespace BtkKursUyg
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
            label2 = new Label();
            lbKurslar = new ListBox();
            btnKurslariListele = new Button();
            label1 = new Label();
            txtKursAd = new TextBox();
            label3 = new Label();
            dtKursTarih = new DateTimePicker();
            label4 = new Label();
            txtKursEgitmen = new TextBox();
            btnKursEkle = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(7, 33);
            label2.Name = "label2";
            label2.Size = new Size(135, 31);
            label2.TabIndex = 1;
            label2.Text = "Kurs Listesi";
            // 
            // lbKurslar
            // 
            lbKurslar.FormattingEnabled = true;
            lbKurslar.ItemHeight = 20;
            lbKurslar.Location = new Point(12, 63);
            lbKurslar.Name = "lbKurslar";
            lbKurslar.Size = new Size(399, 364);
            lbKurslar.TabIndex = 2;
            // 
            // btnKurslariListele
            // 
            btnKurslariListele.Location = new Point(12, 7);
            btnKurslariListele.Name = "btnKurslariListele";
            btnKurslariListele.Size = new Size(191, 30);
            btnKurslariListele.TabIndex = 3;
            btnKurslariListele.Text = "Kurs Listesini Getir";
            btnKurslariListele.UseVisualStyleBackColor = true;
            btnKurslariListele.Click += btnKurslariListele_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 444);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 4;
            label1.Text = "Kurs Adı";
            // 
            // txtKursAd
            // 
            txtKursAd.Location = new Point(88, 440);
            txtKursAd.Name = "txtKursAd";
            txtKursAd.Size = new Size(323, 27);
            txtKursAd.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 485);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 4;
            label3.Text = "Kurs Tarihi";
            // 
            // dtKursTarih
            // 
            dtKursTarih.Location = new Point(88, 480);
            dtKursTarih.Name = "dtKursTarih";
            dtKursTarih.Size = new Size(323, 27);
            dtKursTarih.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 523);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 4;
            label4.Text = "Eğitmen";
            // 
            // txtKursEgitmen
            // 
            txtKursEgitmen.Location = new Point(87, 522);
            txtKursEgitmen.Name = "txtKursEgitmen";
            txtKursEgitmen.Size = new Size(324, 27);
            txtKursEgitmen.TabIndex = 7;
            // 
            // btnKursEkle
            // 
            btnKursEkle.Location = new Point(232, 559);
            btnKursEkle.Name = "btnKursEkle";
            btnKursEkle.Size = new Size(179, 29);
            btnKursEkle.TabIndex = 8;
            btnKursEkle.Text = "Kurs Ekle";
            btnKursEkle.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 620);
            Controls.Add(btnKursEkle);
            Controls.Add(txtKursEgitmen);
            Controls.Add(dtKursTarih);
            Controls.Add(txtKursAd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnKurslariListele);
            Controls.Add(lbKurslar);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Shown += Form1_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ListBox lbKurslar;
        private Button btnKurslariListele;
        private Label label1;
        private TextBox txtKursAd;
        private Label label3;
        private DateTimePicker dtKursTarih;
        private Label label4;
        private TextBox txtKursEgitmen;
        private Button btnKursEkle;
    }
}
