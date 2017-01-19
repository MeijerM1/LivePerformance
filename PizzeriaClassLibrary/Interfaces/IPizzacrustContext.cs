using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzeriaClassLibrary.Models;

namespace PizzeriaClassLibrary.Interfaces
{
    public interface IPizzacrustContext
    {
        void AddPizzacrust(Pizzacrust crust);

        List<Pizzacrust> GetAllPizzaCrusts();

        Pizzacrust GetPizzacrustById(int id);
    }
}
