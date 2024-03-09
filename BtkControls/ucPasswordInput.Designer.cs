namespace BtkControls
{
    partial class ucPasswordInput
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPasswordInput));
            txtInput = new TextBox();
            btnShow = new Button();
            pnlMain = new Panel();
            pnlMain.SuspendLayout();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.BorderStyle = BorderStyle.None;
            txtInput.Dock = DockStyle.Fill;
            txtInput.Location = new Point(0, 0);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(427, 20);
            txtInput.TabIndex = 0;
            // 
            // btnShow
            // 
            btnShow.BackColor = Color.White;
            btnShow.BackgroundImage = (Image)resources.GetObject("btnShow.BackgroundImage");
            btnShow.BackgroundImageLayout = ImageLayout.Center;
            btnShow.Dock = DockStyle.Right;
            btnShow.FlatAppearance.BorderSize = 0;
            btnShow.FlatStyle = FlatStyle.Flat;
            btnShow.Location = new Point(427, 0);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(38, 212);
            btnShow.TabIndex = 1;
            btnShow.UseVisualStyleBackColor = false;
            btnShow.Click += btnShow_Click;
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.White;
            pnlMain.Controls.Add(txtInput);
            pnlMain.Controls.Add(btnShow);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(1, 1);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(465, 212);
            pnlMain.TabIndex = 2;
            // 
            // ucPasswordInput
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            Controls.Add(pnlMain);
            Name = "ucPasswordInput";
            Padding = new Padding(1);
            Size = new Size(467, 214);
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtInput;
        private Button btnShow;
        private Panel pnlMain;
    }
}
