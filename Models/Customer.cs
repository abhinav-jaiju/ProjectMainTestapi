using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectMainTestapi.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string CustomerCode { get; set; }
        public bool isDeleted { get; set; }

    }
}
