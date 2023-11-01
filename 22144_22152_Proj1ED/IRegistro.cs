using System.IO;
public interface IRegistro<Dado>
{
    Dado LerRegistro(BinaryReader arquivo);
    string ParaArquivo();
    void GravarRegistro(BinaryWriter arquivo);

}
