using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autosell
{
    internal class Evento:Local
    {
        public String Nome { get; }
        public DateTime DataInicio { get; }
        public DateTime DataFim { get; }
        public Boolean Terminado { get; set; }

        public Evento(String nome, String morada, DateTime dataInicio, DateTime dataFim) : base(morada)
        {
            Nome = nome;
            DataInicio = dataInicio;
            DataFim = dataFim;
			Terminado = false;
        }

        public Evento(String nome, String morada, DateTime dataInicio, DateTime dataFim, List<Veiculo> veiculos) : base(morada)
        {
            Nome = nome;
            DataInicio = dataInicio;
            DataFim = dataFim;
			Terminado = false;
            Garagem.AddRange(veiculos);
        }
        public override string ToString()
        {
            return Nome + " (" + DataInicio.ToString("dd/MMM") + " a " + DataFim.ToString("dd/MMM") + ")";
        }
    }
}
