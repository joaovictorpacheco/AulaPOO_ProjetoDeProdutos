using System;

namespace ProjetoDeProdutos.classes
{
    public class Login
    {
        public Login(bool logado) 
        {
            this.Logado = logado;
               
        }
                public bool Logado {get; set;}
        public void Logar(Usuario usuario){
            Console.WriteLine("Digite seu Email:");
            string emailLogin = Console.ReadLine();

            Console.WriteLine("Digite sua Senha:");
            string senhaLogin = Console.ReadLine();

            if(emailLogin == usuario.Email && senhaLogin == usuario.Senha);


        }
    }
}