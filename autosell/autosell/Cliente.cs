using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autosell
{
    internal class Cliente
    {
        public String Nome { get; set; }

        public String Telefone { get; set; }

        public String Nif { get; set; }

        public Cliente(String nome, String telefone, String nif)
        {
            Nome = nome;
            Telefone = telefone;
            Nif = nif;
        }
        public override string ToString()
        {
            return Nome;
        }
    }
}
