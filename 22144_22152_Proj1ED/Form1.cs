namespace _22144_22152_Proj1ED
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (ofdCidades.ShowDialog() == DialogResult.OK)
            {
                string path = ofdCidades.FileName;
                FileInfo file = new FileInfo(path);
                BinaryReader fReader = new BinaryReader(new FileStream(path, FileMode.OpenOrCreate));
                for(int i = 0; i < file.Length; i++)
                {
                    
                }
            }

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }
    }
}