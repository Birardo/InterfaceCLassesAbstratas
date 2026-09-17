using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceCLassesAbstratas
{
    internal class Foto : ISalvavel
    {
        public void Salvar()
        {
            Console.WriteLine("Salvando a foto em formato .jpg");
        }
    }
}
