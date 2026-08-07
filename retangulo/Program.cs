using System;
using System.Collections.Generic;

class Retangular
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int numero = int.Parse(Console.ReadLine());

        int repeticoes = 3; // Largura do retângulo
        int linhas = 5;     // Altura do retângulo

        for (int i = 0; i < linhas; i++)
        {
            // Se for a PRIMEIRA (i == 0) ou a ÚLTIMA (i == linhas - 1) linha
            if (i == 0 || i == linhas - 1)
            {
                for (int j = 0; j < repeticoes; j++)
                {
                    Console.Write(numero); // Imprime 555 na mesma linha
                }
            }
            // Para as linhas do MEIO
            else
            {
                Console.Write(numero + " " + numero); // Imprime 5 5
            }

            // Pula para a próxima linha do console
            Console.WriteLine();
        }
    }
}