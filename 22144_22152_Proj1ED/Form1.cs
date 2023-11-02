namespace _22144_22152_Proj1ED
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Arvore<Cidade> arvore;
        private void Form1_Load(object sender, EventArgs e)
        {
            if (ofdCidades.ShowDialog() == DialogResult.OK) // OpenFileDialog para escolher o arquivo de cidades
            {
                string path = ofdCidades.FileName; //caminho do arquivo escolhido
                arvore = new Arvore<Cidade>(); //cria a instância de uma arvore
                arvore.LerArquivoDeRegistros(path); //le os arquivos
                arvore.ExibirDados(arvore.Raiz, dgvCidades); //exibi os arquivos
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

        private void btnExibir_Click(object sender, EventArgs e)
        {

        }
    }
}