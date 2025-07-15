using System;
using AED;
class Program
{
    static void Main(string[] args)
    {
        CFila<int> fila = new CFila<int>();
        for (int i = 1; i <= 10; i++)
            fila.Enfileira(i);
        for (int i = 1; i <= 10; i++)
            fila.Enfileira(i);
        Console.WriteLine("Pesquise um trem");
        int search = int.Parse(Console.ReadLine());
        int x = fila.OcorrenciasDe(search);
        Console.WriteLine($"O elemento {search} aparece {x} vezes na fila");
        Console.WriteLine(fila.Quantidade());
    }
}