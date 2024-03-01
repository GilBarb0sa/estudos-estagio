using Generics;
using Generics.Data;
using Generics.Domain;
using System;

var produtoRepositorio = new Repositorio<Produto>();
var categoriaRepositorio = new Repositorio<Categoria>();

produtoRepositorio.Adicionar(new Produto("Produto 01", 200));
produtoRepositorio.Adicionar(new Produto("Produto 02", 400));

categoriaRepositorio.Adicionar(new Categoria("Categoria 01"));
categoriaRepositorio.Adicionar(new Categoria("Categoria 02"));

ImprirDados.ImprimirDados(produtoRepositorio.ObterTodos());
ImprirDados.ImprimirDados(categoriaRepositorio.ObterTodos());

var primeiroProduto = produtoRepositorio.ObterTodos()[0];
var primeiroCategoria = categoriaRepositorio.ObterTodos()[0];

Console.WriteLine(primeiroProduto.Nome);
Console.WriteLine(primeiroCategoria.Nome);