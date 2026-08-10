using System;
Console.WriteLine("digite uma string por gentileza:");
string input = Console.ReadLine();

if (input.Length < 3)
{
    Console.WriteLine("A string fornecida é menor que 3 caracteres.");
    return;
}
else
{
    Console.WriteLine("A string fornecida é: " + input);

    string front = input.Substring(0, 3) + input.Substring(0, 3);
    string valor = input.Substring(input.Length - 3) + input.Substring(input.Length - 3);
    string result = front + valor + front;
    Console.WriteLine("Resultado: " + result);


}
