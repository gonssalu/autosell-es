using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autosell
{
    enum TipoTransacao
    {
        Compra,
        Venda,
        Troca
    }

    internal class Transacao
    {
        public TipoTransacao Tipo { get; }
        public Veiculo Veiculo { get; }
        public Double Valor { get; }
        public Cliente Cliente { get; }
        public Veiculo? VeiculoRecebido { get; } // Este é o veículo que o cliente entrega, no caso de uma troca

        public Transacao(TipoTransacao tipo, Veiculo veiculo, Double valor, Cliente cliente, Veiculo veiculoRecebido)
        {
            if (veiculo == veiculoRecebido)
                throw new ArgumentException("Não pode trocar um veículo por ele mesmo.", "veiculoRecebido");
            Tipo = tipo;
            Veiculo = veiculo;
            Valor = valor;
            Cliente = cliente;
            VeiculoRecebido = veiculoRecebido;
        }

        public Transacao(TipoTransacao tipo, Veiculo veiculo, Double valor, Cliente cliente)
        {
            if (tipo == TipoTransacao.Troca)
                throw new ArgumentNullException("VeiculoRecebido",
                                                "Não é possível criar uma transação de troca sem o veículo que o cliente entregou.");

            Tipo = tipo;
            Veiculo = veiculo;
            Valor = valor;
            Cliente = cliente;
        }

        public override string ToString()
        {
            return Tipo.ToString() + " de " + Veiculo + " para " + Cliente + " no valor de " +
                   Valor.ToString(CultureInfo.InvariantCulture) + "€";
        }
    }
}
