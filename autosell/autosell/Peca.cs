using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autosell
{
    public class Peca
    {
        public String Nome { get; }
        public int Unidades { get; set; }
        public int StockMinimo { get; }
        public Loja Loja { get; }

        public Peca(String nome, int unidades, int stockMinimo, Loja loja)
        {
            Nome = nome;
            Unidades = unidades;
            StockMinimo = stockMinimo;
            Loja = loja;
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}
