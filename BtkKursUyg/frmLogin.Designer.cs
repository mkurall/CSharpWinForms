namespace BtkKursUyg
{
    partial class frmLogin
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
            label1 = new Label();
            txtEPosta = new TextBox();
            label2 = new Label();
            txtParola = new TextBox();
            btnOturumAc = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 119);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(81, 31);
            label1.TabIndex = 0;
            label1.Text = "EPosta";
            // 
            // txtEPosta
            // 
            txtEPosta.Location = new Point(170, 116);
            txtEPosta.Margin = new Padding(5);
            txtEPosta.Name = "txtEPosta";
            txtEPosta.Size = new Size(314, 38);
            txtEPosta.TabIndex = 1;
            txtEPosta.Text = "mustafakural@outlook.com";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 167);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 31);
            label2.TabIndex = 0;
            label2.Text = "Parola";
            // 
            // txtParola
            // 
            txtParola.Location = new Point(170, 164);
            txtParola.Margin = new Padding(5);
            txtParola.Name = "txtParola";
            txtParola.Size = new Size(314, 38);
            txtParola.TabIndex = 1;
            txtParola.Text = "1234";
            // 
            // btnOturumAc
            // 
            btnOturumAc.Location = new Point(296, 218);
            btnOturumAc.Name = "btnOturumAc";
            btnOturumAc.Size = new Size(186, 66);
            btnOturumAc.TabIndex = 2;
            btnOturumAc.Text = "Oturum Aç";
            btnOturumAc.UseVisualStyleBackColor = true;
            btnOturumAc.Click += btnOturumAc_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(520, 74);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cyber_security;
            pictureBox1.Location = new Point(3, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.MediumSeaGreen;
            label3.Location = new Point(73, 5);
            label3.Name = "label3";
            label3.Size = new Size(324, 60);
            label3.TabIndex = 0;
            label3.Text = "Kullanıcı Girişi";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 308);
            Controls.Add(panel1);
            Controls.Add(btnOturumAc);
            Controls.Add(txtParola);
            Controls.Add(label2);
            Controls.Add(txtEPosta);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEPosta;
        private Label label2;
        private TextBox txtParola;
        private Button btnOturumAc;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label3;
    }
}