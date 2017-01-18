using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzeriaClassLibrary.Interfaces;
using PizzeriaClassLibrary.Models;

namespace PizzeriaClassLibrary.Logic
{
    class PizzacrustRepository : IPizzacrustContext
    {

        private IPizzacrustContext _context;

        public PizzacrustRepository(IPizzacrustContext context)
        {
            _context = context;
        }
        /// <inheritdoc />
        public void AddPizzacrust(Pizzacrust crust)
        {
            _context.AddPizzacrust(crust);
        }

        /// <inheritdoc />
        public List<Pizzacrust> GetAllPizzaCrusts()
        {
            return _context.GetAllPizzaCrusts();
        }

        /// <inheritdoc />
        public Pizzacrust GetPizzacrustById(int id)
        {
            return _context.GetPizzacrustById(id);
        }
    }
}
