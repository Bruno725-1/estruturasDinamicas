using System;
using AED;
class Program {
    public static void Main(string[] args)
    {
        CDicionario<string, double> agenda = new CDicionario<string, double>();
        string linha;
        while ((linha = Console.ReadLine()) != null)
        {
            string[] dados = linha.Split(' ');
            agenda.Adiciona(dados[0], double.Parse(dados[1]));
        }
        Console.WriteLine("Dicionário antes da ordenação:");
        foreach (string c in agenda.Chaves())
            Console.WriteLine(c + ": " + agenda.RetornaValor(c));
        agenda.Ordenar();
        Console.WriteLine("Impressão do dicionário ordenado:");
        foreach (string c in agenda.Chaves())
            Console.WriteLine(c + ": " + agenda.RetornaValor(c));
    }
}