using System;

namespace multiplo
{
    //verificar se um numero  positivo e multiplo de 3
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero positivo: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 3 == 0 || numero % 7 == 0)
            {
                Console.WriteLine("O numero " + numero + " é verdadeiro");
            }
            else
            {
                Console.WriteLine("O numero " + numero + " falso");
            }
            {
                
            }
        }
    }
}