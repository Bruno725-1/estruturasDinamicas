using System;
using AED;
class Pilha
{
    public static void Rodar()
    {
        // Criando uma pilha de strings
        CPilha<string> pilha = new CPilha<string>();

        // Empilha - adiciona elementos ao topo da pilha
        pilha.Empilha("Livro");
        pilha.Empilha("Caderno");
        pilha.Empilha("Caneta");
        Console.WriteLine("Pilha após Empilha: " + string.Join(", ", pilha));

        // Peek - retorna o elemento do topo sem removê-lo
        string topo = pilha.Peek();
        Console.WriteLine($"Elemento no topo (Peek): {topo}");
        // Contem - verifica se um elemento está na pilha
        Console.WriteLine("A pilha contém 'Caderno'? " + pilha.Contem("Caderno"));
        Console.WriteLine("A pilha contém 'Lápis'? " + pilha.Contem("Lápis"));

        // Quantidade - quantidade de elementos na pilha
        Console.WriteLine("Quantidade de elementos na pilha: " + pilha.Quantidade);

        // Desempilha - remove e retorna o elemento do topo
        string removido = pilha.Desempilha();
        Console.WriteLine($"Elemento removido (Desempilha): {removido}");
        Console.WriteLine("Pilha após Desempilha: " + string.Join(", ", pilha));

        // Limpar - remove todos os elementos
        pilha.Limpar();
        Console.WriteLine("Pilha após limpar: " + string.Join(", ", pilha));
        Console.WriteLine("Quantidade após Limpar: " + pilha.Quantidade);
    }
}