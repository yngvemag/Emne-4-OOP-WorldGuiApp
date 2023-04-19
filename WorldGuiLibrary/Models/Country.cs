using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldGuiLibrary.Model;

//Code,Name,Continent,Region,SurfaceArea,Population,LocalName,Capital,GovernmentForm
//ABW,Aruba,"North America",Caribbean,193.00,103000,Aruba,129,"Nonmetropolitan Territory of The Netherlands"

#region GetData Query 
/*
select Code,
        replace(Name, ',', ' ') Name, 
        replace(Continent,',', ' ') Continent, 
        Region, 
        SurfaceArea, 
        Population, 
        LocalName, 
        Capital,
		replace(GovernmentForm,',', '; ') as GovernmentForm
from country;
*/
#endregion

public class Country
{
    public Country()
    {            
    }

    public Country(string code, string name, string continent, string region, float surfaceArea, int population, string localName, int capital, string governmentForm)
    {
        Code = code;
        Name = name;
        Continent = continent;
        Region = region;
        SurfaceArea = surfaceArea;
        Population = population;
        LocalName = localName;
        Capital = capital;
        GovernmentForm = governmentForm;
    }

    public string Code { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Continent { get; set; } = string.Empty;
    public string Region { get; set; } = string.Empty;
    public float SurfaceArea { get; set; }
    public int Population { get; set; }
    public string LocalName { get; set; } = string.Empty;
    public int Capital { get; set; }
    public string GovernmentForm { get; set; } = string.Empty;

    public override string ToString()
    {
        return $"Code: {Code}, Name: {Name}, Continent: {Continent}, Region: {Region}, " +
            $"SurfaceArea: {SurfaceArea}, Population: {Population}, LocalName: {LocalName}, " +
            $"Capital: {Capital}, GovernmentForm: {GovernmentForm}";
    }
}
