using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autosell
{
    public class Local
    {
        public int IdLocal { get; }
        public String Morada { get; set; }
        public List<Veiculo> Garagem { get; }

        public Local(string morada)
        {
            IdLocal = Dados.PROXIMO_ID_LOCAL;
            Dados.PROXIMO_ID_LOCAL++;
            Morada = morada;
            Garagem = new List<Veiculo>();
        }

        public void AdicionarVeiculo(Veiculo veiculo)
        {
            Garagem.Add(veiculo);
        }

        public void RemoverVeiculo(Veiculo veiculo)
        {
            Garagem.Remove(veiculo);
        }
    }
}
