using System;

namespace Propriedades
{
     class Teste
    {
        //Definição de um campo
        private string _nome;  //campo
        public string Sobrenome { get; } = "Barbosa";  //propriedade

        private int _idade;

        //Definição de uma propriedade
        public string Nome
        {
            get { return _nome; }   //retorna
            set { _nome = value; }  //atribui
        }

        public int Idade
        {
            get { return _idade; }
            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Idade não pode ser inferior a 18 anos.");
                    _idade = value;
                }
                else
                {
                    _idade = value;
                }
            }
        }

        public void Apresentar()
        {
            if(_nome != "")
                Console.WriteLine("Bem vindo " + _nome);
        }
         
    }
}
