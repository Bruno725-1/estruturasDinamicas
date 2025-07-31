using System;
using AED;
class TesteDic
{
    public static void Rodar()
    {
        CDicionario<string, string> dic = new CDicionario<string, string>();
        dic.Adiciona("Rone", "9919-5776");
        dic.Adiciona("Felipe Martins", "55 99379-6876");
        CDicionario<string, string> copia = new CDicionario<string, string>(dic);
        Console.WriteLine(copia.RetornaValor("Rone"));
        Console.WriteLine(copia.RetornaValor("Felipe Martins"));
        Console.WriteLine(copia.Quantidade());
    }
}