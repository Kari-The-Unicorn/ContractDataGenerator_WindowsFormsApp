using System.Text.RegularExpressions;

namespace Helpers
{
    public class TextHelpers
    {
        public static string GetContractWhere(string contractWhereInfo, string pageContent)
        {
            var whereInfoMatch = Regex.Match(pageContent,
                                        $@"(?<=zawarta.w)(.*)(?=pomiędzy)",
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


        public static string GetContractInvestor(string contractInvestorInfo, string pageContent)
        {
            var contractInvestorInfoMatch = Regex.Match(pageContent,
                                        $@"(?<=pomiędzy:)((.|\n)*?)(?<=zwanym.dalej.zamawiającym)",
                                        RegexOptions.IgnoreCase);
            if (contractInvestorInfoMatch.Success)
            {
                contractInvestorInfo = contractInvestorInfoMatch.Value.ToString()
                    .Replace(":", string.Empty)
                    .Replace("1.", string.Empty)
                    .Replace("Firmą", string.Empty)
                    .Replace("wpisaną", "wpisana")
                    .Replace("reprezentowaną", "reprezentowana")
                    .Trim();
            }

            return contractInvestorInfo;
        }

        public static string GetContractContractor(string contractContractorInfo, string pageContent)
        {
            var contractContractorInfoMatch = Regex.Match(pageContent,
                                        $@"(?<=A\n)((.|\n)*?)(?<=Przedmiot Umowy)",
                                        RegexOptions.IgnoreCase);
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
                    .Trim();
            }

            return contractContractorInfo;
        }
    }
}
