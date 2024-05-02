using Generics;
using Generics.Data;
using Generics.Domain;
using Microsoft.Extensions.DependencyInjection;
using System;

var provider = ConfigurarInjecaoDeDependencia();

var produtoRepositorio = provider.GetRequiredService<IRepositorio<Produto>>();
var categoriaRepositorio = provider.GetRequiredService<IRepositorio<Categoria>>();

produtoRepositorio.Adicionar(new Produto("Produto 01", 200));
produtoRepositorio.Adicionar(new Produto("Produto 02", 400));

categoriaRepositorio.Adicionar(new Categoria("Categoria 01"));
categoriaRepositorio.Adicionar(new Categoria("Categoria 02"));

produtoRepositorio.ObterTodos().ImprimirDados(); //metodo de extensão generico
categoriaRepositorio.ObterTodos().ImprimirDados();

var primeiroProduto = produtoRepositorio.ObterTodos()[0];
var primeiroCategoria = categoriaRepositorio.ObterTodos()[0]; 

Console.WriteLine(primeiroProduto.Nome);
Console.WriteLine(primeiroCategoria.Nome);

ServiceProvider ConfigurarInjecaoDeDependencia()
{
    var serviceCollection = new ServiceCollection();

    serviceCollection.AddScoped(typeof(IRepositorio<>), typeof(Repositorio<>));

    return serviceCollection.BuildServiceProvider();
}

/*O que foi feito aqui: Criamos uma coleção de serviços, onde informo qual interface eu quero e qual instancia ele vai retornar e configurei
No program foi naquele serviço e foi falado, onde retorna a instancia de quem implementa esta interface e me retorna um produto repositorio/categoria
