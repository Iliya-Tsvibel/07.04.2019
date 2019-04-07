using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Country
{
    //POCO
    class Country
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public int Size_km { get; set; }
        public int Birth_Year { get; set; }
        public int CapitalCity_Id { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Country countr = obj as Country;
            if (countr == null)
                return false;

            return this.Id == countr.Id;
        }

        public override int GetHashCode()
        {
            return this.Id;
        }

        public static bool operator ==(Country countr1, Country countr2)
        {
            if ((countr1 == null) && (countr2 == null))
                return true;
            if ((countr1 == null) || (countr2 == null))
                return false;

            return (countr1.Id == countr2.Id);
        }
        public static bool operator !=(Country countr1, Country countr2)
        {
            return !(countr1 == countr2);
        }


        public override string ToString()
        {
            return $"Country Id is {Id}, Name is {Name}, Size_km is {Size_km}, Birth Year is {Birth_Year}, Captal City Id is {CapitalCity_Id}";
        }
    }
}
