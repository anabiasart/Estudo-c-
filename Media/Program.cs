using System;

class Contador
{
   public static void Main(string[] args){
        int num1,num2,num3,num4;

        Console.WriteLine("Digite o primeiro número: ");  
        int.TryParse(Console.ReadLine(), out num1);

        Console.WriteLine("Digite o segundo número: ");  
        int.TryParse(Console.ReadLine(), out num2);     

        Console.WriteLine("Digite o terceiro número: ");  
        int.TryParse(Console.ReadLine(), out num3);

        Console.WriteLine("Digite o quarto número: ");  
        int.TryParse(Console.ReadLine(), out num4);


        int soma = num1 + num2 + num3 + num4;

        int media = soma / 4;

        Console.WriteLine("A soma dos números é: " + soma);
        Console.WriteLine("A média dos números é: " + media);

        Console.WriteLine("Output: {0} + {1} + {2} + {3} = {4}", num1, num2, num3, num4, soma);
        Console.Write("Output: A media de  {0},{1},{2},{3}, é: {4}", num1, num2, num3, num4, media);
    }
}