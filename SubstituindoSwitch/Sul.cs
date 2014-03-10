using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstituindoSwitch
{
    public class Sul : Regiao
    {
        public bool Avalia(int valor)
        {
            return valor == 2;
        }

        public string Procedencia()
        {
            return "Sul";
        }
    }
}
