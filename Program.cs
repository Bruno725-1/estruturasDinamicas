using System;
using System.Collections.Generic;
using AED;
class Program {
    public static void Main(string[] args)
    {
        CFila<int> fila = new CFila<int>();
        for(int i = 0; i < 10; i++)
            fila.Enfileira(i + 1);

        CPilha<int> pilha = new CPilha<int>(fila);
        foreach(int n in pilha)
            Console.WriteLine(pilha.Desempilha());

        Console.WriteLine(string.Join(", ", fila));
    }
}