using Generics.Domain;
using System.Collections.Generic;

namespace Generics.Data
{
    public class CategoriaRepositorio
    {
        private List<Categoria> _categorias;

        public CategoriaRepositorio()
        {
            _categorias = new List<Categoria>();
        }

        public void Adicionar(Categoria categoria) //Metodo
        {
            _categorias.Add(categoria);
        }

        public List<Categoria> ObterTodos() //Metodo
        {
            return _categorias;
        }

    }
}
