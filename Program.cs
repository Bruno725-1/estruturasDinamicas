using System;
using AED;
class Program
{
    static void Main(string[] args)
    {
        CLista<int> lista = new CLista<int>();
        for (int i = 1; i <= 10; i++)
            lista.InsereFim(i);
        for (int i = 1; i <= 10; i++)
            lista.InsereFim(i);
        Console.WriteLine("Digite o índice a remover");
        while (true)
        {
            int index = int.Parse(Console.ReadLine());
            if (index == -1) break;
            lista.RemovePos(index);
        }
        Console.WriteLine("Lista após RemovePos:");
        Console.WriteLine(string.Join(", ", lista));
        Console.WriteLine(lista.Quantidade());
    }
}