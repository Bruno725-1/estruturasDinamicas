using System;
using AED;
class Ex30
{
    public static void Rodar()
    {
        CDicionario<string, string> urls = new CDicionario<string, string>();
        urls.Adiciona("www.acessibilidadeemfoco.com", "77.37.127.178");
        urls.Adiciona("www.bengalalegal.com", "191.6.208.69");
        urls.Adiciona("www.deficienciavisual.com.br", "108.167.169.171");
        urls.Adiciona("www.qcsalon.net", "147.135.223.87");
        urls.Adiciona("www.visionvox.com.br", "172.67.181.107");
        urls.Adiciona("www.pudim.com.br", "85.31.231.84");
        urls.Adiciona("www.google.com", "74.125.234.81");
        urls.Adiciona("www.yahoo.com", "200.152.162.143");
        urls.Adiciona("www.amazon.com", "108.158.119.216");
        urls.Adiciona("www.uol.com.br", "201.65.128.144");
        urls.Adiciona("www.pucminas.br", "200.229.32.29");
        urls.Adiciona("www.microsoft.com", "23.211.10.99");
        urls.Adiciona("www.hotmail.com", "204.79.197.212");
        urls.Adiciona("www.gmail.com", "142.251.134.133");
        urls.Adiciona("www.x.com", "172.66.0.227");
        urls.Adiciona("www.brasil.gov.br", "170.246.255.242");
        Console.WriteLine("Digite o endereço do site para descobrir o ip. Para finalizar o programa, pressione ctrl+z e tecle enter");
        string linha;
        while ((linha = Console.ReadLine()) != null)
        {
            string ip = urls.RetornaValor(linha);
            Console.WriteLine(ip);
        }
        Console.WriteLine("Programa finalizado");
    }
}