using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WorldGuiLibrary.Model;
using WorldGuiLibrary.Services.Interfaces;

namespace WorldGuiLibrary.Services;

public class CountryLanguageService : BaseService, ICountryLanguageService
{
    public CountryLanguageService()
    : base()
    {
    }
    public CountryLanguageService(Action<string> logMessage)
        : base(logMessage)
    {
    }

    public IEnumerable<CountryLanguage> LoadCountryLanguage(string fileName)
    {
        using StreamReader reader = new (fileName, Encoding.UTF8);

        // ID,Name,CountryCode,District,Population
        string? header = reader.ReadLine();
        if (header == null)
        {
            return Enumerable.Empty<CountryLanguage>();
        }

        List<CountryLanguage> countryLanguages = new();

        // CountryCode,Language,IsOfficial,Percentage
        // ABW,Dutch,T,5.3
        string? line = reader.ReadLine();
        while (line != null)
        {
            var arr = line.Split(',');

            // List Pattern Matching
            if (arr is [var code, var language, var strIsOfficial, var strPercentage])
            {
                bool isOfficial = strIsOfficial.ToLower().Equals("t");

                // 3.14 -> ??
                // 3,14 -> dette vil funke på norsk   
                if (!float.TryParse(strPercentage, CultureInfo.InvariantCulture, out float percentage))
                {
                    // problemer med å konverterte til float
                    LogMessage($"Klarte ikke å parse float. Linje: {line}");
                }

                CountryLanguage countryLanguage = new ()
                {
                    CountryCode = code,
                    Language = language,
                    IsOfficial = isOfficial,
                    Percentage = percentage
                };
                countryLanguages.Add(countryLanguage);
            }
            else
            {
                // Feil i split ( feil format )
                // Logging !!
                LogMessage($"Klarte ikke å parse linjen. Linje: {line}");
            }

            line = reader.ReadLine();
        }

        return countryLanguages;
    }
}
