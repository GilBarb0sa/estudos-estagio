using System;

namespace Generics.Domain
{
    public class Categoria : Entity //Quando instanciar uma categoria, ele vai criar uma nova categoria com id
    {
        public Categoria(string nome)
        {
            Nome = nome;
        }

         // Para gerar um construtor automatico " Ctrl + . "
        public string Nome { get; set; }

        public override string ToString() // Vai imprimir
        {
            return $"{Id} | {Nome}";

        }

        public override bool Equals(object? obj) //esta recebendo um objeto
        {
            var categoria = obj as Categoria;
            if (categoria == null)
                return false;

            return categoria.Id == Id;
        }
    }
}
