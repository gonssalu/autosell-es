using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autosell
{
    enum TipoCombustivel
    {
        Gasolina,
        Gasóleo,
        GPL,
        Elétrico,
        Híbrido
    }

    internal class Veiculo
    {
        public String Marca { get; }
        public String Modelo { get; }
        public int Ano { get; }
        public TipoCombustivel Combustivel { get; }
        public String Cor { get; }
        public Double Preco { get; }
        public Double KmsPercorridos { get; }
        public int NrDonos { get; }
        public String? NomeDonoAnterior { get; }
        public int IdLocal { get; set; }

        public Veiculo(string marca, string modelo, int ano, TipoCombustivel combustivel, string cor, double preco,
                       double kmsPercorridos, int nrDonos, string nomeDonoAnterior, int idLocal)
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            Combustivel = combustivel;
            Cor = cor;
            Preco = preco;
            KmsPercorridos = kmsPercorridos;
            NrDonos = nrDonos;
            NomeDonoAnterior = nomeDonoAnterior;
            IdLocal = idLocal;
        }

        public Veiculo(string marca, string modelo, int ano, TipoCombustivel combustivel, string cor, double preco,
                       double kmsPercorridos, int idLocal)
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            Combustivel = combustivel;
            Cor = cor;
            Preco = preco;
            KmsPercorridos = kmsPercorridos;
            NrDonos = 0;
            IdLocal = idLocal;
        }

        public override string ToString()
        {
            return Marca + " " + Modelo + "  " + Ano;
        }
    }
}
