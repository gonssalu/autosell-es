using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace autosell
{
    internal class RandomHelper
    {
        public static int rn(int min, int max)
        {
            return rand.Next(min, max + 1);
        }

        public static bool perc(int percentagem)
        {
            return rn(1, 100) < percentagem;
        }
        
        #region Aleatorização dos dados
        private static Random rand = new Random();

        private static String[] primeiroNomes = { "Maria Ana", "Alexandre", "Marco", "Pedro", "Gonçalo", "Bruna", "Diogo" };
        private static String[] meioNomes = { "Pinto", "Ferreira", "Leal", "Batista" };
        private static String[] apelidos = { "Pereira", "Gago", "Santos", "Borges", "Tavares", "Rosa" };

        private static String[] prefixoRua = { "Rua", "Avenida" };
        private static String[] ruas = { "Cidade da Praia", "5 de Maio", "25 de Abril", "Santo António", "Júlio de Matos", "da Paz", "de Queba", "Rio de Janeiro", "Mato Grosso", "Perth Amboy", "do Meio" };

        private static String[] cores = { "cinzento", "preto", "branco", "cinzento", "preto", "branco", "cinzento", "preto", "branco", "azul", "azul", "vermelho" };
        private static String[] marcasVeiculos = { "Renault", "Ferrari", "Mercedes", "Opel", "Tesla", "Toyotta", "Volkswagen", "Yamaha", "Peugeot" };
        private static String[] modelosVeiculos = { "Model", "Testarossa", "Benz", "NVIDIA", "Boda", "Apedais", "Astra", "Leaf", "Gamer", "Ibiza", "Sophia", "Megane", "Tenere", "Mirai" };
        private static String[] extraModelVeiculos = { "S", "X", "GG", "G", "A", "T" };
        private static String[] extra2ModelVeiculos = { "3", "6", "5", "8", "2", "7", "9"};
        private static String[] extrasDefault = { "[L][N]", "[L][L][N]", "[L][N]-[L]", "[N2][L]", "[N3]", "[L][L]-[N4]" };

        private static String[] nomesPeca = { "Motor", "Pneu", "Espelho retrovisor", "Tubo de escape", "Rádio", "Volante", "Coluna", "Banco", "Vela de ignição", "Filtro", "Radiador", "Sensor", "Travão", "Interruptor" };
        private static String[] nomesComb = { "Gasóleo", "Gasolina 95", "Gasolina 98" };
        private static String[] nomesCombExtra = { "Diesel Ultimate", "GPL Auto", "Gasóleo Verde", "Hidrogénio Alta Pressão" };

        private static String[] nomesLoja = { "Caldas da Rainha", "Porto", "Lisboa", "Viana do Castelo", "Beja", "Algarve" };
        private static String[] nomesEvento = { "Lisboa Games Week", "Feira Benecar", "Feira 1º Maio", "Feira dos Frutos", "Dia das Caldas", "Car Summit" };

        private static List<String> USED_STUFF = new();
        private static List<String> USED_PECA_LOJA = new();

        private static String GetRndMorada()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(prefixoRua[rand.Next(0, prefixoRua.Length)]);
            sb.Append(" ");
            sb.Append(ruas[rand.Next(0, ruas.Length)]);
            return sb.ToString();
        }

        private static String GetRndNomeNP()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(primeiroNomes[rand.Next(0, primeiroNomes.Length)]);
            sb.Append(" ");
            if (perc(75))
            {
                sb.Append(meioNomes[rand.Next(0, meioNomes.Length)]);
                sb.Append(" ");
            }
            sb.Append(apelidos[rand.Next(0, apelidos.Length)]);
            return sb.ToString();
        }

        private static String GetRndNome()
        {
            String nome;
            int cont = 0;
            do
            {
                nome = GetRndNomeNP();
            } while (USED_STUFF.Contains(nome) || cont > 10); //evitar loop infinitos
            USED_STUFF.Add(nome);
            return nome;
        }

        private static String GetRndMarca()
        {
            return marcasVeiculos[rand.Next(0, marcasVeiculos.Length)];
        }

        private static String GetRndCor()
        {
            return cores[rand.Next(0, cores.Length)];
        }

        private static String GetRndXtrDef()
        {
            String chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Regex regex = new Regex(Regex.Escape("[L]"));
            String str = extrasDefault[rand.Next(0, extrasDefault.Length)];
            while (str.Contains("[L]"))
            {
                str = regex.Replace(str, chars[rand.Next(0, extrasDefault.Length)].ToString(), 1);
            }
            str = str.Replace("[N]", rn(0,9).ToString());
            str = str.Replace("[N2]", rn(10, 99).ToString());
            str = str.Replace("[N3]", rn(100, 999).ToString());
            str = str.Replace("[N4]", rn(1000, 9999).ToString());
            return str;
        }

        private static String GetRndModelo(String marca)
        {
            String modelo;
            int cont = 0;
            do
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(modelosVeiculos[rand.Next(0, modelosVeiculos.Length)]);
                sb.Append(" ");
                sb.Append(extraModelVeiculos[rand.Next(0, extraModelVeiculos.Length)]);
                if (perc(66))
                {
                    if (perc(50))
                    {
                        sb.Append(extra2ModelVeiculos[rand.Next(0, extra2ModelVeiculos.Length)]);
                    }
                    else
                    {
                        sb.Append(" ");
                        sb.Append(GetRndXtrDef());
                    }
                    
                }
                modelo = sb.ToString();
            } while (USED_STUFF.Contains(marca+" "+modelo) || cont > 10); //evitar loop infinitos
            USED_STUFF.Add(marca+" "+modelo);
            return modelo;
        }
        #endregion

        private static Veiculo GenVeiculo(Local local)
        {
            String marca = GetRndMarca();
            Array arrtc = Enum.GetValues(typeof(TipoCombustivel));
            TipoCombustivel tc = (TipoCombustivel) arrtc.GetValue(rand.Next(arrtc.Length));
            int nd = rn(1, 10);
            bool used = nd <= 3;
            Veiculo veiculo = new (marca, GetRndModelo(marca), (used?rn(2004,2020):rn(2016,2022)), tc, GetRndCor(), (used ? rn(2500,16000) : rn(14000,95000)), (used?rn(75000,600000):rn(0,100)), (used ? nd:0), used ? GetRndNomeNP() : "", local.IdLocal);
            //VEICULOS.Add(veiculo);
            return veiculo;
        }

        private static String GetRndPecaNome()
        {
            String nomePeca;
            int cont = 0;
            do
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(nomesPeca[rand.Next(0, nomesPeca.Length)]);
                sb.Append(" ");
                sb.Append(GetRndXtrDef());
                nomePeca = sb.ToString();
            } while (USED_PECA_LOJA.Contains(nomePeca) || cont > 10); //evitar loop infinitos
            USED_PECA_LOJA.Add(nomePeca);
            return nomePeca;
        }

        private static Peca GenPeca(Loja loja)
        {
            int un = rn(5,25);
            int min = (un < 10 ? 5 : 10);
            return new Peca(GetRndPecaNome(), un, min, loja);
        }

        public static void PREENCHER()
        {
            //Gerar Lojas e os seus Veículos
            foreach (String nomeLoja in nomesLoja)
            {
                int lotacao = rn(4, 50) * 2;
                Loja loja = new("Loja " + nomeLoja, GetRndMorada(), lotacao);
                for (int i = 0; i < rn(lotacao * 1 / 5 , lotacao * 3 / 4); i++)
                    loja.Garagem.Add(GenVeiculo(loja));

                //Gerar Peças
                foreach (String comb in nomesComb)
                    Dados.PECAS.Add(new(comb, rn(20, 200), 20, loja));

                foreach (String comb in nomesCombExtra)
                    if (perc(30))
                        Dados.PECAS.Add(new(comb, rn(20, 80), 20, loja));

                for (int i = 0; i < 8; i++)
                    Dados.PECAS.Add(GenPeca(loja));


                Dados.LOJAS.Add(loja);
                USED_PECA_LOJA.Clear();
            }
            //Gerar Clientes
            for (int i = 0; i < 30; i++)
            {
                Cliente cliente = new(GetRndNome(), rn(900000000, 999999999).ToString(), rn(100000000, 599999999).ToString());
                Dados.CLIENTES.Add(cliente);
            }
            //Gerar Eventos
            foreach (String nomeEvento in nomesEvento)
            {
                for (int i = 0; i < 3; i++)
                {
                    int ano = 2022 - i;
                    DateTime dt = new(ano, rn(1, 12), rn(1, 28));
                    DateTime dt2 = new(ano, rn(dt.Month, 12), rn(dt.Day, 28));
                    Evento evento = new(nomeEvento + " " + (ano).ToString(), GetRndMorada(), dt, dt2);
                    for (int j = 0; j < rn(1, 6); j++)
                        evento.Garagem.Add(GenVeiculo(evento));
                    Dados.EVENTOS.Add(evento);
                }
            }
            //Gerar Transacoes
            Veiculo veiculoPlaceholder = GenVeiculo(Dados.LOJAS[0]);
            Veiculo veiculoPlaceholder2 = GenVeiculo(Dados.LOJAS[0]);
            DateTime dat;
            for (int i = 0; i < 15; i++)
            {
                dat = new(2022, rn(1, 12), rn(1, 28));
                Dados.TRANSACOES.Add(new(TipoTransacao.Venda, veiculoPlaceholder, veiculoPlaceholder.Preco, Dados.CLIENTES[i], dat));
            }
            
            for (int i = 15; i < 30; i++)
            {
                dat = new(2022, rn(1, 12), rn(1, 28));
                Dados.TRANSACOES.Add(new(TipoTransacao.Compra, veiculoPlaceholder2, veiculoPlaceholder2.Preco / 2, Dados.CLIENTES[i], dat));
            }
            
            dat = new(2022, rn(1, 12), rn(1, 28));
            Dados.TRANSACOES.Add(new(TipoTransacao.Troca, veiculoPlaceholder2, 1250, Dados.CLIENTES[0], veiculoPlaceholder, dat));

        }

        //TEMPORARY
        //public static List<Veiculo> VEICULOS = new();
    }
}
