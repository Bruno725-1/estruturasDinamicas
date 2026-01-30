using System;
using System.Collections.Generic;
using AED;
class Program {
    public static void Main(string[] args)
    {
        CDicionario<string, int> idades = new CDicionario<string, int>();
        int valor = idades.RetornaValor("Luma");
    }
}