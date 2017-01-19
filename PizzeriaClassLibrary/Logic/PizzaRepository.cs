using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzeriaClassLibrary.Interfaces;
using PizzeriaClassLibrary.Models;

namespace PizzeriaClassLibrary.Logic
{
    public class PizzaRepository : IPizzaContext
    {

        private IPizzaContext _context;

        public PizzaRepository(IPizzaContext context)
        {
            _context = context;
        }
        /// <inheritdoc />
        public void AddPizza(Pizza pizza)
        {
            _context.AddPizza(pizza);
        }

        /// <inheritdoc />
        public void RemovePizza(Pizza pizza)
        {
            _context.RemovePizza(pizza);
        }

        /// <inheritdoc />
        public void UpdatePizza(Pizza pizza)
        {
            _context.UpdatePizza(pizza);
        }

        /// <inheritdoc />
        public List<Pizza> GetAllPizzas()
        {
            return _context.GetAllPizzas();
        }

        /// <inheritdoc />
        public Pizza GetPizzaById(int id)
        {
            return _context.GetPizzaById(id);
        }
    }
}
