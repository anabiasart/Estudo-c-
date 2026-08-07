using System;

class somagual {
static void Main(string[] args)
    {
        Console.WriteLine("Digite o primeiro número: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o segundo número: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 == 30 && num2 == 30)
        {
            Console.WriteLine("Numero verdadeiro a 30");
        }else if(num1 +num2 == 30)
        {
            Console.WriteLine("A soma é igual a 30: Verdadeiro");
        }
        else
        {
            Console.WriteLine("A soma não é igual a 30: Falso");
        }
     
}

}