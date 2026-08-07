using System;

class Mensagem
{
    static void Main(string[] args)
    {
        int idade;
        Console.WriteLine("Digite sua idade: ");
        int.TryParse(Console.ReadLine(), out idade);
        
        Console.WriteLine("Você aparenta ter mais de " + idade + " anos.");
        }
}