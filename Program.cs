using System;
using AED;
class Program {
    public static void Main(string[] args)
    {
        int[] v = new int[20];
        Random rand = new Random();
        for (int i = 0; i < v.Length; i++)
            v[i] = rand.Next(1, 41);
        Console.WriteLine("Vetor após ser preenchido:");
        Console.WriteLine(string.Join(", ", v));
        CLista<int> fila = new CLista<int>(v);
        Console.WriteLine("Lista criada a partir do vetor:");
        Console.WriteLine(string.Join(", ", fila));
        Console.WriteLine(v.Length);
        Console.WriteLine(fila.Quantidade());
    }
}