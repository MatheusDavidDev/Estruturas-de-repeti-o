using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {

            //int contador = 0;
            int contador = 16; 
            int a = 0, b = 1, c = 0;

            Console.WriteLine("A sequencia Fibonacci até 500 tem "+contador+" sequencias: ");


            for (int i = 0; i < contador; i++)
            {   
                if (i < contador - 1)
                {
                    Console.Write(a + ",");
                }
                else{
                    Console.Write(a);
                }
                c = a + b;
                a = b;
                b = c;
            }







        }
    }
}
