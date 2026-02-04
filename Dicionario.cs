using System;
using AED;
class Dicionario
{
    public static void Rodar()
    {
        // Criando o dicionário
        CDicionario<string, string> capitais = new CDicionario<string, string>();

        // Adiciona - adiciona pares chave-valor
        capitais.Adiciona("MG", "Belo Horizonte");
        capitais.Adiciona("SP", "São Paulo");
        capitais.Adiciona("RJ", "Rio de Janeiro");
        Console.WriteLine("A capital de MG é " + capitais.RetornaValor("MG"));
        Console.WriteLine("Dicionário após Adiciona:");
        MostrarDicionario(capitais);

        // ContemChave - verifica se uma chave existe
        Console.WriteLine("Contém a chave 'SP'? " + capitais.ContemChave("SP"));
        Console.WriteLine("Contém a chave 'BA'? " + capitais.ContemChave("BA"));

        // ContemValor - verifica se um valor existe
        Console.WriteLine("Contém o valor 'São Paulo'? " + capitais.ContemValor("São Paulo"));
        Console.WriteLine("Contém o valor 'Salvador'? " + capitais.ContemValor("Salvador"));

        // Remove - remove um par chave-valor
        capitais.Remove("SP");
        Console.WriteLine("Dicionário após remover 'SP':");
        MostrarDicionario(capitais);

        // Quantidade - quantidade de elementos no dicionário
        Console.WriteLine($"Total de elementos: {capitais.Quantidade}");

        // Chaves - método que retorna um array contendo todas as chaves
        Console.WriteLine("Chaves:");
        foreach (string chave in capitais.Chaves())
            Console.WriteLine(chave);

        // Valores - retorna um array com todos os valores
        Console.WriteLine("Valores:");
        foreach (string valor in capitais.Valores())
            Console.WriteLine(valor);

        // Limpar - remove todos os elementos
        capitais.Limpar();
        Console.WriteLine("Dicionário após Limpar:");
        MostrarDicionario(capitais);
    }

    static void MostrarDicionario(CDicionario<string, string> dict)
    {
        if (dict.Quantidade == 0)
        {
            Console.WriteLine("(vazio)");
            return;
        }

        foreach (var item in dict)
        {
            Console.WriteLine($"{item.Chave} => {item.Valor}");
        }
    }
}