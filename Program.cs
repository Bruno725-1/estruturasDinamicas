using System;
using AED;
class Program {
    public static void Main(string[] args)
    {
        CDicionario<int, string> nomes = new CDicionario<int, string>();
        string linha;
        while ((linha = Console.ReadLine()) != null)
        {
            string[] valores = linha.Split(' ');
            nomes.Adiciona(int.Parse(valores[0]), valores[1]);
        }
        Console.WriteLine("Imprimindo o dicionário com foreach:");
        foreach (CPar<int, string> dados in nomes)
            Console.WriteLine($"{dados.Chave}: {dados.Valor}");
        Console.WriteLine($"Quantidade de itens no dicionário: {nomes.Quantidade()}");
        CListaDup<int> lista = new CListaDup<int>();
        for (int i = 1; i <= 10; i++)
            lista.InsereFim(i);
        lista.Inverte();
        Console.WriteLine("Imprimindo a lista com foreach:");
        foreach (int num in lista)
            Console.Write(num + ", ");
    }
}