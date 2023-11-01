using System;
using System.IO;


  class Cidade : IComparable<Cidade>, IRegistro<Cidade>
  {
    const int tamNome = 15,
              tamX = 6,
              tamY = 6;

    const int iniNome = 0,
              iniX = iniNome + tamNome,
              iniY = iniX + tamX;

    string nome;
    double x, y;

    public string Nome   { get => nome; set => nome = value.PadRight(tamNome, ' ').Substring(0, tamNome); }
    public double X         { get => x; set => x = value; }
    public double Y         { get => y; set => y = value; }

    public Cidade(string nome, int x, int y)
    {
        Nome = nome;
        X = x;
        Y = y;
    }

    public int CompareTo(Cidade outro)
    {
        return Nome.ToLowerInvariant().CompareTo(outro.Nome.ToLowerInvariant());
    }

    public Cidade LerRegistro(BinaryReader arquivo)
    {
      if (arquivo != null) // arquivo aberto?
      {
        string linha = arquivo.ReadString();
        Nome = linha.Substring(iniNome, tamNome);
        X = int.Parse(linha.Substring(iniX, tamX));
        Y = int.Parse(linha.Substring(iniY));
        return this; // retorna o próprio objeto Contato, com os dados
      }
      return default(Cidade);
    }

    public void GravarRegistro(BinaryWriter arq)
    {
      if (arq != null)  // arquivo de saída aberto?
      {
        arq.Write(ParaArquivo());
      }
    }
    public string ParaArquivo()
    {
      return Nome + X.ToString() + Y.ToString();
    }

    public override string ToString()
    {
      return Nome + " " + X.ToString().PadLeft(tamX,' ') + Y.ToString().PadLeft(tamY, ' ');
    }
  }
