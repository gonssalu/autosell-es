using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autosell
{
    internal class Dados
    {
        public static List<Cliente> CLIENTES = new();
        public static List<Evento> EVENTOS = new();
        public static List<Loja> LOJAS = new();
        public static List<Peca> PECAS = new();
        public static List<Transacao> TRANSACOES = new();
        public static Sede SEDE = new();

        public static int PROXIMO_ID_LOCAL = 0;

        public static void MudarLocalVeiculo(Veiculo veiculo, Local localAntigo, Local novoLocal)
        {
            localAntigo.RemoverVeiculo(veiculo);
            novoLocal.AdicionarVeiculo(veiculo);
            veiculo.IdLocal = novoLocal.IdLocal;
        }

        public static void RemoverEvento(Evento evento)
        {
            EVENTOS.Remove(evento);
        }
    }
}
