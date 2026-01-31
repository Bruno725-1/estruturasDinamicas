using System;
using System.Collections.Generic;
using AED;
class Program {
    public static void Main(string[] args)
    {
        CDicionario<int, int> dicionario = new CDicionario<int, int>();
        dicionario.Adiciona(2, 2222);
        //Dictionary<int, int> dic = new Dictionary<int, int>(dicionario);
    }
}