using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

            //Logar no sistema
        }
    }
}
