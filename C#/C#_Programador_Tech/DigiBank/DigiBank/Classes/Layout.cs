using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DigiBank.Classes
{
    public class Layout
    {
        private static List<Pessoa> pessoas = new List<Pessoa>(); //Toda pessoa que cadastrar vai ficar salva na variavel pessoa, sendo estatica
        private static int opcao = 0;

        public static void TelaPrincipal() // Voide não retorna nada
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;

            Console.Clear(); //Apaga tudo que estava antes

            Console.WriteLine("                                                  ");
            Console.WriteLine("            Digite a opção desejada  :            ");
            Console.WriteLine("           ============================           ");
            Console.WriteLine("            1 - Criar Conta                       ");
            Console.WriteLine("           ============================           ");
            Console.WriteLine("            2 - Entrar com CPF e Senha            ");
            Console.WriteLine("           ============================           ");

            opcao = int.Parse(Console.ReadLine()); //Parse para converter a string para um número inteiro

            switch (opcao)
            {
                case 1:
                    TelaCriarConta();
                    break;
                case 2:
                    TelaLogin();
                    break;
                default:
                    Console.WriteLine("Opção Inválida!");
                    break;
            }
        }

        private static void TelaCriarConta()
        {
            Console.Clear();

            Console.WriteLine("                                                  ");
            Console.WriteLine("            Digite o seu nome:                    ");
            string nome = Console.ReadLine();
            Console.WriteLine("           ============================           ");
            Console.WriteLine("            Digite o CPF:                         ");
            string cpf = Console.ReadLine();
            Console.WriteLine("           ============================           ");
            Console.WriteLine("            Digite sua senha:                     ");
            string senha = Console.ReadLine();
            Console.WriteLine("           ============================           ");

            //Criar uma conta

            ContaCorrente contaCorrente = new ContaCorrente(); //instanciando
            Pessoa pessoa = new Pessoa();

            pessoa.SetNome(nome);
            pessoa.SetCPF(cpf);
            pessoa.SetSenha(senha);
            pessoa.Conta = contaCorrente; //Vinculando a pessoa nesta conta corrente

            pessoas.Add(pessoa);

            Console.Clear();


            Console.WriteLine("            Conta Cadastrada com Sucesso.                     ");
            Console.WriteLine("           ===============================                    ");

            Thread.Sleep(1000);  //Este código espera 1 segundo para ir a tela logada

            TelaContaLogada(pessoa);
        }

        private static void TelaLogin()
        {
            Console.Clear();

            Console.WriteLine("                                                  ");
            Console.WriteLine("            Digite o CPF:                         ");
            string cpf = Console.ReadLine(); // Recebe a informação digitada!
            Console.WriteLine("           ============================           ");
            Console.WriteLine("            Digite sua senha:                     ");
            string senha = Console.ReadLine();
            Console.WriteLine("           ============================           ");

            Pessoa pessoa = pessoas.FirstOrDefault(x => x.CPF == cpf && x.Senha == senha);

            if(pessoa != null)
            {
                TelaBoasVindas(pessoa);
                TelaContaLogada(pessoa);
            }
            else
            {
                Console.Clear();

                Console.WriteLine("            Pessoa não cadastrada                 ");
                Console.WriteLine("           ============================           ");

                Console.WriteLine();
                Console.WriteLine();
            }
        }

        private static void TelaBoasVindas(Pessoa pessoa)
        {
            string msgTelaBemVindo =
            $"{pessoa.Nome} | Banco: {pessoa.Conta.GetCodigoDoBanco()} " +
            $"| Agência: {pessoa.Conta.GetNumeroAgencia()} | Conta: {pessoa.Conta.GetNumeroDaConta()}";

            Console.WriteLine("");
            Console.WriteLine($"       Seja bem vindo, {msgTelaBemVindo}"); 
            Console.WriteLine("");
        }

        private static void TelaContaLogada(Pessoa pessoa)
        {
            Console.Clear();

            TelaBoasVindas(pessoa);

            Console.WriteLine("           Digite a Opção desejada:               ");
            Console.WriteLine("           ============================           ");
            Console.WriteLine("           1 - Realizar um Deposito               ");
            Console.WriteLine("           ============================           ");
            Console.WriteLine("           2 - Realizar um Saque                  ");
            Console.WriteLine("           ============================           ");
            Console.WriteLine("           3 - Consultar Saldo                    ");
            Console.WriteLine("           ============================           ");
            Console.WriteLine("           4 - Extrato                            ");
            Console.WriteLine("           ============================           ");
            Console.WriteLine("           5 - Sair                               ");
            Console.WriteLine("           ============================           ");

            opcao = int.Parse(Console.ReadLine());  //Armazenando as opções

            switch(opcao)
            {
                case 1:
                    TelaDeposito(pessoa);
                    break;
                case 2:
                    TelaSaque(pessoa);
                    break;
                case 3:
                    TelaSaldo(pessoa);
                    break;
                case 4:
                    TelaExtrato(pessoa);
                    break;
                case 5:
                    TelaPrincipal();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("           Opção Inválida!                        ");
                    Console.WriteLine("           ============================           ");
                    break;
            }
        }

        private static void TelaDeposito(Pessoa pessoa)
        {
            Console.Clear();

            TelaBoasVindas(pessoa);

            Console.WriteLine("        Digite o valor do deposito:          ");
            double valor = double.Parse(Console.ReadLine());
            Console.WriteLine("       ==============================        ");

            pessoa.Conta.Deposita(valor);

            Console.Clear();

            TelaBoasVindas(pessoa);

            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");
            Console.WriteLine("      Deposito Realizado com sucesso          ");
            Console.WriteLine("      ==============================          ");
            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");

            OpcaoVoltarLogado(pessoa);
        }


        private static void OpcaoVoltarLogado(Pessoa pessoa)
        {
            Console.WriteLine("      Entre com uma opção abaixo?             ");
            Console.WriteLine("      ==============================          ");
            Console.WriteLine("      1 - Voltar para minha conta             ");
            Console.WriteLine("      ==============================          ");
            Console.WriteLine("      2 - Sair                                ");
            Console.WriteLine("      ==============================          ");

            opcao = int.Parse(Console.ReadLine());

            if(opcao == 1)
                TelaContaLogada(pessoa);
            else
                TelaPrincipal();
        }

        private static void OpcaoVoltarDeslogado()
        {
            Console.WriteLine("      Entre com uma opção abaixo?                  ");
            Console.WriteLine("      ================================             ");
            Console.WriteLine("      1 - Voltar para o menu principal             ");
            Console.WriteLine("      ================================             ");
            Console.WriteLine("      2 - Sair                                     ");
            Console.WriteLine("      ================================             ");

            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
                TelaPrincipal();
            else
            {
                Console.WriteLine("            Opção Inválida!                        ");
                Console.WriteLine("      ================================             ");
            }
        }
        private static void TelaSaque(Pessoa pessoa)
        {
            Console.Clear();

            TelaBoasVindas(pessoa);

            Console.WriteLine("        Digite o valor do saque:             ");
            double valor = double.Parse(Console.ReadLine());
            Console.WriteLine("       ==============================        ");

            bool okSaque = pessoa.Conta.Saca(valor);

            Console.Clear();

            TelaBoasVindas(pessoa);

            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");


            if(okSaque)
            {
                Console.WriteLine("      Saque foi Realizado com sucesso         ");
                Console.WriteLine("      ===============================         ");
            }
            else
            {
                Console.WriteLine("      Saldo insuficiente                      ");
                Console.WriteLine("      ===============================         ");
            }

            Console.WriteLine("                                              ");
            Console.WriteLine("                                              ");

            OpcaoVoltarLogado(pessoa);
        }

        private static void TelaSaldo(Pessoa pessoa)
        {
            Console.Clear();

            TelaBoasVindas(pessoa);

            Console.WriteLine($"      Seu saldo é:    R${pessoa.Conta.ConsultaSaldo()},00    ");
            Console.WriteLine("      ===============================                         ");
            Console.WriteLine("                                                              ");

            OpcaoVoltarLogado(pessoa);
        }

        private static void TelaExtrato(Pessoa pessoa)
        {
            Console.Clear();

            TelaBoasVindas(pessoa);

            if(pessoa.Conta.Extrato().Any())
            {
                //Mostra extrato
                double total = pessoa.Conta.Extrato().Sum(x => x.Valor);

                foreach(Extrato extrato in pessoa.Conta.Extrato())  //Faz uma varredura em extrato e traz em forma de array
                {
                    Console.WriteLine($"       Data: {extrato.Data.ToString("dd/MM/yyyy HH:mm:ss")}     "); //Formatação de data BR
                    Console.WriteLine($"       Tipo de Movimentação: {extrato.Descricao}                ");
                    Console.WriteLine($"       Tipo de Movimentação: {extrato.Valor}                    ");
                    Console.WriteLine("        ==================================================       ");
                }

                Console.WriteLine("                                      ");
                Console.WriteLine("                                      ");
                Console.WriteLine($"      SUB TOTAL: {total}             ");
                Console.WriteLine("       ========================       ");
            }
            else
            {
                //Mostrar uma mensagem que não há extrato

                Console.WriteLine("      Não há extrato a ser exibido!                ");
                Console.WriteLine("      ================================             ");
            }

            OpcaoVoltarLogado(pessoa);
        }
    }
}
