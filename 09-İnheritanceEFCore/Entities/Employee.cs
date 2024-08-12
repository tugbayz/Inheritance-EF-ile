using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_İnheritanceEFCore.Entities
{
    internal class Employee: BasePerson_
    {
        public DateTime AdmissionDate { get; set; }
        public string JobDescription { get; set; }
    }
}
