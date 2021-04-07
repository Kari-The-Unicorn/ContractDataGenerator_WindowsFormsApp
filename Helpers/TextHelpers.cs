using System.Text.RegularExpressions;

namespace Helpers
{
    public class TextHelpers
    {
        public static string GetContractWhere(string pageContent)
        {
            var contractWhereInfo = string.Empty;
            var whereInfoMatch = Regex.Match(pageContent,
                                        $@"(?<=zawarta.w.)(.*?)(?=pomi)",
                                        RegexOptions.IgnoreCase);
            if (whereInfoMatch.Success)
            {
                contractWhereInfo = whereInfoMatch.Value.ToString()
                    .Replace("Warszawie", "Warszawa")
                    .Replace("roku", "r.")
                    .Trim();
            }

            return contractWhereInfo;
        }

        public static string GetContractEmployer(string pageContent)
        {
            var contractInvestorInfo = string.Empty;
            var contractInvestorInfoMatch = Regex.Match(pageContent,
                                        $@"(?<=pomiędzy:)(.*?)(?=zwan)");
            if (contractInvestorInfoMatch.Success)
            {
                contractInvestorInfo = contractInvestorInfoMatch.Value.ToString()
                    .Replace(":", string.Empty)
                    .Replace("1.", string.Empty)
                    .Replace("Firmą", string.Empty)
                    .Replace("zwanym", string.Empty)
                    .Replace("dalej", string.Empty)
                    .Replace("Zamawiaj", string.Empty)
                    .Replace("reprezentowaną", "reprezentowana")
                    .Trim();
            }

            return contractInvestorInfo;
        }

        public static string GetContractEmployee(string pageContent)
        {
            var contractContractorInfo = string.Empty;
            var contractContractorInfoMatch = Regex.Match(pageContent,
                                        $@"(?<= A )(.*?)(?=zwan)");       
            if (contractContractorInfoMatch.Success)
            {
                contractContractorInfo = contractContractorInfoMatch.Value.ToString()
                    .Replace(":", string.Empty)
                    .Replace("2.", string.Empty)
                    .Replace("Firmą", string.Empty)
                    .Replace("wpisaną", "wpisana")
                    .Replace("reprezentowaną", "reprezentowana")
                    .Replace("Przedmiot", string.Empty)
                    .Replace("Umowy", string.Empty)
                    .Replace("zwanego", string.Empty)
                    .Replace("dalej", string.Empty)
                    .Replace("Wykonawcą", string.Empty)
                    .Trim();
            }

            return contractContractorInfo;
        }

        public static string GetContractInvestor(string pageContent)
        {
            var contractContractorInfo = string.Empty;
            var contractContractorInfoMatch = Regex.Match(pageContent,
                                        $@"(?<=nazwa inwestora: ).*?(?= Koszt)", RegexOptions.IgnoreCase);
            if (contractContractorInfoMatch.Success)
            {
                contractContractorInfo = contractContractorInfoMatch.Value.ToString()
                    .Replace(":", string.Empty)
                    .Replace("2.", string.Empty)
                    .Replace("Firmą", string.Empty)
                    .Replace("wpisaną", "wpisana")
                    .Replace("reprezentowaną", "reprezentowana")
                    .Replace("Przedmiot", string.Empty)
                    .Replace("Umowy", string.Empty)
                    .Replace("zwanego", string.Empty)
                    .Replace("dalej", string.Empty)
                    .Replace("Wykonawcą", string.Empty)
                    .Trim();
            }

            return contractContractorInfo;
        }

        public static string GetContractValue(string pageContent)
        {
            var contractValueInfo = string.Empty;
            var contractValueInfoMatch = Regex.Match(pageContent,
                                        $@"((\d|\s)*(,)(\d)*)*(?= zł netto)");
            if (contractValueInfoMatch.Success)
            {
                contractValueInfo = contractValueInfoMatch.Value.ToString()
                    .Replace("plus", string.Empty)
                    .Replace("+", string.Empty)
                    .Replace("należny", string.Empty)
                    .Replace("podatek", string.Empty)
                    .Trim();
            }

            return contractValueInfo;
        }
    }
}
