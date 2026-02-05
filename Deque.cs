using System;
using AED;
class Deque
{
    public static void Rodar()
    {
        // criando um deque de números
        CDeque<int> deque = new CDeque<int>();
        for(int i = 1; i <= 10; i++)
            deque.AdicionaDireito(i);

        Console.WriteLine("Deque após AdicionaDireito: " + string.Join(", ", deque));

        // RetornaEsquerdo - retorna o elemento da esquerda sem removê-lo
        Console.WriteLine($"Elemento na esquerda: {deque.RetornaEsquerdo()}");

        // RetornaDireito - retorna o elemento da direita sem removê-lo
        Console.WriteLine($"Elemento na direita: {deque.RetornaDireito()}");

        // Contem - verifica se um elemento está no deque
        Console.WriteLine($"O deque contém 8? {deque.Contem(8)}");
        Console.WriteLine($"O deque contém 25? {deque.Contem(25)}");

        // Quantidade - quantidade de elementos no deque
        Console.WriteLine("Quantidade de elementos no deque: " + deque.Quantidade);

        // RemoveRetornaEsquerdo - remove e retorna o elemento da esquerda
        int esq = deque.RemoveRetornaEsquerdo();
        Console.WriteLine($"Elemento removido (RemoveRetornaEsquerdo): {esq}");

        // RemoveRetornaDireito - remove e retorna o elemento da direita
        int dir = deque.RemoveRetornaDireito();
        Console.WriteLine($"Elemento removido (RemoveRetornaDireito): {dir}");

        // AdicionaEsquerdo - adiciona um elemento na esquerda do deque
        deque.AdicionaEsquerdo(256);

        Console.WriteLine("Deque após alterações:");
        foreach(int num in deque)
            Console.Write(num + ", ");
        Console.WriteLine();

        // O deque também possibilita iteração de forma reversa
        Console.WriteLine("Iterando de forma reversa (da direita pra esquerda):");
        foreach(int num in deque.EnumerarReverso())
            Console.Write(num + ", ");
        Console.WriteLine();

        // Limpar - remove todos os elementos do deque
        deque.Limpar();
        Console.WriteLine("Deque após Limpar: " + string.Join(", ", deque));
        Console.WriteLine($"Quantidade de itens no deque após Limpar: {deque.Quantidade}");
    }
}