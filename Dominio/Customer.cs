﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Customer
    {
        public Guid IdCustomer { get; set; }

        public String FirstName { get; set; }

        public String LastName { get; set; }

        public DateTime DateBirth { get; set; }

        public String Doc { get; set; }

    }
}
