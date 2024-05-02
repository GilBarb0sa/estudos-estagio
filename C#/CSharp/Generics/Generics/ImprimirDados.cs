using Generics.Domain;
using System;
using System.Collections.Generic;

namespace Generics
{
    public static class ImprirDados
    {
        public static void ImprimirDados<TEntity>(this List<TEntity> entidades) //O this tranforma em um extensão
            where TEntity : Entity //Aqui é feito uma restrição no TEntity //Aqui imprimi os produtos!
        {
            if (entidades.Count == 0)
            {
                Console.WriteLine($"Lista de {typeof(TEntity).Name} Vazia"); //imprimi o tipo de TEntity
            }

            foreach (var entity in entidades)
            {
                Console.WriteLine(entity);
            }

            Console.WriteLine();
        }
    }
}

