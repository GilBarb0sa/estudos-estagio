using System.Collections.Generic;

namespace Generics.Data
{
    public class ObjectRepositorio
    {
        private List<object> _objetos;

        public ObjectRepositorio()
        {
            _objetos = new List<object>();
        }

        public void Adicionar(object obj) //Metodo
        {
            _objetos.Add(obj);
        }

        public List<object> ObterTodos() //Metodo
        {
            return _objetos;
        }
    }
}
