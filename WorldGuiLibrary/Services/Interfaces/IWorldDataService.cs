using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldGuiLibrary.Model;

namespace WorldGuiLibrary.Services.Interfaces;

public interface IWorldDataService
{
    // sikrer at vi laster inn data fra filene
    void LoadData(string countryFileName, string cityFileName, string countryLanguageFileName);

    ICollection<Country> GetAllCountries();

    // Henter ut land basert på navn
    ICollection<Country> GetCountriesByName(string countryName);

    ICollection<City> GetAllCities();

    // hente ut cities by country code ( hvis countryCode == string.Empty => return alt! )
    ICollection<City> GetCitiesByCountryCode(string countryCode);

    ICollection<CountryLanguage> GetAllCountryLanguages();

    // hente ut country language by country code
    ICollection<CountryLanguage> GetCountryLanguagesByCountryCode(string countryCode);

    ICollection<string> GetErrors();

}
