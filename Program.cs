using System;
using AED;
class Program {
    public static void Main(string[] args)
    {
        CLista<int> num = new CLista<int>();
        for (int i = 1; i <= 50; i++)
            num.InsereFim(i);
        Console.WriteLine("Impressa normalmente:");
        num.Imprime();
        Console.WriteLine("Impressa ao contrário:");
        num.ImprimeInv();
    }
}