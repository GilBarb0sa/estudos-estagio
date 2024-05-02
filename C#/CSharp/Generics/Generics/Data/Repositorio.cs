using Generics.Domain;
using System.Collections.Generic;

namespace Generics.Data
{
    //tornando a classe generica, recebendo um tipo, que pode ser qualquer coisa
    public class Repositorio<TEntity> : IRepositorio<TEntity> where TEntity : Entity //Aqui é feito uma restrição no TEntity
    {
        private List<TEntity> _lista;

        public Repositorio()
        {
            _lista = new List<TEntity>();
        }

        public void Adicionar(TEntity entidade) //Metodo
        {
            _lista.Add(entidade);
        }

        public List<TEntity> ObterTodos() //Metodo
        {
            return _lista;
        }
    }
}
