using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Country
{
    // POCO
    class CapitalCity
    {
        public int Id { get; set; }
        public string C_Name { get; set; }
        public int NumCitizens { get; set; }
        public int Country_Id { get; set; }

        public static bool operator ==(CapitalCity countr1, CapitalCity countr2)
        {
            if ((countr1 == null) && (countr2 == null))
                return true;
            if ((countr1 == null) || (countr2 == null))
                return false;

            return (countr1.Id == countr2.Id);
        }
        public static bool operator !=(CapitalCity countr1, CapitalCity countr2)
        {
            return !(countr1 == countr2);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            CapitalCity countr = obj as CapitalCity;
            if (countr == null)
                return false;

            return this.Id == countr.Id;
        }

        public override int GetHashCode()
        {
            return this.Id;
        }


        public override string ToString()
        {
            return $"CapitalCity Id {Id}, Name {Name}, NumCitizens {NumCitizens}, Country Id {Country_Id}";
        }
    }
}
