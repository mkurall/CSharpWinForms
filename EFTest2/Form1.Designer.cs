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
            // 
            // btnOgrencileriGetir
            // 
            btnOgrencileriGetir.Location = new Point(362, 36);
            btnOgrencileriGetir.Name = "btnOgrencileriGetir";
            btnOgrencileriGetir.Size = new Size(130, 29);
            btnOgrencileriGetir.TabIndex = 6;
            btnOgrencileriGetir.Text = "Öğrencileri Getir";
            btnOgrencileriGetir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 599);
            Controls.Add(btnOgrencileriGetir);
            Controls.Add(btnSiniflariGetir);
            Controls.Add(dgvOgrenciler);
            Controls.Add(label2);
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
    }
}
