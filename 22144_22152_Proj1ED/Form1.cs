namespace _22144_22152_Proj1ED
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Arvore<Cidade> arvore; //arvore das cidades
        private Arvore<Cidade> arvoreCaminhos; //arvore dos caminhos
        private void Form1_Load(object sender, EventArgs e)
        //AO ABRIR O FOMULÁRIO, É NESCESSÁRIO ESCOLHER O ARQUIVO 'CIDADES.DAT' E DPS 'CAMINHOS.DAT'
        {
            //primeiro escolhe as cidades
            if (ofdCidades.ShowDialog() == DialogResult.OK) // OpenFileDialog para escolher o arquivo de cidades
            {
                string path = ofdCidades.FileName; //caminho do arquivo escolhido
                arvore = new Arvore<Cidade>(); //cria a instância de uma arvore
                arvore.LerArquivoDeRegistros(path); //le os arquivos
                arvore.ExibirDados(arvore.Raiz, dgvCidades); //exibi os arquivos
            }

            //depois escolhe os caminhos 
            if (ofdCidades.ShowDialog() == DialogResult.OK) // OpenFileDialog para escolher o arquivo de grafos
            { //mesmo procedimento de antes
                string path = ofdCidades.FileName;
                arvoreCaminhos = new Arvore<Cidade>();
                arvoreCaminhos.LerArquivoDeRegistros(path);
                arvoreCaminhos.ExibirDados(arvoreCaminhos.Raiz, dgvGrafos);
            }
        }

        private void Existe(string cidade)
        {

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e) //só exclui dps de exibir
        {
            if (!arvore.ApagarNo(cidadeSelecionada)) //verifica se a cidade foi encontrada
            {
                MessageBox.Show(null, "Cidade não encontrada", "Erro");
                return;
            }
            cidadeSelecionada = default(Cidade); //exclui a cidade
            MessageBox.Show(null, "Cidade deletada com sucesso", "Sucesso");
            pictureBox2.Refresh(); //atualiza a pictureBox

            dgvCidades.Rows.Clear(); //limpa o dataGridView
            arvore.ExibirDados(arvore.Raiz, dgvCidades); //atualiza os dados do dataGridView
            dgvCidades.Refresh(); //atualiza o dataGridView
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }
        private Cidade cidadeSelecionada; //variavel utilizada para o botão Exibir e Excluir
        private void btnExibir_Click(object sender, EventArgs e)
        {
            bool Percorrer(NoArvore<Cidade> atual) //método criado para percorrer toda arvore
            {
                if (atual == null) return false; //se não existir cidade não da pra exibir 
                if (atual.Info.Nome.Trim() == txtNome.Text) //se encontrou cidade
                {
                    cidadeSelecionada = atual.Info; //atribui a cidade procurada para variavel 'cidadeSelecionada'
                    return true;
                }
                return Percorrer(atual.Esq) || Percorrer(atual.Dir); //recursividade
            }
            if (!Percorrer(arvore.Raiz)) //verifica se foi ou não possível encontrar a cidade a ser exibida
            {
                MessageBox.Show(null, "Cidade não encontrada", "Erro");
                return;
            }
            pictureBox2.Refresh(); //atualiza o pictureBox, chamando o evento "Paint" que agora desenha a cidade selecionada em vermelho
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            void Percorrer(NoArvore<Cidade> atual) //Método que percorre recursivamente a arvore e desenha no pictureBox do mapa 
            {
                if (atual == null) return; //fim da recursão
                Color color = Color.Black;
                if (cidadeSelecionada?.Nome == atual.Info.Nome) color = Color.Red; //muda a cor da cidade escolhida para vermelho (botão exibir)
                Brush brush = new SolidBrush(color);
                e.Graphics.FillEllipse(brush, (float)(atual.Info.X * pictureBox2.Width) - 3, (float)(atual.Info.Y * pictureBox2.Height) - 3, 6, 6); //calculo para desenhar os pontos
                Percorrer(atual.Esq);
                Percorrer(atual.Dir);
                //recursividade
            }
            Percorrer(arvore.Raiz); //percorre a arvore a partir da raiz
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            arvore.DesenharArvore(pictureBox1.Width / 2, 0, e.Graphics);
        }
    }
}