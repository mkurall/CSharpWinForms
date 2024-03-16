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
            ((System.ComponentModel.ISupportInitialize)dgvOgrenciler).BeginInit();
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
            label2.Location = new Point(266, 45);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 4;
            label2.Text = "Öğrenciler";
            // 
            // dgvOgrenciler
            // 
            dgvOgrenciler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOgrenciler.Location = new Point(262, 68);
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
            btnOgrencileriGetir.Location = new Point(362, 36);
            btnOgrencileriGetir.Name = "btnOgrencileriGetir";
            btnOgrencileriGetir.Size = new Size(130, 29);
            btnOgrencileriGetir.TabIndex = 6;
            btnOgrencileriGetir.Text = "Öğrencileri Getir";
            btnOgrencileriGetir.UseVisualStyleBackColor = true;
            btnOgrencileriGetir.Click += btnOgrencileriGetir_Click;
            // 
            // txtNu
            // 
            txtNu.Location = new Point(262, 422);
            txtNu.Name = "txtNu";
            txtNu.Size = new Size(125, 27);
            txtNu.TabIndex = 2;
            // 
            // btnOgrenciEkle
            // 
            btnOgrenciEkle.Location = new Point(680, 464);
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
            label3.Location = new Point(270, 399);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 7;
            label3.Text = "Numara";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(423, 422);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(164, 27);
            txtAd.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(431, 399);
            label4.Name = "label4";
            label4.Size = new Size(28, 20);
            label4.TabIndex = 7;
            label4.Text = "Ad";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(601, 422);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(173, 27);
            txtSoyad.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(601, 399);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 7;
            label5.Text = "Soyad";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 599);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
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
    }
}
