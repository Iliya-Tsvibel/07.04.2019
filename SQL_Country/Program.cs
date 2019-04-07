using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Country
{
    class Program
    {
        static void Main(string[] args)
        {

            ISQL_Country_DAO country_DAO = new SQL_Country_DAO();

            var res1 = country_DAO.GetCountryAndItsCapitalCityDetails(10);
            var res2 = country_DAO.GetCountryAndItsCapitalCityDetails("Israel");
            var res3 = country_DAO.GetCountryAndItsCapitalCityName(1);
            var res4 = country_DAO.GetCountryAndItsCapitalCityName("Jerusalem");
            var res5 = country_DAO.CountriesByFirstLetter("I");



        }
    }
}
