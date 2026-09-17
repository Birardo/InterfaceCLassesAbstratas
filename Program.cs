namespace InterfaceCLassesAbstratas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISalvavel Doc = new Documento();
            ISalvavel Foto = new Foto();
            Doc.Salvar();
            Foto.Salvar();
        }
    }
}
