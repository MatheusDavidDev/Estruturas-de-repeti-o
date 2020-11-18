using System;

namespace Atividade_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("programa");
            Console.WriteLine("--------------");
            Console.WriteLine("Digite seu nome completo");
            string nome = Console.ReadLine();

            Console.WriteLine("--------------");
            Console.WriteLine("Digite sua idade");
            int idade = int.Parse(Console.ReadLine());

            while(idade >150 )
            {
                Console.WriteLine("Digite sua correta!");
                idade = int.Parse(Console.ReadLine());                
            }

            Console.WriteLine("--------------");
            Console.Write("Digite seu salario: R$");
            float salario = float.Parse(Console.ReadLine());

            while(salario <= 0)
            {
                Console.WriteLine("Seu salario esta errado");
                Console.Write("Digite seu salario novamente: R$");
                salario = float.Parse(Console.ReadLine());
            }

            Console.WriteLine("--------------");
            Console.WriteLine("Digite seu estado civil");
            Console.WriteLine(" *1* para Solteiro(a)");
            Console.WriteLine(" *2* para Casado(a)");
            Console.WriteLine(" *3* para Viuvo(a)");
            Console.WriteLine(" *4* para Divorcido(a)");
            Console.WriteLine("--------------");
            int estadoCivil = int.Parse(Console.ReadLine());

            while(estadoCivil < 1 || estadoCivil > 4)
            {
                Console.WriteLine("Voce digitou a opcao errada tente novamente e digite:");
                Console.WriteLine(" *1* para Solteiro(a)");
                Console.WriteLine(" *2* para Casado(a)");
                Console.WriteLine(" *3* para Viuvo(a)");
                Console.WriteLine(" *4* para Divorcido(a)");
                Console.WriteLine("--------------");
                estadoCivil = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("--------------");
            Console.WriteLine("Seu cadastro foi concluido Sr(a) "+nome);

        }
    }
}
