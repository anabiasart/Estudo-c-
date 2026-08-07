using System;
using System.Collections.Generic;

class Tripla
{
   public static void Main()
    {
        Console.Write("Digite o primeiro numero: ");
        int numero1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo numero: ");
        int numero2 = int.Parse(Console.ReadLine());


        if (numero1 == numero2)
        {
            int soma3 = (numero1 + numero2) * 3;
            Console.WriteLine("A soma triplicada é: " + soma3);
        }
        else
        {
           int soma = numero1 + numero2;
            Console.WriteLine("A soma é: " + soma);
        }
    }
    }