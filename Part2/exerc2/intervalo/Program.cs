using System;
//escrever um programa para verificar se dois numero inteiros
//estão no intervalo de 100 a 200
namespace inteiro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero inteiro: ");
            int num1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o segundo numero: ");
            int num2 = int.Parse(Console.ReadLine());
            
            
            if (num1 == 100 || num1 < 200 && num2 == 100 || num2 <= 200)
            {
                Console.WriteLine("Verdadeiros");
                Console.WriteLine("Numeros: " + num1  +  num2);

            }else if(num1 < 100 || num1 > 200 && num2 < 100 || num2 > 200)
            {
                Console.WriteLine("Falsos");
                Console.WriteLine("Numeros: "+ num1, num2);
            }
            else
            {
                Console.WriteLine("Invalido");
            }
        }
    }
}