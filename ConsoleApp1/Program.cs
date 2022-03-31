using System;

namespace ConsoleApp1 
{
    class Program 
    {
        public static void Main(string[] args) 
        {
            int numero;

            Console.WriteLine("Digite um numero de 1 a 7 para informar o dia da semana");
            numero = int.Parse(Console.ReadLine());

            if (numero >= 2 && numero <= 6)
            {Console.WriteLine("É dia útil");}

            else if (numero == 1 || numero == 7)
            {Console.WriteLine("Não é dia útil");}

        } 
    }
}
