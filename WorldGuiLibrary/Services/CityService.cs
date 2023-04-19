using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldGuiLibrary.Model;
using WorldGuiLibrary.Services.Interfaces;

namespace WorldGuiLibrary.Services;

public class CityService : BaseService, ICityService
{
    public CityService() 
        : base()
    {
    }
    public CityService(Action<string> logMessage) 
        : base(logMessage)
    {
    }


    public IEnumerable<City> LoadCities(string fileName)
    {
        using StreamReader reader = new (fileName, Encoding.UTF8);

        // ID,Name,CountryCode,District,Population
        string? header = reader.ReadLine();
        if (header == null)
        {
            return Enumerable.Empty<City>();
        }

        List<City> cities = new();

        // 1,Kabul,AFG,Kabol,1780000
        string? line = reader.ReadLine();
        while (line != null)
        {
            // parsing av data her !!
            var arr = line.Split(','); // => ["1", "Kabul", "AFG", "Kabol", "1780000"]
            
            // guard !!
            if (arr.Length != 5)
            {
                // Log error
                line = reader.ReadLine();
                continue; // avbryt denne runden -> gå til neste
            }

            // arr[0] => må gjøre om til int
            if (!int.TryParse(arr[0], out int id))
            {
                // Hva gjør vi => feil i data??
                // Logging -> Console.WriteLine()

                //Console.WriteLine($"Klarte ikke å parse int(id) linje: {line}");
                LogMessage($"Klarte ikke å parse int(id) linje: {line}");
            }

            string name = arr[1];
            string countryCode = arr[2];
            string district = arr[3];

            // arr[4] => må gjøre om til int
            if (!int.TryParse(arr[4], out int population))
            {
                // Hva gjør vi => feil i data??
                //Console.WriteLine($"Klarte ikke å parse int(population) linje: {line}");
                LogMessage($"Klarte ikke å parse int(population) linje: {line}");
            }

            // Vi er klare til å lage objekt City!!
            City city = new(id, name, countryCode, district, population);
            cities.Add(city);  

            line = reader.ReadLine();
        }

        return cities;
    }


}
