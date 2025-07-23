using System;
using AED;
class Program {
    public static void Main(string[] args)
    {
        CPilha<int> pilha = new CPilha<int>();
        for (int i = 1; i <= 10; i++)
        {
            pilha.Empilha(i);
        }
        Console.WriteLine("Imprimindo a pilha:");
        Console.WriteLine(pilha.Quantidade());
        CFila<int> fila = new CFila<int>(pilha);
        foreach (int n in pilha)
            Console.Write(n + ", ");
        Console.WriteLine();
        Console.WriteLine("Fila criada a partir da pilha:");
        foreach (int n in fila)
            Console.Write(n + ", ");
        Console.WriteLine();
        Console.WriteLine($"Quantidade da fila: {fila.Quantidade()}");
        Console.WriteLine($"Quantidade da pilha: {pilha.Quantidade()}");
    }
}