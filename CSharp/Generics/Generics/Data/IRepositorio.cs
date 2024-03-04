using Generics.Domain;
using System.Collections.Generic;

namespace Generics.Data
{
    public interface IRepositorio<TEntity> where TEntity : Entity
    {
        void Adicionar(TEntity entidade);
            List<TEntity> ObterTodos();
    }
}