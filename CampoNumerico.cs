using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceCLassesAbstratas
{
    internal class CampoNumerico : CampoFormulario, IValidavel
    {
        public bool Validar()
        {
            return int.TryParse(Valor, out _);
        }
    }
}
