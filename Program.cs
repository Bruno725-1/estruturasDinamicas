using System;
using System.Collections.Generic;
using AED;

class Program
{
    static void Main()
    {
        CDeque<int> deque = new CDeque<int>();
        CDeque<int> d2 = new CDeque<int>();
        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("1: Adicionar do lado direito.");
        Console.WriteLine("2: Adicionar do lado esquerdo.");
        Console.WriteLine("3: Remover e retornar esquerdo");
        Console.WriteLine("4: Remover e retornar direito");
        Console.WriteLine("0: Sair.");
        bool rodando = true;
        while (rodando)
        {
            int opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    deque.AdicionaDireito(int.Parse(Console.ReadLine()));
                    break;
                case 2:
                    deque.AdicionaEsquerdo(int.Parse(Console.ReadLine()));
                    break;
                case 3:
                    d2.AdicionaDireito(int.Parse(Console.ReadLine()));
                    break;
                case 4:
                    d2.AdicionaEsquerdo(int.Parse(Console.ReadLine()));
                    break;
                case 0:
                    rodando = false;
                    break;
            }
        }
        Console.WriteLine("Iterando sobre o deque concatenado:");
        CDeque<int> concatenado = CDeque<int>.ConcatenaDeque(deque, d2);
        foreach(int n in concatenado)
            Console.Write($"{n}, ");

        Console.WriteLine();
        Console.WriteLine("Iterando inversamente sobre o deque concatenado:");
        foreach(int n in concatenado.EnumerarReverso())
            Console.Write($"{n}, ");
    }
}
