using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstituindoSwitch
{
    public class Switch
    {
        private List<Regiao> regioes;

        public Switch()
        {
            regioes = new List<Regiao>();

            regioes.Add(new Sul());
            regioes.Add(new Norte());
            regioes.Add(new Leste());
            regioes.Add(new Oeste());
        }

        public String BuscaRegiao(int valor)
        {
            foreach (Regiao regiao in regioes)
                if (regiao.Avalia(valor))
                    return regiao.Procedencia();

            return "Região não encontrada";
        }
    }
}
