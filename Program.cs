using System;
using AED;
class Program {
    public static void Main(string[] args)
    {
        CLista<int> l = new CLista<int>();
        for (int i = 1; i <= 10; i++)
            l.InsereFim(i);
        for (int i = 1; i <= 10; i++)
            l.InsereFim(i);
        Console.WriteLine($"Primeira ocorrência de 8: {l.PrimeiraOcorrenciaDe(8)}");
        Console.WriteLine($"Última ocorrência de 5: {l.UltimaOcorrenciaDe(5)}");
        Console.WriteLine(l.PrimeiraOcorrenciaDe(56));
        Console.WriteLine(l.UltimaOcorrenciaDe(56));
        Console.WriteLine($"Elemento na posição 18 da lista: {l.RetornaIndice(18)}");
        l.AlteraIndice(18, 106);
        Console.WriteLine($"Elemento na posição 18 da lista: {l.RetornaIndice(18)}");
    }
}