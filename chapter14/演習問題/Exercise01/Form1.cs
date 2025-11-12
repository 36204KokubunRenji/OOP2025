namespace Exercise01 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            using (OpenFileDialog filetext = new OpenFileDialog()) {
                filetext.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (filetext.ShowDialog() == DialogResult.OK) {
                    string FilePath = filetext.FileName;
                    try {
                        txtContent.Text = "ì«Ç›çûÇ›íÜ...";
                        string content = await ReadFileAsync(filePath);
                        txtContent.Text = content;

                    }
                }
            }
        }
    }
}
