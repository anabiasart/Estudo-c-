using System;
//criar uma string com o ultimo caracter adicionado no inicio e no final de uma string dada
//de comprimento igual ou superior a 1
namespace caracter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma string de comprimento igual ou superior a 1: ");
            string input = Console.ReadLine();

            if (input.Length >= 1)
            {
                char LastChar = input[input.Length - 1];
                string result = LastChar + input + LastChar;
                Console.WriteLine("Resultado: " + result);

            }else
            {
                Console.WriteLine("A string deve ter comprimento igual ou superior a 1.");
            }
        }
    }
}