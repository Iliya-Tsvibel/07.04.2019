using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Country
{
    interface ISQL_Country_DAO
    {
        object GetCountryAndItsCapitalCityName(int countryId);
        object GetCountryAndItsCapitalCityDetails(int countryId);
        object GetCountryAndItsCapitalCityName(string countryName);
        object GetCountryAndItsCapitalCityDetails(string countryName);
        List<object> CountriesByFirstLetter(string FirstLetter);

    }
}
