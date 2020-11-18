using System;

namespace Atividade_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nota");
           
            Console.WriteLine("Digite sua nota de 0 a 10");
            int nota = int.Parse(Console.ReadLine());

            while(nota > 10)
            {
                Console.WriteLine("Voce digitou sua nota errada");
                Console.WriteLine("digite novamente");
                nota = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Sua nota esta correta");
           

        }
    }
}
