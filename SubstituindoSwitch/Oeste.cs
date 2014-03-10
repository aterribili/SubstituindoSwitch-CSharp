using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstituindoSwitch
{
    public class Oeste : Regiao
    {
        public bool Avalia(int valor)
        {
            return valor == 7;
        }

        public string Procedencia()
        {
            return "Oeste";
        }
    }
}
