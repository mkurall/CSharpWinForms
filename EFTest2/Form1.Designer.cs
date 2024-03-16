namespace EFTest2
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
            label1 = new Label();
            cbSiniflar = new ComboBox();
            txtSinif = new TextBox();
            btnEkle = new Button();
            label2 = new Label();
            dgvOgrenciler = new DataGridView();
            btnSiniflariGetir = new Button();
            btnOgrencileriGetir = new Button();
            txtNu = new TextBox();
            btnOgrenciEkle = new Button();
            label3 = new Label();
            txtAd = new TextBox();
            label4 = new Label();
            txtSoyad = new TextBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            btnKlupEkle = new Button();
            txtKlupAdi = new TextBox();
            label6 = new Label();
            cbKlupler = new ComboBox();
            label7 = new Label();
            btnKlupleriGetir = new Button();
            button1 = new Button();
            btnKlubeEkle = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOgrenciler).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 46);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 0;
            label1.Text = "Sınıf";
            // 
            // cbSiniflar
            // 
            cbSiniflar.FormattingEnabled = true;
            cbSiniflar.Location = new Point(18, 77);
            cbSiniflar.Name = "cbSiniflar";
            cbSiniflar.Size = new Size(173, 28);
            cbSiniflar.TabIndex = 1;
            // 
            // txtSinif
            // 
            txtSinif.Location = new Point(18, 128);
            txtSinif.Name = "txtSinif";
            txtSinif.Size = new Size(173, 27);
            txtSinif.TabIndex = 2;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(97, 161);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 29);
            btnEkle.TabIndex = 3;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(489, 33);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 4;
            label2.Text = "Öğrenciler";
            // 
            // dgvOgrenciler
            // 
            dgvOgrenciler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOgrenciler.Location = new Point(485, 56);
            dgvOgrenciler.Name = "dgvOgrenciler";
            dgvOgrenciler.RowHeadersWidth = 51;
            dgvOgrenciler.RowTemplate.Height = 29;
            dgvOgrenciler.Size = new Size(526, 315);
            dgvOgrenciler.TabIndex = 5;
            // 
            // btnSiniflariGetir
            // 
            btnSiniflariGetir.Location = new Point(56, 41);
            btnSiniflariGetir.Name = "btnSiniflariGetir";
            btnSiniflariGetir.Size = new Size(130, 29);
            btnSiniflariGetir.TabIndex = 6;
            btnSiniflariGetir.Text = "Sınıfları Getir";
            btnSiniflariGetir.UseVisualStyleBackColor = true;
            btnSiniflariGetir.Click += btnSiniflariGetir_Click;
            // 
            // btnOgrencileriGetir
            // 
            btnOgrencileriGetir.Location = new Point(275, 110);
            btnOgrencileriGetir.Name = "btnOgrencileriGetir";
            btnOgrencileriGetir.Size = new Size(176, 29);
            btnOgrencileriGetir.TabIndex = 6;
            btnOgrencileriGetir.Text = "Öğrencileri Getir  >>";
            btnOgrencileriGetir.UseVisualStyleBackColor = true;
            btnOgrencileriGetir.Click += btnOgrencileriGetir_Click;
            // 
            // txtNu
            // 
            txtNu.Location = new Point(485, 410);
            txtNu.Name = "txtNu";
            txtNu.Size = new Size(125, 27);
            txtNu.TabIndex = 2;
            // 
            // btnOgrenciEkle
            // 
            btnOgrenciEkle.Location = new Point(903, 452);
            btnOgrenciEkle.Name = "btnOgrenciEkle";
            btnOgrenciEkle.Size = new Size(94, 29);
            btnOgrenciEkle.TabIndex = 3;
            btnOgrenciEkle.Text = "Ekle";
            btnOgrenciEkle.UseVisualStyleBackColor = true;
            btnOgrenciEkle.Click += btnOgrenciEkle_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(493, 387);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 7;
            label3.Text = "Numara";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(646, 410);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(164, 27);
            txtAd.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(654, 387);
            label4.Name = "label4";
            label4.Size = new Size(28, 20);
            label4.TabIndex = 7;
            label4.Text = "Ad";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(824, 410);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(173, 27);
            txtSoyad.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(824, 387);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 7;
            label5.Text = "Soyad";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnKlupEkle);
            groupBox1.Controls.Add(txtKlupAdi);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cbKlupler);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnKlupleriGetir);
            groupBox1.Location = new Point(12, 232);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(244, 262);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Klüp İşlemleri";
            // 
            // btnKlupEkle
            // 
            btnKlupEkle.Location = new Point(150, 180);
            btnKlupEkle.Name = "btnKlupEkle";
            btnKlupEkle.Size = new Size(94, 29);
            btnKlupEkle.TabIndex = 2;
            btnKlupEkle.Text = "Klüp Ekle";
            btnKlupEkle.UseVisualStyleBackColor = true;
            btnKlupEkle.Click += btnKlupEkle_Click;
            // 
            // txtKlupAdi
            // 
            txtKlupAdi.Location = new Point(21, 147);
            txtKlupAdi.Name = "txtKlupAdi";
            txtKlupAdi.Size = new Size(223, 27);
            txtKlupAdi.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 119);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 0;
            label6.Text = "Klüp Adı";
            // 
            // cbKlupler
            // 
            cbKlupler.FormattingEnabled = true;
            cbKlupler.Location = new Point(29, 64);
            cbKlupler.Name = "cbKlupler";
            cbKlupler.Size = new Size(173, 28);
            cbKlupler.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 32);
            label7.Name = "label7";
            label7.Size = new Size(56, 20);
            label7.TabIndex = 0;
            label7.Text = "Klüpler";
            // 
            // btnKlupleriGetir
            // 
            btnKlupleriGetir.Location = new Point(91, 28);
            btnKlupleriGetir.Name = "btnKlupleriGetir";
            btnKlupleriGetir.Size = new Size(106, 29);
            btnKlupleriGetir.TabIndex = 6;
            btnKlupleriGetir.Text = "Klüpleri Getir";
            btnKlupleriGetir.UseVisualStyleBackColor = true;
            btnKlupleriGetir.Click += btnKlupleriGetir_Click;
            // 
            // button1
            // 
            button1.Location = new Point(273, 255);
            button1.Name = "button1";
            button1.Size = new Size(206, 29);
            button1.TabIndex = 6;
            button1.Text = "Klübün Öğrencileri Getir >>";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnKlubeEkle
            // 
            btnKlubeEkle.Location = new Point(275, 295);
            btnKlubeEkle.Name = "btnKlubeEkle";
            btnKlubeEkle.Size = new Size(176, 29);
            btnKlubeEkle.TabIndex = 9;
            btnKlubeEkle.Text = "<< Klübe Ekle";
            btnKlubeEkle.UseVisualStyleBackColor = true;
            btnKlubeEkle.Click += btnKlubeEkle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 599);
            Controls.Add(btnKlubeEkle);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(btnOgrencileriGetir);
            Controls.Add(btnSiniflariGetir);
            Controls.Add(dgvOgrenciler);
            Controls.Add(label2);
            Controls.Add(btnOgrenciEkle);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(txtNu);
            Controls.Add(btnEkle);
            Controls.Add(txtSinif);
            Controls.Add(cbSiniflar);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvOgrenciler).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbSiniflar;
        private TextBox txtSinif;
        private Button btnEkle;
        private Label label2;
        private DataGridView dgvOgrenciler;
        private Button btnSiniflariGetir;
        private Button btnOgrencileriGetir;
        private TextBox txtNu;
        private Button btnOgrenciEkle;
        private Label label3;
        private TextBox txtAd;
        private Label label4;
        private TextBox txtSoyad;
        private Label label5;
        private GroupBox groupBox1;
        private Button btnKlupEkle;
        private TextBox txtKlupAdi;
        private Label label6;
        private ComboBox cbKlupler;
        private Label label7;
        private Button btnKlupleriGetir;
        private Button button1;
        private Button btnKlubeEkle;
    }
}
