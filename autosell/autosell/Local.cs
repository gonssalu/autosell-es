using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autosell
{
    internal class Local
    {
        public String Morada { get; }
        public List<Veiculo> Garagem { get; }

        public Local(string morada)
        {
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
