using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace InterfaceCLassesAbstratas
{
    internal class CampoTexto : CampoFormulario, IValidavel
    {
        public bool Validar()
        {
            if(Valor != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
