using System;
using AED;
class Fila
{
    public static void Rodar()
    {
        // Criando uma fila de strings
        CFila<string> fila = new CFila<string>();
        // Enfileira - adiciona elementos ao final da fila
        fila.Enfileira("João");
        fila.Enfileira("Maria");
        fila.Enfileira("Carlos");
        Console.WriteLine("Fila após Enfileira: " + String.Join(", ", fila));

        // Peek - retorna o elemento do início sem removê-lo
        string primeiro = fila.Peek();
        Console.WriteLine($"Primeiro da fila (Peek): {primeiro}");

        // Contem - verifica se um elemento está na fila
        Console.WriteLine("A fila contém 'Maria'? " + fila.Contem("Maria"));
        Console.WriteLine("A fila contém 'Ana'? " + fila.Contem("Ana"));

        // Quantidade - quantidade de elementos na fila
        Console.WriteLine("Quantidade de elementos na fila: " + fila.Quantidade);

        // Desenfileira - remove e retorna o primeiro elemento da fila
        string removido = fila.Desenfileira();
        Console.WriteLine($"Elemento removido (Desenfileira): {removido}");
        Console.WriteLine("Fila após Desenfileira: " + string.Join(", ", fila));
        // Limpar - remove todos os elementos da fila
        fila.Limpar();
        Console.WriteLine("Fila após Limpar: " + string.Join(", ", fila));
        Console.WriteLine("Quantidade após Limpar: " + fila.Quantidade);
    }
}