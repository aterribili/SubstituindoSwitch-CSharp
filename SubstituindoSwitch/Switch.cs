using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstituindoSwitch
{
    public class Switch
    {
        private List<Regiao> regioes = new List<Regiao>();

        public String BuscaRegiao(int valor)
        {
            regioes.Add(new Sul());
            regioes.Add(new Norte());
            regioes.Add(new Leste());
            regioes.Add(new Oeste());

            foreach (Regiao regiao in regioes)
                if (regiao.Avalia(valor))
                    return regiao.Procedencia();

            return "Região não encontrada";
        }
    }
}
