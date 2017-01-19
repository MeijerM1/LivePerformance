using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzeriaClassLibrary.Models;

namespace PizzeriaClassLibrary.Interfaces
{
    public interface IPizzaContext
    {
        void AddPizza(Pizza pizza);

        void RemovePizza(Pizza pizza);

        void UpdatePizza(Pizza pizza);

        List<Pizza> GetAllPizzas();

        Pizza GetPizzaById(int id);
    }
}
