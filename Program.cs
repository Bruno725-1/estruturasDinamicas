using System;
using AED;
class Program
{
    static void Main()
    {
        CLista<int> nomes = new CLista<int>();
        string linha;
        Console.WriteLine("Programa iniciado");
        while ((linha = Console.ReadLine()) != null)
        {
            nomes.InsereFim(int.Parse(linha));
        }
        nomes.Imprime();
        nomes.BubbleSort();
        Console.WriteLine("Lista após ordenação:");
        nomes.Imprime();
    }
}