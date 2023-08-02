using System;
using System.Collections.Generic;

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
