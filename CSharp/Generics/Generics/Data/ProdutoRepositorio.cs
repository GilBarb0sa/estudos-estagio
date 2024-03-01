using Generics.Domain;
using System.Collections.Generic;

namespace Generics.Data
{
    public class ProdutoRepositorio //classe repositorio de produto
    {
        private List<Produto> _produtos;

        public ProdutoRepositorio()
        {
            _produtos = new List<Produto>();
        }
        
        public void Adicionar(Produto produto) //Metodo
        {
            _produtos.Add(produto);
        }

        public List<Produto> ObterTodos() //Metodo
        {
            return _produtos;
        }

    }
}
