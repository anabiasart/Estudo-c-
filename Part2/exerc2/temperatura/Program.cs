using System;
//escrever um programa que verifique se uma temperatura
//é menor que 0 e outra maior que 100
namespace temperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp;
            Console.WriteLine("Digite a primeira temperatura: ");
        int.TryParse(Console.ReadLine(), out temp);

            if(temp > 0 || temp >= 100)
            {
                Console.WriteLine("Verdadeiro");
            }
            else
            {
                Console.WriteLine("Falso");
            }
        }
    }
}