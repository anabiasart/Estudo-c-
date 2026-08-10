using System;
using System.Collections.Generic;

namespace copias
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma string maior,  igual ou menos que 2 caracteres: ");
            string input = Console.ReadLine();

            if (input.Length > 2)
            {
                Console.WriteLine("A string digitada é maior que 2 caracteres.");

                string valor = input.Substring(0, 2) + input.Substring(0, 2)  + input.Substring(0, 2) + input.Substring(0, 2) + input.Substring(0, 2);

                Console.WriteLine("As duas primeiras letras da string digitada são: " + valor);

            }
            else
            {
                Console.WriteLine("A string digitada é menor ou igual a 2 caracteres.");
                Console.WriteLine("A string digitada é: " + input);
            }
        }
    }
}