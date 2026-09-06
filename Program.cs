using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("======================================");
        Console.WriteLine("  IDENTIFICADOR DE BANDEIRA DE CARTÃO");
        Console.WriteLine("======================================");
        Console.WriteLine();

        Console.Write("Digite o número do cartão: ");
        string numeroCartao = Console.ReadLine() ?? "";

        // Remove espaços, hífens e outros caracteres
        numeroCartao = Regex.Replace(numeroCartao, @"\D", "");

        string bandeira = IdentificarBandeira(numeroCartao);

        Console.WriteLine();
        Console.WriteLine($"Bandeira identificada: {bandeira}");
        Console.WriteLine();
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }

    static string IdentificarBandeira(string numero)
    {
        // Visa
        if (Regex.IsMatch(numero, @"^4\d{12}(\d{3})?$"))
        {
            return "Visa";
        }

        // MasterCard
        if (Regex.IsMatch(numero, @"^(5[1-5]\d{14}|2(2[2-9]\d{2}|[3-6]\d{3}|7[01]\d{2}|720\d)\d{12})$"))
        {
            return "MasterCard";
        }

        // American Express
        if (Regex.IsMatch(numero, @"^3[47]\d{13}$"))
        {
            return "American Express";
        }

        // Elo - alguns prefixos comuns
        if (Regex.IsMatch(numero, @"^(4011|4312|4389|4514|4576|5041|5066|5090|6277|6362|6363|6500|6504|6505|6507|6509|6516|6550)"))
        {
            return "Elo";
        }

        // Discover
        if (Regex.IsMatch(numero, @"^(6011|65|64[4-9])"))
        {
            return "Discover";
        }

        return "Bandeira não identificada";
    }
}
