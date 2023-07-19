using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlesTipoVista.Services
{
    public class DataService
    {
        private static List<string> _countriesList = new List<string>()
        {
            "Argentina",
            "Brazil",
            "Chile",
            "Colombia",
            "Ecuador",
            "Mexico",
            "Peru",
            "Uruguay",
            "Venezuela"
        };

        public static List<string> SearchCountries(string searchText)
        {
            var filteredList = _countriesList.Where(country => country.ToLower().Contains(searchText.ToLower())).ToList();

            return filteredList;
        }
    }
}
