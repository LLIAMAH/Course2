using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course2.DB.Entities
{
    public class Address
    {
        public long Id { get; set; }
        public string StateProvince { get; set; }
        public string City { get; set; }
        public string Street{ get; set; }
        public string House { get; set; }
        public string? Apartments { get; set; }
        public virtual Country Country { get; set; }
        public virtual ICollection<Person> Persons { get; set; }
    }
}
