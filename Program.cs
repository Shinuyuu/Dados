using System.Security.Cryptography;

void Shin(string frase, int fun)
{
    if (fun == 00)
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
    }
    else if (fun == 01)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
    }
        else if (fun == 02)
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
    }
for (int i = 00; i < frase.Length; i++)
{
Console.Write(frase[i]);
Thread.Sleep(45);
}
}
Console.Clear();
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("================Dado================");

Shin("Quantas faces/lados o dado possue: ",01);
Console.ForegroundColor = ConsoleColor.White;
int faces = int.Parse(Console.ReadLine()!);
Console.WriteLine("====================================");
Shin("Pressione qualquer tecla para ver o Resultado",01);
Console.ReadKey();
Console.Clear();
int resultado = RandomNumberGenerator.GetInt32(1,faces+1);
    Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("<================================>");
Shin($"Resultado da sua rolagem foi: {resultado}\n",01);
    Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("<================================>");
Console.ResetColor();
