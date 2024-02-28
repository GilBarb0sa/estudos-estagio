using System;
using System.Collections.Generic;
using System.Linq;

namespace ExemplosLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaProdutos = new List<Produto>()  //Fonte de dados
            {
                new Produto{Id = 1, CategoriaId = 3, Nome = "Camiseta", Status = true, Valor = 100       },
                new Produto{Id = 2, CategoriaId = 3, Nome = "Short", Status = true, Valor = 1            },
                new Produto{Id = 3, CategoriaId = 1, Nome = "Video Game", Status = true, Valor = 99      },
                new Produto{Id = 4, CategoriaId = 1, Nome = "TV", Status = true, Valor = 45              },
                new Produto{Id = 5, CategoriaId = 1, Nome = "Maquina de Lavar", Status = false, Valor = 32},
                new Produto{Id = 6, CategoriaId = 1, Nome = "Microondas", Status = true, Valor = 90      },
                new Produto{Id = 7, CategoriaId = 2, Nome = "Arroz", Status = true, Valor = 55           },
                new Produto{Id = 8, CategoriaId = 2, Nome = "Feijão", Status = true, Valor = 12          },
                new Produto{Id = 9, CategoriaId = 1, Nome = "Geladeira", Status = true, Valor = 10       },
            };

            //var listaCategorias = new List<Categoria>()
            //{
            //    new Categoria{Id = 1, Status = true, Nome = "Eletronicos"},
            //    new Categoria{Id = 2, Status = true, Nome = "Alimentos"  },
            //    new Categoria{Id = 3, Status = true, Nome = "Vestuario"  },
            //};

            #region Consulta e filtros
            //Criar consulta LINQ
            //01 - Filtrar produtos por nome
            //var resultado = from produto in listaProdutos // cada produto dentro desta lista, mostra pra mim este produto
            //                where produto.Nome.ToLower() == "arRoz".ToLower()
            //                select produto;

            ////02 - Filtrar produtos pela primeira letra do nome
            //var resultado = from produto in listaProdutos // cada produto dentro desta lista, mostra pra mim este produto
            //                where produto.Nome.ToLower().Substring(0, 1) == "m".ToLower()
            //                select produto;

            ////03 - Filtrar produtos pela primeira letra do nome e status ativo
            //var resultado = from produto in listaProdutos // cada produto dentro desta lista, mostra pra mim este produto
            //                where produto.Nome.ToLower().Substring(0, 1) == "m".ToLower() &&
            //                produto.Status == false
            //                select produto;

            ////04 - Ordenar os produtos por ID
            //var resultado = from produto in listaProdutos // cada produto dentro desta lista, mostra pra mim este produto
            //                where produto.Id >= 1 && produto.Id <= 6
            //                orderby produto.Id descending // funciona com números e letras
            //                select produto;

            #endregion

            #region Projetando dados com Select

            //var resultado = from prod in listaProdutos 
            //                select new ProdutoDto // projetando de uma classe
            //                { Nome = prod.Nome.ToUpper(),
            //                  Valor = prod.Valor,
            //                  Status = prod.Status 
            //                }; // Faz uma busca com o LINQ das propriedades nome, valor e status

            ////Executar a consulta
            //foreach (var result in resultado) //Pra cada produto que peguei da lista de produto vou exibir aqui
            //{
            //    Console.WriteLine($"{result.Nome} | {result.Valor} | {result.Status}");
            //}
            #endregion

            #region Agrupando e ordenando a lista
            //var result = from prod in listaProdutos
            //             group prod by prod.CategoriaId into produtosAgrupados
            //             orderby produtosAgrupados.Key //Ordena os grupos pelo CategoriaId
            //             select produtosAgrupados; //gera uma lista de produtos por categoria

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Key); // A Key nesta situação é o prod.CategoriaId
            //    foreach (var prod in item.OrderBy(p => p.Nome)) // Ordena os produtos pelo Nome dentro de cada grupo
            //    {
            //        Console.WriteLine($"Produto: {prod.Nome} | Categoria: {prod.CategoriaId}");
            //    }
            //}
            #endregion

            #region Join e Group by
            //Buscar os produtps e informar o nome do produto e o nome da categoria do produto
            //var result = from prod in listaProdutos
            //             join cat in listaCategorias
            //             on prod.CategoriaId equals cat.Id //associa o numero da primeira lista com a segunda, e os parametros é o categoriaId com Id
            //             select new
            //             {
            //                 Produto = prod,
            //                 Categoria = cat
            //             };

            //foreach ( var item in result)
            //{
            //    Console.WriteLine($"Produto: {item.Produto.Nome} | Categoria: {item.Categoria.Nome}");
            //}
            #endregion

            #region First, FirstOrDeafult, Last, LastOrDefault, Single e SingleOrDefault

            //var resultado = listaProdutos.Single(x => x.Id ==7); //First, FirstOrDeafult, Last, LastOrDefault, Single e SingleOrDefault

            //Console.WriteLine($"Nome: {resultado.Nome} | ID: {resultado.Id} ");
            //Console.ReadLine();

            #endregion


            #region Where, OrderBy OrderByDescending, Reverse e Sintaxe de método
            //Where - Filtra 
            var resultado = listaProdutos.Where(prod => FiltrarProdutoPorValor(prod));

            //Order By
            //resultado = resultado.OrderBy(prod => prod.Id);

            //OrderBy descending
            resultado = resultado.OrderByDescending(prod => prod.Id);

            //Revert - reverte a lista criada pelo order by
            resultado = resultado.Reverse();

            foreach (var result in resultado)
            {
                Console.WriteLine($"ID: {result.Id} | Nome: {result.Nome}");
            }
            #endregion
        }

        static bool FiltrarProdutoPorValor(Produto produto)
            {
                return produto.Valor > 50;
            }
    }

    class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Status { get; set; }
        public decimal Valor { get; set; }
        public int CategoriaId { get; set; }
    }

    class Categoria
    {
       public int Id { get; set; }
        public string Nome { get; set; }
        public bool Status { get; set; }
    }

    class ProdutoDto
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public bool Status { get; set; }
    }
}
