using System;

namespace ProjetoDeProdutos.classes
{
    public class Usuario
    {
        public Usuario(){
            
            Cadastrar();
        }
        public Usuario(int _codigo, string _nome, string _email, string _senha){
            Codigo = _codigo;
            Nome = _nome;
            Email = _email;
            Senha = _senha;
            DataCadastro = DateTime.UtcNow;

        }
        int Codigo { get; set; }
        string Nome { get; set;}
        string Email { get; set; }
        string Senha {get; set;}

        DateTime DataCadastro { get; set; }

        public void  Cadastrar(){
            Nome = "Paulo";
            Email = "admin@admin.com";
            Senha = "123456";
            DataCadastro = DateTime.UtcNow;
        }
        public void Deletar(){
            Nome = "";
            Email = "";
            Senha = "";
            DataCadastro = DateTime.Parse("0000-00-00T00:00:00");

        }
    }
}