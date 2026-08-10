using System;
//Verificar se uma string comeca com C#
namespace comeco
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma string: ");
            string str = Console.ReadLine();

            if (str.StartsWith("C#") || str.StartsWith("c#"))
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