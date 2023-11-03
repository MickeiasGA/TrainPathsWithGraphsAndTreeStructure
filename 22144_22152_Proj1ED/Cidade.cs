using System;
using System.IO;
using System.Text;

namespace _22144_22152_Proj1ED
{
    public class Cidade : IComparable<Cidade>, IRegistroArvore
    {
        private ListaSimples<Caminho> caminhos = new ListaSimples<Caminho>();

        const int tamNome = 15,
                  tamX = 6,
                  tamY = 6;

        const int iniNome = 0,
                  iniX = iniNome + tamNome,
                  iniY = iniX + tamX;

        string nome;
        double x, y;

        public string Nome { get => nome; set => nome = value.PadRight(15).Substring(0, 15); }
        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public int TamanhoRegistro //implementado para a interface IRegistroArvore
        {
            get
            {
                return 31; //15 + (sizeof(double)*2)
            }
        }
        public ListaSimples<Caminho> Caminhos
        {
            get => caminhos;
            set => caminhos = value;
        }

        public Cidade(string nome, int x, int y)
        {
            Nome = nome;
            X = x;
            Y = y;
        }

        public Cidade() //construtor vazio
        {
            Nome = "Exemplo";
            X = 0;
            Y = 0;
        }

        public int CompareTo(Cidade other) //modificado
        {
            int nomeComparison = string.Compare(nome, other.nome, StringComparison.Ordinal); //compara os nomes
            if (nomeComparison != 0) return nomeComparison;
            int xComparison = x.CompareTo(other.x); //compara as coordenadas X
            if (xComparison != 0) return xComparison;
            return y.CompareTo(other.y); //compara as coordenadas Y
        }

        public void LerRegistro(BinaryReader arquivo, long qualRegistro)
        {
            if (arquivo != null) // arquivo aberto?
            {
                Nome = System.Text.Encoding.UTF8.GetString(arquivo.ReadBytes(15)); //le os primeiros 15 bytes do arquivo e converte para uma string usando UTF-8.
                X = arquivo.ReadDouble(); //le o double a seguir do nome, que é a coordenada X
                Y = arquivo.ReadDouble(); //le o outro double, que é a coordenada Y
            }
        }

        public void GravarRegistro(BinaryWriter arq) //modificado
        {
            if (arq != null)  // arquivo de saída aberto?
            {
                arq.Write(Nome); //escreve o nome
                arq.Write(X); //escreve a coordenada X
                arq.Write(Y); //escreve a coordenada Y
            }
        }
        public string ParaArquivo()
        {
            return Nome + X.ToString() + Y.ToString();
        }

        public override string ToString()//modificado
        {
            return $"{Nome}0{X:N4}0{Y:N4}"; //formatado para escrever adequadamente de acordo com o número de bytes do arquivo 'cidades.dat'
        }
    }
}
