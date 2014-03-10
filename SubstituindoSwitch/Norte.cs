using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstituindoSwitch
{
    public class Norte : Regiao
    {
        public bool Avalia(int valor)
        {
            return valor == 3;
        }

        public string Procedencia()
        {
            return "Norte";
        }
    }
}
