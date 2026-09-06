using System.Text.RegularExpressions;

namespace IdentificadorCartao.Models
{
    public class Cartao
    {
        public string Numero { get; set; }
        public string Bandeira { get; private set; }

        public Cartao(string numero)
        {
            Numero = Regex.Replace(numero ?? "", @"\D", "");
            Bandeira = IdentificarBandeira();
        }

        private string IdentificarBandeira()
        {
            // Visa
            if (Regex.IsMatch(Numero, @"^4\d{12}(\d{3})?$"))
            {
                return "Visa";
            }

            // MasterCard
            if (Regex.IsMatch(
                Numero,
                @"^(5[1-5]\d{14}|2(2[2-9]\d{2}|[3-6]\d{3}|7[01]\d{2}|720\d)\d{12})$"))
            {
                return "MasterCard";
            }

            // American Express
            if (Regex.IsMatch(Numero, @"^3[47]\d{13}$"))
            {
                return "American Express";
            }

            // Elo
            if (Regex.IsMatch(
                Numero,
                @"^(4011|4312|4389|4514|4576|5041|5066|5090|6277|6362|6363|6500|6504|6505|6507|6509|6516|6550)"))
            {
                return "Elo";
            }

            // Discover
            if (Regex.IsMatch(Numero, @"^(6011|65|64[4-9])"))
            {
                return "Discover";
            }

            return "Bandeira não identificada";
        }
    }
}
