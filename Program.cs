using System;
using AED;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        CLista<int> lista = new CLista<int>();
        for (int i = 1; i <= 10; i++)
            lista.InsereFim(i);
        Console.WriteLine("Digite o número e o item antes do qual deseja inserir. Separe os números por espaços");
        string[] vetor = Console.ReadLine().Split(' ');
        int item = int.Parse(vetor[0]);
        int elemento = int.Parse(vetor[1]);
        lista.InsereDepoisDe(item, elemento);
        Console.WriteLine("Nova lista:");
        foreach (int valor in lista)
            Console.WriteLine(valor);
    }
}
