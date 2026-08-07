using System;

namespace ausente
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Se a string ja estiver com if no comeco, retorne sem alterar");
            Console.WriteLine("Digite a string:");
            string input = Console.ReadLine();

            if (input.StartsWith("if"))
            {
                Console.WriteLine("A string já começa com 'if'. Retornando sem alterações: " + input);
            }
            else
            {
                string modifiedInput = "if " + input;
                Console.WriteLine("A string foi modificada para começar com 'if': " + modifiedInput);
            }



        }
    }
}