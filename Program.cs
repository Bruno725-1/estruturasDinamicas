using System;
using System.Collections.Generic;
using AED;
class Program {
    public static void Main(string[] args)
    {
        CListaDup<int> lista = new CListaDup<int>();
        for(int i = 1; i <= 10; i++)
            lista.Adiciona(i);

        List<int> list = new List<int>(lista);
        Console.WriteLine($"Imprimindo a nova lista:");
        Console.WriteLine(string.Join(", ", list));
        Console.WriteLine($"Quantidade de itens da nova lista: {list.Count}");
        Console.WriteLine($"Capacidade da lista: {list.Capacity}");
        CLista<int> simples = new CLista<int>(list);
        Console.WriteLine("Imprimindo a lista simples:");
        Console.WriteLine(string.Join(", ", simples));
        CListaDup<int> dupla = new CListaDup<int>(list);
        Console.WriteLine("Imprimindo a lista dupla 2:");
        Console.WriteLine(string.Join(", ", dupla));
    }
}