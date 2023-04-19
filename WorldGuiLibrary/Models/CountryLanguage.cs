using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldGuiLibrary.Model;

//CountryCode,Language,IsOfficial,Percentage
//ABW,Dutch,T,5.3
public class CountryLanguage
{
    public CountryLanguage() { }

    public CountryLanguage(string countryCode, string language, bool isOfficial, float percentage)
    {
        CountryCode = countryCode;
        Language = language;
        IsOfficial = isOfficial;
        Percentage = percentage;
    }

    public string CountryCode { get; set; } = string.Empty;
    public string Language { get; set; } = string.Empty;

    public bool IsOfficial { get; set; }
    public float Percentage { get; set; }

    public override string ToString()
    {
        return $"CountryCode: {CountryCode}, Language: {Language}, " +
            $"IsOfficial: {IsOfficial}, Percentage: {Percentage}, ";
    }
}
