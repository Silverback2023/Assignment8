using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Core
{
    public class Company : Contact
    {
        public List<Individual> Employees { get; set; }

        public Company()
        {
            Employees = new List<Individual>();
        }
    }
}
