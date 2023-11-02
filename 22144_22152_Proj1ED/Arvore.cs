using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;

public class Arvore<Dado>
    where Dado : IComparable<Dado>, IRegistroArvore, new()
{
    private NoArvore<Dado> raiz, atual, antecessor;

    public NoArvore<Dado> Raiz
    {
        get => raiz;
        set => raiz = value;
    }

    public NoArvore<Dado> Atual
    {
        get => atual;
        set => atual = value;
    }

    public NoArvore<Dado> Antecessor
    {
        get => antecessor;
        set => antecessor = value;
    }

    public Arvore()
    {
        raiz = atual = antecessor = null;
    }

    public void LerArquivoDeRegistros(string nomeArquivo)
    {
        raiz = null;
        Dado dado = new Dado();
        var origem = new FileStream(nomeArquivo, FileMode.OpenOrCreate);
        var arquivo = new BinaryReader(origem);
        int posicaoFinal = (int)origem.Length / dado.TamanhoRegistro - 1;
        Particionar(0, posicaoFinal, ref raiz);
        origem.Close();

        void Particionar(long inicio, long fim, ref NoArvore<Dado> atual)
        {
            if (inicio <= fim)
            {
                long meio = (inicio + fim) / 2; // registro do meio da partição sob leitura
                dado = new Dado(); // cria um objeto para armazenar os dados
                dado.LerRegistro(arquivo, meio); //
                atual = new NoArvore<Dado>(dado);
                var novoEsq = atual.Esq;
                Particionar(inicio, meio - 1, ref novoEsq); // Particiona à esquerda
                atual.Esq = novoEsq;
                var novoDir = atual.Dir;
                Particionar(meio + 1, fim, ref novoDir); // Particiona à direita
                atual.Dir = novoDir;
            }
        }
    }

    public void ExibirDados(NoArvore<Dado> no, DataGridView dgv)
    {
        if (no != null) //fim da recursão
        {
            // Exibe os dados do nó atual
            dgv.Rows.Add(no.Info.ToString().Substring(0, 15), no.Info.ToString().Substring(16, 6),
                no.Info.ToString().Substring(23, 6)); //nome, x, y

            ExibirDados(no.Esq, dgv); // chama ExibirDados para o nó da esquerda (recursividade)

            ExibirDados(no.Dir, dgv); // chama ExibirDados para o nó da direita (recursividade)
        }
    }

    public void GravarArquivoDeRegistros(string nomeArquivo)
    {
        var destino = new FileStream(nomeArquivo, FileMode.Create);
        var arquivo = new BinaryWriter(destino);
        GravarInOrdem(raiz);
        arquivo.Close();

        void GravarInOrdem(NoArvore<Dado> r)
        {
            if (r != null)
            {
                GravarInOrdem(r.Esq);
                r.Info.GravarRegistro(arquivo);
                GravarInOrdem(r.Dir);
            }
        }
    }

    public void DesenharArvore(int x, int y, Graphics g)
    {
        // DesenharArvore(true, raiz, x, y, 60, 1, 200, g);
        DrawTree( false, raiz, x, y, (float)Math.PI / 2, 0.7f, 90, true, g);
    }
    private void DrawTree(bool primeira, NoArvore<Dado> atual, int x, int y, float rot, float rotAdd, float size, bool esq, Graphics g) //criado para desenhar a arvore
    {
        if (atual == null) return;
        int x2 = (int)(x + Math.Cos(rot) * size);
        int y2 = (int)(y + Math.Sin(rot) * size);
        Pen pen = new Pen(Color.Black, 4);
        g.DrawLine(pen, x, y, x2, y2);
        SolidBrush brush = new SolidBrush(Color.Blue);
        g.FillEllipse(brush, x2 - 15, y2 - 15, 30, 30);

        DrawTree(false, atual.Esq, x2, y2, rot + rotAdd * (!esq && !primeira ? 0.8f : 1), rotAdd * 0.8f, size * 0.93f, true, g);
        DrawTree(false, atual.Dir, x2, y2, rot - rotAdd * (esq && !primeira ? 0.8f : 1), rotAdd * 0.8f, size * 0.93f, false, g);
    }

public bool Existe(Dado procurado)
   {
      antecessor = null;
      atual = raiz;
      while (atual != null)
      {
         if (atual.Info.CompareTo(procurado) == 0)
            return true;
         else
         {
            antecessor = atual;   // aponta o pai do nó procurado
            if (procurado.CompareTo(atual.Info) < 0)
               atual = atual.Esq; // Desloca apontador para o ramo à esquerda
            else
               atual = atual.Dir; // Desloca apontador para o ramo à direita
         }
      }
      return false; // Se atual == null, a chave não existe
   }

   public void IncluirNovoRegistro(Dado novoRegistro)
   {
      if (Existe(novoRegistro))
         throw new Exception("Registro com chave repetida!");
      else
      {
         // o novoRegistro tem uma chave inexistente, então criamos um
         // novo nó para armazená-lo e depois ligamos esse nó na árvore
         var novoNo = new NoArvore<Dado>(novoRegistro);
         // se a árvore está vazia, a raiz passará a apontar esse novo nó
         if (raiz == null)
            raiz = novoNo;
         else
         // nesse caso, antecessor aponta o pai do novo registro e
         // verificamos em qual ramo o novo nó será ligado
         if (novoRegistro.CompareTo(antecessor.Info) < 0) // novo é menor que antecessor
            antecessor.Esq = novoNo; // vamos para a esquerda
         else
            antecessor.Dir = novoNo; // ou vamos para a direita
      }
   }


   public bool ApagarNo(Dado registroARemover)
   {
      atual = raiz;
      antecessor = null;
      bool ehFilhoEsquerdo = true;
      while (atual.Info.CompareTo(registroARemover) != 0) // enqto não acha a chave a remover
      {
         antecessor = atual;
         if (atual.Info.CompareTo(registroARemover) < 0)
         {
            ehFilhoEsquerdo = true;
            atual = atual.Esq;
         }
         else
         {
            ehFilhoEsquerdo = false;
            atual = atual.Dir;
         }
         if (atual == null) // neste caso, a chave a remover não existe e não pode
            return false; // ser excluída, dai retornamos falso indicando isso
      } // fim do while
        // se fluxo de execução vem para este ponto, a chave a remover foi encontrada
        // e o ponteiro atual indica o nó que contém essa chave
      if ((atual.Esq == null) && (atual.Dir == null)) // é folha, nó com 0 filhos
      {
         if (atual == raiz)
            raiz = null; // exclui a raiz e a árvore fica vazia
         else
         if (ehFilhoEsquerdo) // se for filho esquerdo, o antecessor deixará
            antecessor.Esq = null; // de ter um descendente esquerdo
         else // se for filho direito, o antecessor deixará de
            antecessor.Dir = null; // apontar para esse filho
         atual = antecessor; // feito para atual apontar um nó válido ao sairmos do método
      }
      else // verificará as duas outras possibilidades, exclusão de nó com 1 ou 2 filhos
      if (atual.Dir == null) // neste caso, só tem o filho esquerdo
      {
         if (atual == raiz)
            raiz = atual.Esq;
         else
         if (ehFilhoEsquerdo)
            antecessor.Esq = atual.Esq;
         else
            antecessor.Dir = atual.Esq;
         atual = antecessor;
      }
      else
      if (atual.Esq == null) // neste caso, só tem o filho direito
      {
         if (atual == raiz)
            raiz = atual.Dir;
         else
         if (ehFilhoEsquerdo)
            antecessor.Esq = atual.Dir;
         else
            antecessor.Dir = atual.Dir;
         atual = antecessor;
      }
      else // tem os dois descendentes
      {
         NoArvore<Dado> menorDosMaiores = ProcuraMenorDosMaioresDescendentes(atual);
         atual.Info = menorDosMaiores.Info;
         menorDosMaiores = null; // para liberar o nó trocado da memória
      }
      return true;
   }
   public NoArvore<Dado> ProcuraMenorDosMaioresDescendentes(NoArvore<Dado> noAExcluir)
   {
      NoArvore<Dado> paiDoSucessor = noAExcluir;
      NoArvore<Dado> sucessor = noAExcluir;
      NoArvore<Dado> atual = noAExcluir.Dir; // vai ao ramo direito do nó a ser excluído,
                                             // pois este ramo contém os descendentes que
                                             // são maiores que o nó a ser excluído
      while (atual != null)
      {
         if (atual.Esq != null)
            paiDoSucessor = atual;
         sucessor = atual;
         atual = atual.Esq;
      }
      if (sucessor != noAExcluir.Dir)
      {
         paiDoSucessor.Esq = sucessor.Dir;
         sucessor.Dir = noAExcluir.Dir;
      }
      return sucessor;
   }
}
