using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Domain
{
    public class Produto
    {
        public Produto(string nome, decimal valor)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Valor = valor;
        }

        public Guid Id { get; set; } // Para gerar um construtor automatico " Ctrl + . "
        public string Nome { get; set; }
        public decimal Valor { get; set; }

        public override string ToString()
        {
            return $"{Id} | {Nome} | {Valor}";

        }

        public override bool Equals(object? obj) //esta recendo um objeto
        {
            var produto = obj as Produto;
            if (produto == null)
                return false;

            return produto.Id == Id;
        }
    }

    public class Categoria
    {

    }
}
