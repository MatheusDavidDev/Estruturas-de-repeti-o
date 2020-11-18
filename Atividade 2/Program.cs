using System;

namespace Atividade_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Registro");
            Console.WriteLine("-----------------");
            Console.WriteLine("Crie seu usuario");
            string usuario = Console.ReadLine();

            Console.WriteLine("Crie sua senha");
            Console.WriteLine("-----------------");
            string senha = Console.ReadLine();

            while(senha == usuario)
            {
                Console.WriteLine("*Sua senha contem o mesmo nome do usuario*");
                Console.WriteLine("Digite a senha novamente");
                senha = Console.ReadLine();
            }

            Console.WriteLine("Confirme sua senha");
            string senhaConfirmada = Console.ReadLine();

            while(senha != senhaConfirmada)
            {
                Console.WriteLine("-----------------");
                Console.WriteLine("Suas senhas estao diferentes");
                Console.WriteLine("tente novamente");
                senhaConfirmada = Console.ReadLine();

            }
            Console.WriteLine("Cadastro concluido obrigado!!!");

        }
    }
}
