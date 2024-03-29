﻿using System;
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

        public static void RemoverCliente(Cliente cliente)
        {
            CLIENTES.Remove(cliente);
        }

        public static void GuardarEvento(Evento ev)
        {
            EVENTOS.Add(ev);
        }

        public static Sede GetSede()
        {
            return (Sede)LOJAS[LOJAS.Count - 1];
        }
    }
}
