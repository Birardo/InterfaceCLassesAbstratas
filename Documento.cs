using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceCLassesAbstratas
{
    internal class Documento : ISalvavel
    {
        public void Salvar()
        {
            Console.WriteLine("Salvando o documento em formato .doc");
        }
    }
}
