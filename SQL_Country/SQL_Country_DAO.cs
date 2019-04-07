using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Country
{
    class SQL_Country_DAO : ISQL_Country_DAO
    {
        public List<object> CountriesByFirstLetter(string FirstLetter)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = C:\\Users\\itsvibel\\Downloads\\SQL_Tirgul; Version = 3;");

            con.Open();

            List<object> list = new List<object>();

            using (SQLiteCommand cmd = new SQLiteCommand("SELECT * From COUNTRY JOIN CAPITALCITY ON COUNTRY.CAPITALCITY_ID == CAPITALCITY.ID", con))
            {

                // execut4e the query into the reader
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {

                    // use the reader to read all of the results of the query
                    while (reader.Read() == true)
                    {
                        Country Countr = new Country
                        {
                            Id = (int)reader["COUNTRY_ID"],
                            Name = (string)reader["NAME"],
                            Size_km = (int)reader["SIZE_KM"],
                            Birth_Year = (int)reader["BIRTH_YEAR"],
                            CapitalCity_Id = (int)reader["CAPITALCITY_ID"]
                        };

                        CapitalCity City = new CapitalCity
                        {
                            Id = (int)reader["ID"],
                            C_Name = (string)reader["NAME"],
                            NumCitizens = (int)reader["NUMCITIZENS"],
                            Country_Id = (int)reader["COUNTRY_ID"]
                        };

                        var results = new
                        {
                            Countr.Id,
                            Countr.Name,
                            City.C_Name,
                           
                        };
                        con.Close();
                        list.Add(results);

                    }
                }
            }
            return list;
        }

        public object GetCountryAndItsCapitalCityDetails(int countryId)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = C:\\Users\\itsvibel\\Downloads\\SQL_Tirgul; Version = 3;");

            con.Open();

            using (SQLiteCommand cmd = new SQLiteCommand("SELECT * From COUNTRY JOIN CAPITALCITY ON COUNTRY.CAPITALCITY_ID == CAPITALCITY.ID WHERE COUNTRY.ID == {countryId}", con))
            {

                // execut4e the query into the reader
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {

                    // use the reader to read all of the results of the query
                    while (reader.Read() == true)
                    {
                        Country Countr = new Country
                        {
                            Id = (int)reader["COUNTRY_ID"],
                            Name = (string)reader["NAME"],
                            Size_km = (int)reader["SIZE_KM"],
                            Birth_Year = (int)reader["BIRTH_YEAR"],
                            CapitalCity_Id = (int)reader["CAPITALCITY_ID"]
                        };

                        CapitalCity City = new CapitalCity
                        {
                            Id = (int)reader["ID"],
                            C_Name = (string)reader["NAME"],
                            NumCitizens = (int)reader["NUMCITIZENS"],
                            Country_Id = (int)reader["COUNTRY_ID"]
                        };

                        var results = new
                        {
                            Countr.Id,
                            Countr.Name,
                            City.C_Name,
                            City.NumCitizens,
                            City.Country_Id
                        };
                        con.Close();
                        return results;

                    }
                }
            }
            return null;
        }

        public object GetCountryAndItsCapitalCityDetails(string countryName)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = C:\\Users\\itsvibel\\Downloads\\SQL_Tirgul; Version = 3;");

            con.Open();

            using (SQLiteCommand cmd = new SQLiteCommand("SELECT * From COUNTRY JOIN CAPITALCITY ON COUNTRY.CAPITALCITY_ID == CAPITALCITY.ID WHERE COUNTRY.ID == {countryName}", con))
            {

                // execut4e the query into the reader
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {

                    // use the reader to read all of the results of the query
                    while (reader.Read() == true)
                    {
                        Country Countr = new Country
                        {
                            Id = (int)reader["COUNTRY_ID"],
                            Name = (string)reader["NAME"],
                            Size_km = (int)reader["SIZE_KM"],
                            Birth_Year = (int)reader["BIRTH_YEAR"],
                            CapitalCity_Id = (int)reader["CAPITALCITY_ID"]
                        };

                        CapitalCity City = new CapitalCity
                        {
                            Id = (int)reader["ID"],
                            C_Name = (string)reader["NAME"],
                            NumCitizens = (int)reader["NUMCITIZENS"],
                            Country_Id = (int)reader["COUNTRY_ID"]
                        };

                        var results = new
                        {
                            Countr.Id,
                            Countr.Name,
                            City.C_Name,
                            City.NumCitizens,
                            City.Country_Id
                        };
                        con.Close();
                        return results;

                    }
                }
            }
            return null;
        }

        public object GetCountryAndItsCapitalCityName(int countryId)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = C:\\Users\\itsvibel\\Downloads\\SQL_Tirgul; Version = 3;");

            con.Open();

            using (SQLiteCommand cmd = new SQLiteCommand("SELECT * From COUNTRY JOIN CAPITALCITY ON COUNTRY.CAPITALCITY_ID == CAPITALCITY.ID WHERE COUNTRY.ID == {countryId}", con))
            {

                // execut4e the query into the reader
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {

                    // use the reader to read all of the results of the query
                    while (reader.Read() == true)
                    {
                        Country Countr = new Country
                        {
                            Id = (int)reader["COUNTRY_ID"],
                            Name = (string)reader["NAME"],
                            Size_km = (int)reader["SIZE_KM"],
                            Birth_Year = (int)reader["BIRTH_YEAR"],
                            CapitalCity_Id = (int)reader["CAPITALCITY_ID"]
                        };

                        CapitalCity City = new CapitalCity
                        {
                            Id = (int)reader["ID"],
                            C_Name = (string)reader["NAME"],
                            NumCitizens = (int)reader["NUMCITIZENS"],
                            Country_Id = (int)reader["COUNTRY_ID"]
                        };

                        var results = new
                        {
                            Countr.Id,
                            Countr.Name,
                            City.C_Name,
                           
                        };
                        con.Close();
                        return results;

                    }
                }
            }
            return null;
        }

        public object GetCountryAndItsCapitalCityName(string countryName)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source = C:\\Users\\itsvibel\\Downloads\\SQL_Tirgul; Version = 3;");

            con.Open();

            using (SQLiteCommand cmd = new SQLiteCommand("SELECT * From COUNTRY JOIN CAPITALCITY ON COUNTRY.CAPITALCITY_ID == CAPITALCITY.ID WHERE COUNTRY.ID == {countryName}", con))
            {

                // execut4e the query into the reader
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {

                    // use the reader to read all of the results of the query
                    while (reader.Read() == true)
                    {
                        Country Countr = new Country
                        {
                            Id = (int)reader["COUNTRY_ID"],
                            Name = (string)reader["NAME"],
                            Size_km = (int)reader["SIZE_KM"],
                            Birth_Year = (int)reader["BIRTH_YEAR"],
                            CapitalCity_Id = (int)reader["CAPITALCITY_ID"]
                        };

                        CapitalCity City = new CapitalCity
                        {
                            Id = (int)reader["ID"],
                            C_Name = (string)reader["NAME"],
                            NumCitizens = (int)reader["NUMCITIZENS"],
                            Country_Id = (int)reader["COUNTRY_ID"]
                        };

                        var results = new
                        {
                            Countr.Id,
                            Countr.Name,
                            City.C_Name,

                        };
                        con.Close();
                        return results;

                    }
                }
            }
            return null;
        }
    }
}
