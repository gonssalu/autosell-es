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
        public DateTime Data { get; }

        public Transacao(TipoTransacao tipo, Veiculo veiculo, Double valor, Cliente cliente, Veiculo veiculoRecebido)
        {
            if (veiculo == veiculoRecebido)
                throw new ArgumentException("Não pode trocar um veículo por ele mesmo.", "veiculoRecebido");
            Tipo = tipo;
            Veiculo = veiculo;
            Valor = valor;
            Cliente = cliente;
            VeiculoRecebido = veiculoRecebido;
            Data = DateTime.Now;
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
            Data = DateTime.Now;
        }

        public Transacao(TipoTransacao tipo, Veiculo veiculo, Double valor, Cliente cliente, Veiculo veiculoRecebido,
                         DateTime data)
        {
            if (veiculo == veiculoRecebido)
                throw new ArgumentException("Não pode trocar um veículo por ele mesmo.", "veiculoRecebido");
            Tipo = tipo;
            Veiculo = veiculo;
            Valor = valor;
            Cliente = cliente;
            VeiculoRecebido = veiculoRecebido;
            Data = data;
        }

        public Transacao(TipoTransacao tipo, Veiculo veiculo, Double valor, Cliente cliente, DateTime data)
        {
            if (tipo == TipoTransacao.Troca)
                throw new ArgumentNullException("VeiculoRecebido",
                                                "Não é possível criar uma transação de troca sem o veículo que o cliente entregou.");

            Tipo = tipo;
            Veiculo = veiculo;
            Valor = valor;
            Cliente = cliente;
            Data = data;
        }

        public override string ToString()
        {
            if(Tipo==TipoTransacao.Troca)
                return "[" + Data.ToString("d/MM/yy HH:mm") + "] " + Tipo.ToString() + " | " + Veiculo + " | " + Cliente.Nome + " | Valor extra: " +
                   Valor.ToString(CultureInfo.InvariantCulture) + "€";
            return "[" + Data.ToString("d/MM/yy HH:mm") + "] " + Tipo.ToString() + " | " + Veiculo + " | " + Cliente.Nome + " | Valor: " +
                   Valor.ToString(CultureInfo.InvariantCulture) + "€";
        }
    }
}
