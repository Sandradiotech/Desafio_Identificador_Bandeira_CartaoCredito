using System;
using IdentificadorCartao.Models;

class Program
{
    static void Main()
    {
        Console.WriteLine("======================================");
        Console.WriteLine("  IDENTIFICADOR DE BANDEIRA DE CARTÃO");
        Console.WriteLine("======================================");
        Console.WriteLine();

        Console.Write("Digite o número do cartão: ");
        string numero = Console.ReadLine() ?? "";

        Cartao cartao = new Cartao(numero);

        Console.WriteLine();
        Console.WriteLine($"Número informado: {cartao.Numero}");
        Console.WriteLine($"Bandeira identificada: {cartao.Bandeira}");

        Console.WriteLine();
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
