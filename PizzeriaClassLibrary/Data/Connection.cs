using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaClassLibrary.Data
{
    class Connection
    {
        public string ConnectionString { get; set; }

        public Connection()
        {
            ConnectionString = "Server=mssql.fhict.local;Database=dbi356615;User Id=dbi356615;Password=Kipgarfield1;";
        }
    }
}
