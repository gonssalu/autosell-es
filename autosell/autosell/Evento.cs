using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autosell
{
    public class Evento:Local
    {
        public String Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
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
            return Nome + " (" + DataInicio.ToString("dd/MMM") + " a " + DataFim.ToString("dd/MMM") + ") " + (Terminado?"[TERMINADO]":"[A DECORRER]");
        }
    }
}
