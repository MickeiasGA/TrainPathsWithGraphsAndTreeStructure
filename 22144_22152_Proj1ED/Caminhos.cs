using System;
using System.IO;
using System.Text;

namespace _22144_22152_Proj1ED
{
    public class Caminho : IComparable<Caminho>, ICriterioDeSeparacao
    {
        private string de;
        private string para;
        private int distancia;
        private int tempo;

        public Caminho(string de, string para, int distancia, int tempo)
        {
            this.de = de;
            this.para = para;
            this.distancia = distancia;
            this.tempo = tempo;
        }

        public bool PodeSeparar() //nescessário implementar para interface iCriterioDeSeparacao
        {
            return this == null;
        }

        public string De
        {
            get => de;
            set => de = value.PadRight(15, ' ').Substring(0, 15);
        }

        public string Para
        {
            get => para;
            set => para = value.PadRight(15, ' ').Substring(0, 15);
        }

        public int Distancia
        {
            get => distancia;
            set => distancia = value;
        }

        public int Tempo
        {
            get => tempo;
            set => tempo = value;
        }

        public int CompareTo(Caminho other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            int deComparison = string.Compare(de, other.de, StringComparison.Ordinal);
            if (deComparison != 0) return deComparison;
            int paraComparison = string.Compare(para, other.para, StringComparison.Ordinal);
            if (paraComparison != 0) return paraComparison;
            int distanciaComparison = distancia.CompareTo(other.distancia);
            if (distanciaComparison != 0) return distanciaComparison;
            return tempo.CompareTo(other.tempo);
        }

        public void GravarRegistro(BinaryWriter arq)
        {
            if (arq == null) return;
            arq.Write(Encoding.UTF8.GetBytes(De));
            arq.Write(Encoding.UTF8.GetBytes(Para));
            arq.Write(BitConverter.GetBytes(Distancia));
            arq.Write(BitConverter.GetBytes(Tempo));
        }
    }
}
