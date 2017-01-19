using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaClassLibrary.Models
{
    public class Adress
    {
        public int ID { get; set; }
        public string Streetname { get; set; }
        public int HouseNumber { get; set; }
        public string Postalcode { get; set; }

        /// <inheritdoc />
        public Adress(int id, string streetname, int houseNumber, string postalcode)
        {
            ID = id;
            Streetname = streetname;
            HouseNumber = houseNumber;
            Postalcode = postalcode;
        }

        /// <inheritdoc />
        public Adress(string streetname, int houseNumber, string postalcode)
        {
            Streetname = streetname;
            HouseNumber = houseNumber;
            Postalcode = postalcode;
        }
    }
}
