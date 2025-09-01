using System;

class Program
{
    static void Main()
    {
        Console.Write("Está chovendo? (responda 'sim' ou 'não'): ");
        string resposta = Console.ReadLine().Trim().ToLower();

        if (resposta == "sim")
        {
            Console.WriteLine("Você deve levar guarda-chuva.");
        }
        else
        {
            Console.WriteLine("Não precisa levar guarda-chuva.");
        }
    }
}
