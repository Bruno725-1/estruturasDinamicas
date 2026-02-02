using System;
using System.Collections.Generic;
using AED;
class Program {
    public static void Main(string[] args)
    {
        Console.WriteLine("Programa iniciado.");
        CDicionario<int, int> dic = new CDicionario<int, int>();
        for(int i = 1; i <= 10; i++)
            dic.Adiciona(i, i + 1);

        Console.WriteLine("Imprimindo o CDicionario:");
        foreach(CPar<int, int> kvp in dic)
            Console.WriteLine($"{kvp.Chave}, {kvp.Valor}");
        Dictionary<int, int> dictionary = new Dictionary<int, int>(dic);
        Console.WriteLine("Imprimindo o novo dictionary:");
        foreach(KeyValuePair<int, int> kvp in dictionary)
            Console.WriteLine($"{kvp.Key}, {kvp.Value}");
        dic.Limpar();
        Console.WriteLine(dic.Quantidade);
    }
}