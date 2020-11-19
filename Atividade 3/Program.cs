using System;

namespace Atividade_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Validacao de dados");
            Console.WriteLine("--------------");
            Console.WriteLine("Digite seu nome completo");
            string nome = Console.ReadLine();

            while(nome == "")
            {
                Console.WriteLine("O nome nao pode ser vazio");
                Console.WriteLine("Digite seu nome novamente");
                nome = Console.ReadLine();
            }

            Console.WriteLine("--------------");
            Console.WriteLine("Digite sua idade");
            int idade = int.Parse(Console.ReadLine());

            while(idade< 0 || idade > 150 )
            {
                Console.WriteLine("Digite sua idade correta!");
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

            bool Validacao = true;

            do
            {
                Console.WriteLine("--------------");
                Console.WriteLine("Digite seu estado civil");
                Console.WriteLine(" *s* para Solteiro(a)");
                Console.WriteLine(" *c* para Casado(a)");
                Console.WriteLine(" *v* para Viuvo(a)");
                Console.WriteLine(" *d* para Divorcido(a)");
                Console.WriteLine("--------------");
                string estadoCivil = Console.ReadLine();

                switch(estadoCivil.ToLower())
                {
                    case "s":
                        Console.WriteLine("Voce selecionou Solteiro");
                        Validacao = true;
                    break;

                    case "c":
                        Console.WriteLine("Voce selecionou Casado");
                        Validacao = true;
                    break;

                    case "v":
                        Console.WriteLine("Voce selecionou Viuvo");
                        Validacao = true;
                    break; 

                    case "d":
                        Console.WriteLine("Voce selecionou Divorciado");
                        Validacao = true;
                    break; 

                    default:
                        Console.WriteLine("Voce deve selecionar uma das opcoes abaixo");
                        Validacao = false;
                    break;
                }
                
            } while (Validacao == false);
            
            Console.WriteLine("--------------");
            Console.WriteLine("Seu cadastro foi concluido Sr(a) "+nome);

        }
    }
}
