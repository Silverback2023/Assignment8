using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Core
{
    public class Individual : Contact
    {
        public Company Employer { get; set; }

        public Individual()
        {
            Employer = null;
        }
    }
}
