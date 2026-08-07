using System;
using System.Collections.Generic;

class Loop
{
    static void Main()
    {
        Console.Write("Enter a digit: ");
        int numero = int.Parse(Console.ReadLine());

        int repeticoes = 4;
        int linhas = 4;

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < repeticoes; j++)
            {
                if (i % 2 == 0)
                {
                    // Imprime o número seguido de um espaço
                    Console.Write(numero + " ");
                }
                else
                {
                    // Imprime apenas o número (sem espaço)
                    Console.Write(numero);
                }
            }

            // Pula de linha ao terminar cada volta do loop de fora
            Console.WriteLine();
        }
    }
}