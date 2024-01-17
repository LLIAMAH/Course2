﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course2.DB.Entities
{
    public class Country
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }

    }
}
