using System;
using System.Linq;
using AED;
class TempoDeResposta
{
    public static void Rodar()
    {
        int n = int.Parse(Console.ReadLine());
        CDicionario<int, int> temposResposta = new CDicionario<int, int>();
        CDicionario<int, int> pendentes = new CDicionario<int, int>();
        int tempoAtual = 0; // Marca o tempo absoluto na simulação
        for (int i = 0; i < n; i++)
        {
            string[] registro = Console.ReadLine().Split(' ');
            char tipo = registro[0][0];
            int x = int.Parse(registro[1]);
            if (tipo == 'R')
            {
                // Sara recebeu uma mensagem de um amigo X
                pendentes.Adiciona(x, tempoAtual);
                tempoAtual++;
            }
            else if (tipo == 'E')
            {
                // Sara respondeu a um amigo X
                if (pendentes.ContemChave(x))
                {
                    int tempoResposta = tempoAtual - pendentes.RetornaValor(x);
                    if (!temposResposta.ContemChave(x))
                        temposResposta.Adiciona(x, 0);
                    int v = temposResposta.RetornaValor(x);
                    temposResposta.InsereValor(x, v += tempoResposta);
                    pendentes.Remove(x); // a mensagem foi respondida
                }
                tempoAtual++;
            }
            else if (tipo == 'T')
            {
                //avança o tempo x segundos
                tempoAtual += x - 1; //como o tempo já avança em 1, retrocedemos 1
            }
        }

        //amigos que possuem mensagens sem resposta recebem tempo -1
        foreach (var amigo in pendentes.Chaves())
        {
            temposResposta.InsereValor(amigo, -1);
        }

        // Exibir a saída ordenada pelos números dos amigos
        int[] keys = temposResposta.Chaves();
        int[] values = temposResposta.Valores();
        Array.Sort(keys, values); // ordena pelas chaves mantendo os valores juntos
        for (int i = 0; i < keys.Length; i++)
            Console.WriteLine($"{keys[i]} {values[i]}");
    }
}