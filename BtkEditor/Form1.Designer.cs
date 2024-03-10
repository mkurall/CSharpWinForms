namespace BtkEditor
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            dosyaToolStripMenuItem = new ToolStripMenuItem();
            klasörAçToolStripMenuItem = new ToolStripMenuItem();
            dosyaAçToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            kaydetToolStripMenuItem = new ToolStripMenuItem();
            tümünüKaydetToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            çıkışToolStripMenuItem = new ToolStripMenuItem();
            düzenToolStripMenuItem = new ToolStripMenuItem();
            kesToolStripMenuItem = new ToolStripMenuItem();
            kopyalaToolStripMenuItem = new ToolStripMenuItem();
            yapıştırToolStripMenuItem = new ToolStripMenuItem();
            yardımToolStripMenuItem = new ToolStripMenuItem();
            programHakkındaToolStripMenuItem = new ToolStripMenuItem();
            splitContainer1 = new SplitContainer();
            tvDosyaAgaci = new TreeView();
            toolStrip1 = new ToolStrip();
            tsbKlasorAc = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            label1 = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            ımageList1 = new ImageList(components);
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dosyaToolStripMenuItem, düzenToolStripMenuItem, yardımToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            dosyaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { klasörAçToolStripMenuItem, dosyaAçToolStripMenuItem, toolStripMenuItem1, kaydetToolStripMenuItem, tümünüKaydetToolStripMenuItem, toolStripMenuItem2, çıkışToolStripMenuItem });
            dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            dosyaToolStripMenuItem.Size = new Size(64, 24);
            dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // klasörAçToolStripMenuItem
            // 
            klasörAçToolStripMenuItem.Name = "klasörAçToolStripMenuItem";
            klasörAçToolStripMenuItem.Size = new Size(195, 26);
            klasörAçToolStripMenuItem.Text = "Klasör Aç";
            // 
            // dosyaAçToolStripMenuItem
            // 
            dosyaAçToolStripMenuItem.Name = "dosyaAçToolStripMenuItem";
            dosyaAçToolStripMenuItem.Size = new Size(195, 26);
            dosyaAçToolStripMenuItem.Text = "Dosya Aç";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(192, 6);
            // 
            // kaydetToolStripMenuItem
            // 
            kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            kaydetToolStripMenuItem.Size = new Size(195, 26);
            kaydetToolStripMenuItem.Text = "Kaydet";
            // 
            // tümünüKaydetToolStripMenuItem
            // 
            tümünüKaydetToolStripMenuItem.Name = "tümünüKaydetToolStripMenuItem";
            tümünüKaydetToolStripMenuItem.Size = new Size(195, 26);
            tümünüKaydetToolStripMenuItem.Text = "Tümünü Kaydet";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(192, 6);
            // 
            // çıkışToolStripMenuItem
            // 
            çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            çıkışToolStripMenuItem.Size = new Size(195, 26);
            çıkışToolStripMenuItem.Text = "Çıkış";
            // 
            // düzenToolStripMenuItem
            // 
            düzenToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kesToolStripMenuItem, kopyalaToolStripMenuItem, yapıştırToolStripMenuItem });
            düzenToolStripMenuItem.Name = "düzenToolStripMenuItem";
            düzenToolStripMenuItem.Size = new Size(65, 24);
            düzenToolStripMenuItem.Text = "Düzen";
            // 
            // kesToolStripMenuItem
            // 
            kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            kesToolStripMenuItem.Size = new Size(146, 26);
            kesToolStripMenuItem.Text = "Kes";
            // 
            // kopyalaToolStripMenuItem
            // 
            kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            kopyalaToolStripMenuItem.Size = new Size(146, 26);
            kopyalaToolStripMenuItem.Text = "Kopyala";
            // 
            // yapıştırToolStripMenuItem
            // 
            yapıştırToolStripMenuItem.Name = "yapıştırToolStripMenuItem";
            yapıştırToolStripMenuItem.Size = new Size(146, 26);
            yapıştırToolStripMenuItem.Text = "Yapıştır";
            // 
            // yardımToolStripMenuItem
            // 
            yardımToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { programHakkındaToolStripMenuItem });
            yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            yardımToolStripMenuItem.Size = new Size(69, 24);
            yardımToolStripMenuItem.Text = "Yardım";
            // 
            // programHakkındaToolStripMenuItem
            // 
            programHakkındaToolStripMenuItem.Name = "programHakkındaToolStripMenuItem";
            programHakkındaToolStripMenuItem.Size = new Size(215, 26);
            programHakkındaToolStripMenuItem.Text = "Program Hakkında";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 28);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tvDosyaAgaci);
            splitContainer1.Panel1.Controls.Add(toolStrip1);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Size = new Size(800, 484);
            splitContainer1.SplitterDistance = 289;
            splitContainer1.TabIndex = 1;
            // 
            // tvDosyaAgaci
            // 
            tvDosyaAgaci.Dock = DockStyle.Fill;
            tvDosyaAgaci.ImageIndex = 0;
            tvDosyaAgaci.ImageList = ımageList1;
            tvDosyaAgaci.Location = new Point(0, 72);
            tvDosyaAgaci.Name = "tvDosyaAgaci";
            tvDosyaAgaci.SelectedImageIndex = 0;
            tvDosyaAgaci.Size = new Size(289, 412);
            tvDosyaAgaci.TabIndex = 2;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbKlasorAc, toolStripButton2, toolStripButton3, toolStripButton4 });
            toolStrip1.Location = new Point(0, 33);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(289, 39);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbKlasorAc
            // 
            tsbKlasorAc.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbKlasorAc.Image = (Image)resources.GetObject("tsbKlasorAc.Image");
            tsbKlasorAc.ImageTransparentColor = Color.Magenta;
            tsbKlasorAc.Name = "tsbKlasorAc";
            tsbKlasorAc.Size = new Size(36, 36);
            tsbKlasorAc.Text = "toolStripButton1";
            tsbKlasorAc.Click += tsbKlasorAc_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.Alignment = ToolStripItemAlignment.Right;
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(36, 36);
            toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            toolStripButton3.Alignment = ToolStripItemAlignment.Right;
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(36, 36);
            toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            toolStripButton4.Alignment = ToolStripItemAlignment.Right;
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(36, 36);
            toolStripButton4.Text = "toolStripButton4";
            // 
            // label1
            // 
            label1.BackColor = Color.Azure;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(289, 33);
            label1.TabIndex = 0;
            label1.Text = "DOSYA GEZGİNİ";
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth8Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "folder.png");
            ımageList1.Images.SetKeyName(1, "google-docs.png");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 512);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Btk Editör";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem dosyaToolStripMenuItem;
        private ToolStripMenuItem düzenToolStripMenuItem;
        private ToolStripMenuItem yardımToolStripMenuItem;
        private ToolStripMenuItem klasörAçToolStripMenuItem;
        private ToolStripMenuItem dosyaAçToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem kaydetToolStripMenuItem;
        private ToolStripMenuItem tümünüKaydetToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem çıkışToolStripMenuItem;
        private ToolStripMenuItem kesToolStripMenuItem;
        private ToolStripMenuItem kopyalaToolStripMenuItem;
        private ToolStripMenuItem yapıştırToolStripMenuItem;
        private ToolStripMenuItem programHakkındaToolStripMenuItem;
        private SplitContainer splitContainer1;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbKlasorAc;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private Label label1;
        private TreeView tvDosyaAgaci;
        private FolderBrowserDialog folderBrowserDialog1;
        private ImageList ımageList1;
    }
}
