using System;
using System.Collections.Generic;

namespace caracter {
    class Program
{
    static void Main(string[] args)
        {
            Console.WriteLine("Digite uma string:");
            string input = Console.ReadLine();

            string test = input.Remove(0, 1);

            Console.WriteLine("A string após remover o primeiro caractere é: " + test);

}
}}