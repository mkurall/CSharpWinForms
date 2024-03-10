namespace BtkEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tsbKlasorAc_Click(object sender, EventArgs e)
        {
            DialogResult cevap = folderBrowserDialog1.ShowDialog();
            //Burada kullanýcýdan bir cevap bekler
            //Cevap gelene kadar bekler

            if(cevap == DialogResult.OK)
            {
                string secilenKlasor = folderBrowserDialog1.SelectedPath;
                
                OpenFolder(secilenKlasor);
            }
        }

        void OpenFolder(string path)
        {
            string klasorAdi = Path.GetFileName(path);
            TreeNode node = tvDosyaAgaci.Nodes.Add("", klasorAdi, 0, 0);

            OpenSubFolder(node, path);
        }

        void OpenSubFolder(TreeNode parent, string path)
        {
            string[] klasorler =  Directory.GetDirectories(path);
            string[] dosyalar = Directory.GetFiles(path);

            foreach(string s in klasorler)
            {
                string klasorAdi = Path.GetFileName(s);

                parent.Nodes.Add("", klasorAdi, 0,0);
            }

            foreach (string s in dosyalar)
            {
                string dosyaAdi = Path.GetFileName(s);

                parent.Nodes.Add("", dosyaAdi, 1, 1);
            }
        }
    }
}
