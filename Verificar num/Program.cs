using System;

namespace verificar{

    class Program
{
    static void Main(string [] args)
        {
            Console.WriteLine("Digite um numero inteiro:");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num + 10 ==100 || num +10 == 200)
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