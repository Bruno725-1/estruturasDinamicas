using System;
using AED;
class Lista
{
    public static void Rodar()
    {
        // Criando uma lista de inteiros
        CLista<int> numeros = new CLista<int>();

        // Adiciona - adiciona elementos à lista
        numeros.Adiciona(10);
        numeros.Adiciona(50);
        numeros.Adiciona(30);
        numeros.Adiciona(40);
        numeros.Adiciona(20);
        Console.WriteLine("Lista após Adiciona: " + string.Join(", ", numeros));

        // Limpar - remove todos os elementos
        CLista<int> outraLista = new CLista<int>(new int[]{1, 2, 3});
        outraLista.Limpar();
        Console.WriteLine("Outra lista após Limpar: " + string.Join(", ", outraLista));

        // Contem - verifica se um elemento existe
        Console.WriteLine("Contém 20? " + numeros.Contem(20));

        // Quantidade - propriedade que retorna o número de elementos
        Console.WriteLine("Quantidade de elementos: " + numeros.Quantidade);

        // PrimeiraOcorrenciaDe - retorna a primeira ocorrência de um elemento
        Console.WriteLine("Índice do 30: " + numeros.PrimeiraOcorrenciaDe(30));

        // InsereIndice - insere um elemento em um índice específico
        // A lista começa apartir do índice 1
        numeros.InsereIndice(25, 3); // insere 25 na posição 3
        Console.WriteLine("Lista após InsereIndice: " + string.Join(", ", numeros));

        // UltimaOcorrenciaDe - última ocorrência
        numeros.Adiciona(30);
        Console.WriteLine("Último índice do 30: " + numeros.UltimaOcorrenciaDe(30));

        // Remove - remove a primeira ocorrência do valor
        numeros.Remove(30);
        Console.WriteLine("Lista após Remove(30): " + string.Join(", ", numeros));

        // RemoveIndice - remove pelo índice
        numeros.RemoveIndice(1); // remove o primeiro elemento
        Console.WriteLine("Lista após RemoveIndice(1): " + string.Join(", ", numeros));

        // Inverte - inverte a ordem da lista
        numeros.Inverte();
        Console.WriteLine("Lista após Inverte: " + string.Join(", ", numeros));

        // Ordenar - ordena a lista
        numeros.Ordenar();
        Console.WriteLine("Lista após Ordenar: " + string.Join(", ", numeros));

        // ParaVetor - converte para array
        int[] array = numeros.ParaVetor();
        Console.WriteLine("Array convertido da lista: " + string.Join(", ", array));
    }
}