using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstituindoSwitch
{
    public interface Regiao
    {
        bool Avalia(int valor);

        String Procedencia();
    }
}
