using System;

class diferenca
{
    static void Main(string[] args)
    {
        
      Console.WriteLine("Digite o primeiro número: ");
      int num1 = Convert.ToInt32(Console.ReadLine());

      if (num1 > 51)
        {
            Console.WriteLine(" triplo da diferença é: " + (num1 - 51) * 3);

        } else if  (num1 == 51  || num1 < 51)
        {
            Console.Write(51 - num1);
            Console.WriteLine("A diferença é: " + (51 - num1));
        } else
        {
            Console.Write(0);
        }




    }
}