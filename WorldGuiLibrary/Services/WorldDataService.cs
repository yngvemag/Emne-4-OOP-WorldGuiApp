using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WorldGuiLibrary.Model;
using WorldGuiLibrary.Services.Interfaces;

// File-scoped namespace
namespace WorldGuiLibrary.Services;

public sealed class WorldDataService : IWorldDataService
{
    // trenger tilgang til ICityService, ICountryService og ICountryLanguageService
    private readonly ICountryService _countryService;
    private readonly ICityService _cityService;
    private readonly ICountryLanguageService _countryLanguageService;

    private List<string> _errors;

    private List<City> _cityDataList;
    private List<Country> _countryDataList;
    private List<CountryLanguage> _countryLanguageDataList;


    public WorldDataService()
    {
        _errors = new List<string>();
        _cityDataList = new List<City>();
        _countryDataList = new List<Country>();
        _countryLanguageDataList = new List<CountryLanguage>();

        _countryService = new CountryService(msg => _errors.Add(msg));        
        _cityService = new CityService(msg => _errors.Add(msg));// /*Peker til en funkjson som er void og har string som argument*/ );
        _countryLanguageService = new CountryLanguageService(msg => _errors.Add(msg));        
    }

    public ICollection<City> GetAllCities()
    {
        return _cityDataList;
    }

    public ICollection<Country> GetAllCountries()
    {
        return _countryDataList;
    }

    public ICollection<CountryLanguage> GetAllCountryLanguages()
    {
        return _countryLanguageDataList;
    }

    public ICollection<City> GetCitiesByCountryCode(string countryCode)
    {
        // _cityDataList
        // Func<City, bool>
        return _cityDataList.Where( cty => cty.CountryCode.ToLower() == countryCode.ToLower()).ToList();
    }

    public ICollection<Country> GetCountriesByName(string countryName)
    {
        // Name
        // swe => alle som begynner med swe....    .....swe  
        // Kongo =>  Kon  go
        return _countryDataList.Where(country => country.Name.ToLower().Contains(countryName.ToLower())).ToList();
        
        //_countryDataList.Where(ct => ct.Name.Equals(countryName)).ToList();
    }

    public ICollection<CountryLanguage> GetCountryLanguagesByCountryCode(string countryCode)
    {
        return _countryLanguageDataList.Where( lang => lang.CountryCode.ToLower() == countryCode.ToLower()).ToList();
    }

    public ICollection<string> GetErrors()
    {
        return _errors;
    }

    public void LoadData(string countryFileName, string cityFileName, string countryLanguageFileName)
    {
        if (!File.Exists(countryFileName) || !File.Exists(cityFileName) || !File.Exists(countryLanguageFileName))
        {
            throw new FileNotFoundException();
        }

        _cityDataList = _cityService.LoadCities(cityFileName).ToList();
        _countryLanguageDataList = _countryLanguageService.LoadCountryLanguage(countryLanguageFileName).ToList();
        _countryDataList = _countryService.LoadCountry(countryFileName).ToList();
    }
}
