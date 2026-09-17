using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceCLassesAbstratas
{
    internal class Drone : ICamera, IVoavel
    {
        public void TirarFoto()
        {
            Console.WriteLine("Tirando fotos panorâmicas");
        }
        public void Decolar()
        {
            Console.WriteLine("Decolando...");
        }
        public void Pousar()
        {
            Console.WriteLine("Pousando...");
        }
    }
}
