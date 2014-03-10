using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstituindoSwitch
{
    public class Leste : Regiao
    {
        public bool Avalia(int valor)
        {
            return valor == 5;
        }

        public string Procedencia()
        {
            return "Leste";
        }
    }
}
