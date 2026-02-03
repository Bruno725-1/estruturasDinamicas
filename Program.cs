using System;
using System.Collections.Generic;
using AED;

class Program
{
    static void Main()
    {
        CDicionario<string, string> cidades = new CDicionario<string, string>();
        cidades.InsereValor("Salvador", "Bahia");
        cidades.InsereValor("São Paulo", "São Paulo");
        cidades.InsereValor("Ribeirão Preto", "São Paulo");
        cidades.InsereValor("Carangola", "Minas Gerais");
        cidades.InsereValor("Caputira", "Minas Gerais");
        cidades.InsereValor("Belo Horizonte", "Minas Gerais");
        cidades.InsereValor("Rio de Janeiro", "Rio de Janeiro");
        cidades.InsereValor("Manaus", "Amazonas");
        cidades.InsereValor("Manaus", "Macapá");
        cidades.InsereValor("Salvador", "Tróia");
        foreach(CPar<string, string> kvp in cidades)
            Console.WriteLine($"{kvp.Chave}, {kvp.Valor}");

        Console.WriteLine($"Quantidade de itens: {cidades.Quantidade}");
    }
}
