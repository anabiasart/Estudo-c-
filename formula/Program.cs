using System;

class Formula
{
    static void Main(string[] args)
    {
        int x, y, z;

        Console.WriteLine("Digite o valor do primeiro numero: ");
        int.TryParse(Console.ReadLine(), out x);

        Console.WriteLine("Digite o valor do segundo numero: ");
        int.TryParse(Console.ReadLine(), out y);

        Console.WriteLine("Digite o valor do terceiro numero: ");
        int.TryParse(Console.ReadLine(), out z);


        int resultado = (x + y) * z;
        Console.WriteLine("O resultado da fórmula é: " + resultado);

        int soma = x * y + y * z;
        Console.WriteLine("O resultado da soma é: " + soma);

        Console.WriteLine("Output: ({0} + {1}) * {2} = {3}", x, y, z, resultado);
        Console.WriteLine("Output: {0} * {1} + {1} * {2} = {3}", x, y, z, soma);
    }
}

