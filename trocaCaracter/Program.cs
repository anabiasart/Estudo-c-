using System;

namespace troca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma palavra para fazermos a troca:");
            string palavra = Console.ReadLine();

            // Chama o método test e armazena o resultado
            string resultado = test(palavra);

            Console.WriteLine($"Resultado: {resultado}");
        }

        public static string test(string str)
        {
            // Se a palavra tiver mais de 1 caractere, troca o primeiro com o último
            return str.Length > 1
                ? str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1)
                : str;
        }
    }
}