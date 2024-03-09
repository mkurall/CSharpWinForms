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
            SuspendLayout();
            // 
            // ucPasswordInput1
            // 
            ucPasswordInput1.BackColor = Color.Red;
            ucPasswordInput1.Location = new Point(484, 34);
            ucPasswordInput1.Name = "ucPasswordInput1";
            ucPasswordInput1.Padding = new Padding(1);
            ucPasswordInput1.Size = new Size(263, 38);
            ucPasswordInput1.TabIndex = 0;
            // 
            // ucPasswordInput2
            // 
            ucPasswordInput2.BackColor = Color.Red;
            ucPasswordInput2.Location = new Point(56, 182);
            ucPasswordInput2.Name = "ucPasswordInput2";
            ucPasswordInput2.Padding = new Padding(1);
            ucPasswordInput2.Size = new Size(349, 38);
            ucPasswordInput2.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ucPasswordInput2);
            Controls.Add(ucPasswordInput1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ucPasswordInput ucPasswordInput1;
        private ucPasswordInput ucPasswordInput2;
    }
}
