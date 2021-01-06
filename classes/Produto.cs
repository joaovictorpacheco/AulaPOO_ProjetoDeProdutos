using System;
using System.Collections.Generic;

namespace ProjetoDeProdutos.classes
{
    public class Produto
    {
        public Produto(int codigo, string nomeProduto, float preco, DateTime dataCadastro, Marca marca, Usuario cadastradoPor) 
        {
            this.Codigo = codigo;
                this.NomeProduto = nomeProduto;
                this.Preco = preco;
                this.DataCadastro = dataCadastro;
                this.Marca = marca;
                this.CadastradoPor = cadastradoPor;
               
        }

        public Produto()
        {
        }

        public int Codigo { get; set;}
        public string NomeProduto {get; set;}
        public float Preco { get; set;}
        public DateTime DataCadastro { get; set;}
        public Marca Marca { get; set; }
        public Usuario CadastradoPor {get; set;}
        public List<Produto> ListaDeProdutos { get; set; }

        public void Cadastrar(){
            Produto novoProduto = new Produto();

            Console.WriteLine("Digite o código do Produto: ");
            novoProduto.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do Produto: ");
            novoProduto.NomeProduto = Console.ReadLine();

            Console.WriteLine("Digite o preço do produto:");
            novoProduto.Preco = float.Parse(Console.ReadLine());

            DataCadastro = DateTime.UtcNow;
            //Atribuimos nova marca atraves de um metodo criado por cadastro
            novoProduto.Marca = Marca.CadastrarMarca();

            novoProduto.CadastradoPor = new Usuario();

            ListaDeProdutos.Add(novoProduto);


        }
        public void Listar(){
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var item in ListaDeProdutos)
            {
                Console.WriteLine($"Codigo: {item.Codigo}");
                Console.WriteLine($"Produto: {item.NomeProduto}");
                Console.WriteLine($"Preço: {item.Preco}");
                Console.WriteLine($"Data de Cadastro: {item.DataCadastro}");
                Console.WriteLine($"Marca: {item.Marca.NomeMarca}");
                Console.WriteLine($"Cadastro por: {item.CadastradoPor.Nome}");
                Console.WriteLine();

            }
            Console.ResetColor();

        }
        public void Deletar(int cod){
            Produto prodDelete = ListaDeProdutos.Find(p => p.Codigo == cod);
            ListaDeProdutos.Remove(prodDelete);

        }
        
    }
}