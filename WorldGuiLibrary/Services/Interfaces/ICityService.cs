using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldGuiLibrary.Model;

namespace WorldGuiLibrary.Services.Interfaces;

public interface ICityService
{
    IEnumerable<City> LoadCities(string fileName);
}
