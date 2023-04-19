
// => lage object av worldDataService.GetAllCountries() 
using WorldGuiLibrary.Services;
using WorldGuiLibrary.Services.Interfaces;

// static variabler starter med "s_"
string s_countryFileName = @"Files\Country.csv";
string s_cityFileName = @"Files\City.csv";
string s_countryLanguageFileName = @"Files\CountryLanguage.csv";


IWorldDataService service = new WorldDataService();

try
{
    // Laster inn data med riktige filer
    service.LoadData(s_countryFileName, s_cityFileName, s_countryLanguageFileName);

    foreach ( var cntr in service.GetCountriesByName("CON"))
    {
        Console.WriteLine(cntr);
    }

}
catch (FileNotFoundException fileNotFoundEx) 
{ 
    Console.WriteLine(fileNotFoundEx.ToString()); 
}
catch (ArgumentException argEx) { Console.WriteLine(argEx.ToString()); }
catch (NotSupportedException notSopportetdEx) { Console.WriteLine(notSopportetdEx.ToString()); }
catch (NullReferenceException nullRefEx) { Console.WriteLine(nullRefEx.ToString()); }
catch (Exception ex) { Console.WriteLine(ex.ToString()); }
finally 
{ 
    // opprydding
}







