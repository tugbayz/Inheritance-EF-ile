using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_İnheritanceEFCore.Entities
{
    internal class Customer:BasePerson_
    {
        public DateTime LastPurchaseDate { get; set; }
        public string TotalVisitName { get; set; }
    }
}
