using System;
using AED;

class Ex31
{
    public static void Rodar()
    {
        CDicionario<string, string> tabelaGenetica = PreencheTabela();
        Console.WriteLine("Digite uma trinca de RNA (ex: AUG), ou 'sair' para encerrar:");
        string entrada;
        while ((entrada = Console.ReadLine()) != "sair") //processa e converte a entrada para minúscula caso necessário
        {
            Console.Write("Trinca: ");
            string aminoacido = tabelaGenetica.RetornaValor(entrada);

            if (aminoacido != null)
                Console.WriteLine($"Aminoácido: {aminoacido}");
            else
                Console.WriteLine("Trinca inválida ou não encontrada!");
        }
    }
    static CDicionario<string, string> PreencheTabela()
    {
        CDicionario<string, string> tabelaGenetica = new CDicionario<string, string>();
        // Fenilalanina
        tabelaGenetica.Adiciona("UUU", "Fenilalanina");
        tabelaGenetica.Adiciona("UUC", "Fenilalanina");

        // Leucina
        tabelaGenetica.Adiciona("UUA", "Leucina");
        tabelaGenetica.Adiciona("UUG", "Leucina");
        tabelaGenetica.Adiciona("CUU", "Leucina");
        tabelaGenetica.Adiciona("CUC", "Leucina");
        tabelaGenetica.Adiciona("CUA", "Leucina");
        tabelaGenetica.Adiciona("CUG", "Leucina");

        // Isoleucina
        tabelaGenetica.Adiciona("AUU", "Isoleucina");
        tabelaGenetica.Adiciona("AUC", "Isoleucina");
        tabelaGenetica.Adiciona("AUA", "Isoleucina");

        // Metionina (início)
        tabelaGenetica.Adiciona("AUG", "Metionina");

        // Valina
        tabelaGenetica.Adiciona("GUU", "Valina");
        tabelaGenetica.Adiciona("GUC", "Valina");
        tabelaGenetica.Adiciona("GUA", "Valina");
        tabelaGenetica.Adiciona("GUG", "Valina");

        // Serina
        tabelaGenetica.Adiciona("UCU", "Serina");
        tabelaGenetica.Adiciona("UCC", "Serina");
        tabelaGenetica.Adiciona("UCA", "Serina");
        tabelaGenetica.Adiciona("UCG", "Serina");
        tabelaGenetica.Adiciona("AGU", "Serina");
        tabelaGenetica.Adiciona("AGC", "Serina");

        // Prolina
        tabelaGenetica.Adiciona("CCU", "Prolina");
        tabelaGenetica.Adiciona("CCC", "Prolina");
        tabelaGenetica.Adiciona("CCA", "Prolina");
        tabelaGenetica.Adiciona("CCG", "Prolina");

        // Treonina
        tabelaGenetica.Adiciona("ACU", "Treonina");
        tabelaGenetica.Adiciona("ACC", "Treonina");
        tabelaGenetica.Adiciona("ACA", "Treonina");
        tabelaGenetica.Adiciona("ACG", "Treonina");

        // Alanina
        tabelaGenetica.Adiciona("GCU", "Alanina");
        tabelaGenetica.Adiciona("GCC", "Alanina");
        tabelaGenetica.Adiciona("GCA", "Alanina");
        tabelaGenetica.Adiciona("GCG", "Alanina");

        // Tirosina
        tabelaGenetica.Adiciona("UAU", "Tirosina");
        tabelaGenetica.Adiciona("UAC", "Tirosina");

        // Parada
        tabelaGenetica.Adiciona("UAA", "Parada");
        tabelaGenetica.Adiciona("UAG", "Parada");
        tabelaGenetica.Adiciona("UGA", "Parada");

        // Histidina
        tabelaGenetica.Adiciona("CAU", "Histidina");
        tabelaGenetica.Adiciona("CAC", "Histidina");

        // Glutamina
        tabelaGenetica.Adiciona("CAA", "Glutamina");
        tabelaGenetica.Adiciona("CAG", "Glutamina");

        // Asparagina
        tabelaGenetica.Adiciona("AAU", "Asparagina");
        tabelaGenetica.Adiciona("AAC", "Asparagina");

        // Lisina
        tabelaGenetica.Adiciona("AAA", "Lisina");
        tabelaGenetica.Adiciona("AAG", "Lisina");

        // Ácido aspártico
        tabelaGenetica.Adiciona("GAU", "Ácido aspártico");
        tabelaGenetica.Adiciona("GAC", "Ácido aspártico");

        // Ácido glutâmico
        tabelaGenetica.Adiciona("GAA", "Ácido glutâmico");
        tabelaGenetica.Adiciona("GAG", "Ácido glutâmico");

        // Cisteína
        tabelaGenetica.Adiciona("UGU", "Cisteína");
        tabelaGenetica.Adiciona("UGC", "Cisteína");

        // Triptofano
        tabelaGenetica.Adiciona("UGG", "Triptofano");

        // Arginina
        tabelaGenetica.Adiciona("CGU", "Arginina");
        tabelaGenetica.Adiciona("CGC", "Arginina");
        tabelaGenetica.Adiciona("CGA", "Arginina");
        tabelaGenetica.Adiciona("CGG", "Arginina");
        tabelaGenetica.Adiciona("AGA", "Arginina");
        tabelaGenetica.Adiciona("AGG", "Arginina");

        // Glicina
        tabelaGenetica.Adiciona("GGU", "Glicina");
        tabelaGenetica.Adiciona("GGC", "Glicina");
        tabelaGenetica.Adiciona("GGA", "Glicina");
        tabelaGenetica.Adiciona("GGG", "Glicina");
        return tabelaGenetica;
    }
}