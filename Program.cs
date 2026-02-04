using System;
using AED;

class Program
{
    static void Main()
    {
        CDicionario<int, string> dicionario = new CDicionario<int, string>();
        Console.WriteLine("Escreve 10 nomes");
        for(int i = 1; i <= 10; i++)
            dicionario.Adiciona(i, Console.ReadLine());

        CDicionario<int, string> dicionario2 = new CDicionario<int, string>();
        Console.WriteLine("Escreve mais 10 nomes");
        for(int i = 11; i <= 20; i++)
            dicionario2.Adiciona(i, Console.ReadLine());

        CDicionario<int, string> concatenado = CDicionario<int, string>.ConcatenaDicionario(dicionario, dicionario2);
        Console.WriteLine("Iterando pela coleção concatenada:");
        foreach(CPar<int, string> par in concatenado)
            Console.WriteLine($"{par.Chave}: {par.Valor}");
    }
}
