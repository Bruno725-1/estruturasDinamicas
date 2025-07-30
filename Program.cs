using System;
using AED;
class Program {
    public static void Main(string[] args)
    {
        CPilha<int> p1 = new CPilha<int>();
        CPilha<int> p2 = new CPilha<int>();
        for (int i = 1; i <= 10; i++)
            p1.Empilha(i);
        for (int i = 11; i <= 20; i++)
            p2.Empilha(i);
        CPilha<int> concatenada = CPilha<int>.ConcatenaPilha(p1, p2);
        Console.WriteLine(concatenada.Quantidade());
        while (concatenada.Quantidade() > 0)
            Console.WriteLine(concatenada.Desempilha());
    }
}