using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldGuiLibrary.Model;


// ID,Name,CountryCode,District,Population
// 1,Kabul,AFG,Kabol,1780000
public class City
{
    public City() { }
    public City(int id, string name, string countryCode, string district, int population)
    {
        Id = id;
        Name = name;
        CountryCode = countryCode;
        District = district;
        Population = population;
    }

    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string CountryCode { get; set; } = string.Empty;
    public string District { get; set; } = string.Empty;
    public int Population { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}, CountryCode: {CountryCode}, " +
            $"District: {District}, Population: {Population}";
    }
}
