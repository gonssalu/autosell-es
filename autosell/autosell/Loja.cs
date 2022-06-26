using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autosell
{
    internal class Loja : Local
    {
        public String Nome { get; }
        public int TamanhoGaragem { get; }

        public Loja(string nome, string morada, int tamanhoGaragem) : base(morada)
        {
            if (tamanhoGaragem > 100)
                throw new ArgumentException("O tamanho da garagem de uma filial não pode exceder os 100 lugares.",
                                            "TamanhoGaragem");
            Nome = nome;
            TamanhoGaragem = tamanhoGaragem;
        }

        //Construtor apenas usado como base() na classe Sede
        protected Loja(string nome, string morada) : base(morada)
        {
            Nome = nome;
            TamanhoGaragem = 4500;
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}
