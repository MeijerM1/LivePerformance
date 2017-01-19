using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaClassLibrary.Models
{
    public class Pizzacrust
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public decimal PricePerCentimeter  { get; set; }

        /// <inheritdoc />
        public Pizzacrust(int id, string description, decimal pricePerCentimeter)
        {
            ID = id;
            Description = description;
            PricePerCentimeter = pricePerCentimeter;
        }

        /// <inheritdoc />
        public Pizzacrust(string description, decimal pricePerCentimeter)
        {
            Description = description;
            PricePerCentimeter = pricePerCentimeter;
        }

        /// <inheritdoc />
        public override string ToString()
        {
            return Description;
        }
    }
}
