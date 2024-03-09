namespace BtkControls
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
            ucPasswordInput1 = new ucPasswordInput();
            ucPasswordInput2 = new ucPasswordInput();
            ıosStyleCheck1 = new IOSStyleCheck();
            label1 = new Label();
            ıosStyleCheck2 = new IOSStyleCheck();
            label2 = new Label();
            SuspendLayout();
            // 
            // ucPasswordInput1
            // 
            ucPasswordInput1.BackColor = Color.Red;
            ucPasswordInput1.Location = new Point(26, 24);
            ucPasswordInput1.Name = "ucPasswordInput1";
            ucPasswordInput1.Padding = new Padding(1);
            ucPasswordInput1.PasswordIsShowing = false;
            ucPasswordInput1.Size = new Size(263, 38);
            ucPasswordInput1.TabIndex = 0;
            // 
            // ucPasswordInput2
            // 
            ucPasswordInput2.BackColor = Color.Red;
            ucPasswordInput2.Location = new Point(26, 80);
            ucPasswordInput2.Name = "ucPasswordInput2";
            ucPasswordInput2.Padding = new Padding(1);
            ucPasswordInput2.PasswordIsShowing = false;
            ucPasswordInput2.Size = new Size(263, 38);
            ucPasswordInput2.TabIndex = 1;
            // 
            // ıosStyleCheck1
            // 
            ıosStyleCheck1.CausesValidation = false;
            ıosStyleCheck1.Checked = false;
            ıosStyleCheck1.Location = new Point(458, 56);
            ıosStyleCheck1.Name = "ıosStyleCheck1";
            ıosStyleCheck1.Size = new Size(73, 36);
            ıosStyleCheck1.TabIndex = 2;
            ıosStyleCheck1.Text = "ıosStyleCheck1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(546, 67);
            label1.Name = "label1";
            label1.Size = new Size(142, 20);
            label1.TabIndex = 3;
            label1.Text = "Çıkışta ayarları sakla";
            // 
            // ıosStyleCheck2
            // 
            ıosStyleCheck2.CausesValidation = false;
            ıosStyleCheck2.Checked = false;
            ıosStyleCheck2.Location = new Point(458, 102);
            ıosStyleCheck2.Name = "ıosStyleCheck2";
            ıosStyleCheck2.Size = new Size(73, 36);
            ıosStyleCheck2.TabIndex = 2;
            ıosStyleCheck2.Text = "ıosStyleCheck1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(546, 113);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 3;
            label2.Text = "Gece modu açık";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(ıosStyleCheck2);
            Controls.Add(label1);
            Controls.Add(ıosStyleCheck1);
            Controls.Add(ucPasswordInput2);
            Controls.Add(ucPasswordInput1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ucPasswordInput ucPasswordInput1;
        private ucPasswordInput ucPasswordInput2;
        private IOSStyleCheck ıosStyleCheck1;
        private Label label1;
        private IOSStyleCheck ıosStyleCheck2;
        private Label label2;
    }
}
