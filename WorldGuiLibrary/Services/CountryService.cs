using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldGuiLibrary.Model;
using WorldGuiLibrary.Services.Interfaces;

namespace WorldGuiLibrary.Services;

public class CountryService : BaseService, ICountryService
{
    public CountryService()
        : base()
    {
    }
    public CountryService(Action<string> logMessage)
        : base(logMessage)
    {
    }
    public IEnumerable<Country> LoadCountry(string fileName)
    {
        using StreamReader reader = new(fileName, Encoding.UTF8);

        // ID,Name,CountryCode,District,Population
        string? header = reader.ReadLine();
        if (header == null)
        {
            return Enumerable.Empty<Country>();
        }

        List<Country> countries = new();

        // Code,Name,Continent,Region,SurfaceArea,Population,LocalName,Capital,GovernmentForm
        // ABW,Aruba,"North America",Caribbean,193.00,103000,Aruba,129,"Nonmetropolitan Territory of The Netherlands"
        string? line = reader.ReadLine();
        while (line != null)
        {
            var arr = line.Split(',');

            // List Pattern Matching
            if (arr is [var code, var name, var continent, var region,var fstrSurfaceArea, var nstrPopulation, 
                var localname, var nCapital, var governmentForm])
            {
                if (!float.TryParse(fstrSurfaceArea, CultureInfo.InvariantCulture, out float surfaceArea))
                {
                    LogMessage($"Klarte ikke å parse float(surfaceArea) linje: {line}");
                }

                int population = 0;
                if (!nstrPopulation.ToLower().Equals("null") && !int.TryParse(nstrPopulation, out population))
                {
                    LogMessage($"Klarte ikke å parse int(population) linje: {line}");
                }

                int capital = 0;
                if( !int.TryParse(nCapital, out capital))
                //if (!nCapital.ToLower().Equals("null") && !int.TryParse(nCapital, out capital))
                {
                    LogMessage($"Klarte ikke å parse int(capital) linje: {line}");
                }

                Country countryLanguage = new ()
                {
                   Capital = capital,
                   Region = region,
                   Code = code,
                   Name = name,
                   Continent = continent,
                   GovernmentForm  = governmentForm,
                   LocalName = localname,
                   Population = population,
                   SurfaceArea = surfaceArea
                };

                countries.Add(countryLanguage);
            }
            else
            {
                // Feil i split ( feil format )
                // Logging !!
                LogMessage($"Klarte ikke å parse linjen. Linje: {line}");
            }
            line = reader.ReadLine();
        }

        return countries;
    }
}
