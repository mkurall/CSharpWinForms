namespace PersonelTakip
{
    partial class frmAnaForm
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
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txtAd = new TextBox();
            label3 = new Label();
            txtSoyad = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtAdres = new TextBox();
            label6 = new Label();
            cbBirim = new ComboBox();
            label7 = new Label();
            dtIseGirisTarihi = new DateTimePicker();
            label8 = new Label();
            numCocukSayisi = new NumericUpDown();
            panel2 = new Panel();
            chkAskerlik = new CheckBox();
            chkYabanciDil = new CheckBox();
            panel3 = new Panel();
            label9 = new Label();
            rdISGEvet = new RadioButton();
            panel4 = new Panel();
            rdISGHayir = new RadioButton();
            panel5 = new Panel();
            rdUstaHayir = new RadioButton();
            rdUstaEvet = new RadioButton();
            label10 = new Label();
            label11 = new Label();
            lbPersoneller = new ListBox();
            btnYeni = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            btnKaydet = new Button();
            txtTel = new MaskedTextBox();
            lblPersonelSayisi = new Label();
            lblKayitBilgi = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCocukSayisi).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(887, 134);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(138, 28);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(581, 60);
            label1.TabIndex = 1;
            label1.Text = "Personel Takip Uygulaması";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.man;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(129, 134);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(33, 169);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(43, 32);
            label2.TabIndex = 1;
            label2.Text = "Ad";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(147, 169);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(290, 34);
            txtAd.TabIndex = 1;
            txtAd.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(29, 211);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(79, 32);
            label3.TabIndex = 1;
            label3.Text = "Soyad";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(147, 209);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(290, 34);
            txtSoyad.TabIndex = 2;
            txtSoyad.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(29, 252);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(93, 32);
            label4.TabIndex = 1;
            label4.Text = "Telefon";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(29, 293);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(74, 32);
            label5.TabIndex = 1;
            label5.Text = "Adres";
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(147, 291);
            txtAdres.Multiline = true;
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(290, 99);
            txtAdres.TabIndex = 4;
            txtAdres.TextChanged += textBox1_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(29, 418);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(75, 32);
            label6.TabIndex = 1;
            label6.Text = "Birimi";
            // 
            // cbBirim
            // 
            cbBirim.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBirim.FormattingEnabled = true;
            cbBirim.Items.AddRange(new object[] { "Yönetim", "İnsan Kaynakları", "Muhasebe", "Üretim" });
            cbBirim.Location = new Point(147, 418);
            cbBirim.Name = "cbBirim";
            cbBirim.Size = new Size(290, 36);
            cbBirim.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(30, 469);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(101, 32);
            label7.TabIndex = 1;
            label7.Text = "İşe G.Tar";
            // 
            // dtIseGirisTarihi
            // 
            dtIseGirisTarihi.Location = new Point(147, 469);
            dtIseGirisTarihi.Name = "dtIseGirisTarihi";
            dtIseGirisTarihi.Size = new Size(290, 34);
            dtIseGirisTarihi.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(33, 523);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(105, 32);
            label8.TabIndex = 1;
            label8.Text = "Çocuk S.";
            // 
            // numCocukSayisi
            // 
            numCocukSayisi.Location = new Point(146, 523);
            numCocukSayisi.Margin = new Padding(4);
            numCocukSayisi.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            numCocukSayisi.Name = "numCocukSayisi";
            numCocukSayisi.Size = new Size(291, 34);
            numCocukSayisi.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 128, 128);
            panel2.Location = new Point(18, 564);
            panel2.Name = "panel2";
            panel2.Size = new Size(459, 5);
            panel2.TabIndex = 6;
            // 
            // chkAskerlik
            // 
            chkAskerlik.AutoSize = true;
            chkAskerlik.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            chkAskerlik.Location = new Point(35, 582);
            chkAskerlik.Name = "chkAskerlik";
            chkAskerlik.Size = new Size(250, 36);
            chkAskerlik.TabIndex = 8;
            chkAskerlik.Text = "Askerliğini Yaptı Mı?";
            chkAskerlik.UseVisualStyleBackColor = true;
            // 
            // chkYabanciDil
            // 
            chkYabanciDil.AutoSize = true;
            chkYabanciDil.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            chkYabanciDil.Location = new Point(35, 620);
            chkYabanciDil.Name = "chkYabanciDil";
            chkYabanciDil.Size = new Size(244, 36);
            chkYabanciDil.TabIndex = 9;
            chkYabanciDil.Text = "Yabancı Dili Var Mı?";
            chkYabanciDil.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 128, 128);
            panel3.Location = new Point(18, 662);
            panel3.Name = "panel3";
            panel3.Size = new Size(459, 5);
            panel3.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(33, 690);
            label9.Name = "label9";
            label9.Size = new Size(316, 32);
            label9.TabIndex = 9;
            label9.Text = "ISG Eğitimini Tamamladı Mı?";
            // 
            // rdISGEvet
            // 
            rdISGEvet.AutoSize = true;
            rdISGEvet.Location = new Point(9, 6);
            rdISGEvet.Name = "rdISGEvet";
            rdISGEvet.Size = new Size(70, 32);
            rdISGEvet.TabIndex = 10;
            rdISGEvet.TabStop = true;
            rdISGEvet.Text = "Evet";
            rdISGEvet.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(rdISGHayir);
            panel4.Controls.Add(rdISGEvet);
            panel4.Location = new Point(299, 679);
            panel4.Name = "panel4";
            panel4.Size = new Size(185, 39);
            panel4.TabIndex = 11;
            // 
            // rdISGHayir
            // 
            rdISGHayir.AutoSize = true;
            rdISGHayir.Location = new Point(88, 6);
            rdISGHayir.Name = "rdISGHayir";
            rdISGHayir.Size = new Size(79, 32);
            rdISGHayir.TabIndex = 11;
            rdISGHayir.TabStop = true;
            rdISGHayir.Text = "Hayır";
            rdISGHayir.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(rdUstaHayir);
            panel5.Controls.Add(rdUstaEvet);
            panel5.Location = new Point(299, 723);
            panel5.Name = "panel5";
            panel5.Size = new Size(185, 39);
            panel5.TabIndex = 12;
            // 
            // rdUstaHayir
            // 
            rdUstaHayir.AutoSize = true;
            rdUstaHayir.Location = new Point(88, 6);
            rdUstaHayir.Name = "rdUstaHayir";
            rdUstaHayir.Size = new Size(79, 32);
            rdUstaHayir.TabIndex = 13;
            rdUstaHayir.TabStop = true;
            rdUstaHayir.Text = "Hayır";
            rdUstaHayir.UseVisualStyleBackColor = true;
            // 
            // rdUstaEvet
            // 
            rdUstaEvet.AutoSize = true;
            rdUstaEvet.Location = new Point(9, 6);
            rdUstaEvet.Name = "rdUstaEvet";
            rdUstaEvet.Size = new Size(70, 32);
            rdUstaEvet.TabIndex = 12;
            rdUstaEvet.TabStop = true;
            rdUstaEvet.Text = "Evet";
            rdUstaEvet.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(35, 733);
            label10.Name = "label10";
            label10.Size = new Size(253, 32);
            label10.TabIndex = 9;
            label10.Text = "Ustalık Belgesi Var Mı?";
            // 
            // label11
            // 
            label11.BackColor = Color.FromArgb(192, 192, 0);
            label11.Location = new Point(514, 170);
            label11.Name = "label11";
            label11.Size = new Size(361, 28);
            label11.TabIndex = 13;
            label11.Text = "PERSONEL LİSTESİ";
            // 
            // lbPersoneller
            // 
            lbPersoneller.FormattingEnabled = true;
            lbPersoneller.ItemHeight = 28;
            lbPersoneller.Location = new Point(514, 201);
            lbPersoneller.Name = "lbPersoneller";
            lbPersoneller.Size = new Size(361, 564);
            lbPersoneller.TabIndex = 18;
            lbPersoneller.SelectedIndexChanged += lbPersoneller_SelectedIndexChanged;
            // 
            // btnYeni
            // 
            btnYeni.BackColor = Color.FromArgb(0, 192, 0);
            btnYeni.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnYeni.FlatAppearance.BorderSize = 3;
            btnYeni.FlatStyle = FlatStyle.Flat;
            btnYeni.ForeColor = Color.White;
            btnYeni.Location = new Point(35, 823);
            btnYeni.Name = "btnYeni";
            btnYeni.Size = new Size(112, 56);
            btnYeni.TabIndex = 16;
            btnYeni.Text = "Yeni Kayıt";
            btnYeni.UseVisualStyleBackColor = false;
            btnYeni.Click += btnYeni_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.FromArgb(255, 128, 128);
            btnSil.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnSil.FlatAppearance.BorderSize = 3;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(244, 823);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(83, 56);
            btnSil.TabIndex = 17;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.DodgerBlue;
            btnGuncelle.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnGuncelle.FlatAppearance.BorderSize = 3;
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.ForeColor = Color.White;
            btnGuncelle.Location = new Point(333, 823);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(151, 56);
            btnGuncelle.TabIndex = 14;
            btnGuncelle.Text = "Ekle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.FromArgb(64, 64, 64);
            btnKaydet.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            btnKaydet.FlatAppearance.BorderSize = 3;
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.ForeColor = Color.White;
            btnKaydet.Location = new Point(724, 823);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(151, 56);
            btnKaydet.TabIndex = 15;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(146, 252);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(291, 34);
            txtTel.TabIndex = 3;
            // 
            // lblPersonelSayisi
            // 
            lblPersonelSayisi.AutoSize = true;
            lblPersonelSayisi.ForeColor = Color.Tomato;
            lblPersonelSayisi.Location = new Point(515, 770);
            lblPersonelSayisi.Name = "lblPersonelSayisi";
            lblPersonelSayisi.Size = new Size(101, 28);
            lblPersonelSayisi.TabIndex = 17;
            lblPersonelSayisi.Text = "0 Personel";
            // 
            // lblKayitBilgi
            // 
            lblKayitBilgi.AutoSize = true;
            lblKayitBilgi.ForeColor = Color.Tomato;
            lblKayitBilgi.Location = new Point(147, 141);
            lblKayitBilgi.Name = "lblKayitBilgi";
            lblKayitBilgi.Size = new Size(96, 28);
            lblKayitBilgi.TabIndex = 19;
            lblKayitBilgi.Text = "Yeni Kayıt";
            // 
            // frmAnaForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(887, 905);
            Controls.Add(lblKayitBilgi);
            Controls.Add(lblPersonelSayisi);
            Controls.Add(txtTel);
            Controls.Add(btnKaydet);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnYeni);
            Controls.Add(lbPersoneller);
            Controls.Add(label11);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(panel3);
            Controls.Add(chkYabanciDil);
            Controls.Add(chkAskerlik);
            Controls.Add(panel2);
            Controls.Add(numCocukSayisi);
            Controls.Add(dtIseGirisTarihi);
            Controls.Add(cbBirim);
            Controls.Add(txtAdres);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtSoyad);
            Controls.Add(label3);
            Controls.Add(txtAd);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 6, 4, 6);
            Name = "frmAnaForm";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCocukSayisi).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtAd;
        private Label label3;
        private TextBox txtSoyad;
        private Label label4;
        private Label label5;
        private TextBox txtAdres;
        private Label label6;
        private ComboBox cbBirim;
        private Label label7;
        private DateTimePicker dtIseGirisTarihi;
        private Label label8;
        private NumericUpDown numCocukSayisi;
        private Panel panel2;
        private CheckBox chkAskerlik;
        private CheckBox chkYabanciDil;
        private Panel panel3;
        private Label label9;
        private RadioButton rdISGEvet;
        private Panel panel4;
        private RadioButton rdISGHayir;
        private Panel panel5;
        private RadioButton rdUstaHayir;
        private RadioButton rdUstaEvet;
        private Label label10;
        private Label label11;
        private ListBox lbPersoneller;
        private Button btnYeni;
        private Button btnSil;
        private Button btnGuncelle;
        private Button btnKaydet;
        private MaskedTextBox txtTel;
        private Label lblPersonelSayisi;
        private Label lblKayitBilgi;
    }
}
