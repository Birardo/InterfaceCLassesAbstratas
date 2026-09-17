using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceCLassesAbstratas
{
    public abstract class Arma
    {
        public string Nome { get; set; }
        public int DanoBase{ get; set; }

        public void ExibirInfo()
        {
            Console.WriteLine($"O nome do arma é {Nome}");
            Console.WriteLine($"O dano base do {Nome} é {DanoBase}");
            Console.WriteLine($"Seu dano crítico é {CalcularAtaqueCritico()}");
        }
        public abstract int CalcularAtaqueCritico();
    }
}
