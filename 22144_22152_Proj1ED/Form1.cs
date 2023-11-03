using System;
using System.IO;
using System.Text;

namespace _22144_22152_Proj1ED
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Arvore<Cidade> arvore; //arvore das cidades (exibida no dgvCidades)
        private Arvore<Cidade> arvoreAux; //arvore auxiliar (utilizada para incluir cidades)
        private Arvore<Cidade> arvoreCaminhos; //arvore dos caminhos (exibida no dgvGrafos)

        public bool ProcurarNome(string nome, out Cidade cidade)
        {
            NoArvore<Cidade> atual = arvore.Raiz;
            cidade = null;

            while (atual != null)
            {
                int compare = String.Compare(atual.Info.Nome.Trim(), nome.Trim(), StringComparison.Ordinal);
                if (compare == 0)
                {
                    cidade = atual.Info;
                    return true;
                }
                if (compare > 0)
                {
                    atual = atual.Esq;
                }
                else
                {
                    atual = atual.Dir;
                }
            }

            return false;
        }

        public void AddCaminho(string de, string para, int distancia, int tempo)
        {
            if (!ProcurarNome(de, out Cidade cidadeDe)) return;
            cidadeDe.Caminhos.InserirAposFim(new Caminho(de, para, distancia, tempo));
        }

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
                var origem = new FileStream(ofdCidades.FileName, FileMode.OpenOrCreate);
                var arquivo = new BinaryReader(origem);
                try
                {
                    // will read the file and add the paths to the cities
                    while (arquivo.BaseStream.Position < arquivo.BaseStream.Length)
                    {
                        string de = Encoding.UTF8.GetString(arquivo.ReadBytes(15));
                        string para = Encoding.UTF8.GetString(arquivo.ReadBytes(15));
                        int distancia = arquivo.ReadInt32();
                        int tempo = arquivo.ReadInt32();
                        AddCaminho(de, para, distancia, tempo);
                    }

                    dgvGrafos.Rows.Clear();
                    void Percorrer(NoArvore<Cidade> atual)
                    {
                        if (atual != null)
                        {
                            ListaSimples<Caminho> caminhos = atual.Info.Caminhos;
                            caminhos.IniciarPercursoSequencial();

                            while (caminhos.PodePercorrer())
                            {
                                dgvGrafos.Rows.Add(atual.Info.Nome, caminhos.Atual.Info.Para, caminhos.Atual.Info.Distancia, caminhos.Atual.Info.Tempo);
                            }

                            Percorrer(atual.Esq);
                            Percorrer(atual.Dir);
                        }
                    }
                    Percorrer(arvore.Raiz);

                    origem.Close();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(null, "Arquivo inválido!", "Erro");
                    origem.Close();
                }
            }
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


            //void Caminhos(NoArvore<Cidade> atual)
            //{
            //    if (atual != null)
            //    {
            //        ListaSimples<Caminho> caminhos = atual.Info.Caminhos;
            //        caminhos.IniciarPercursoSequencial();

            //        while (caminhos.PodePercorrer())
            //        {
            //            if (ProcurarNome(caminhos.Atual.Info.Para.Trim(), out Cidade cidadePara))
            //            {
            //                Pen pen = new Pen(Color.Black, 3);
            //                if (caminhos.Atual.Info.De == arvore.Raiz.Info?.Nome)
            //                {
            //                    pen = new Pen(Color.Green, 3);
            //                }
            //                e.Graphics.DrawLine(pen, (float)atual.Info.X * pictureBox2.Width, (float)atual.Info.Y * pictureBox2.Height, (float)cidadePara.X * pictureBox2.Width, (float)cidadePara.Y * pictureBox2.Height);
            //            }
            //        }

            //        Caminhos(atual.Esq);
            //        Caminhos(atual.Dir);
            //    }
            //}
            //Caminhos(arvore.Raiz);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            arvore.DesenharArvore(pictureBox1.Width / 2, 0, e.Graphics);
        }
    }
}