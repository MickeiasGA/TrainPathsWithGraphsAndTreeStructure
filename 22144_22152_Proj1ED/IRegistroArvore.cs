using System;
using System.IO;

public interface IRegistroArvore
{
   void LerRegistro(BinaryReader arquivo, long qualRegistro);
   void GravarRegistro(BinaryWriter arquivo);
   int TamanhoRegistro { get; }
}