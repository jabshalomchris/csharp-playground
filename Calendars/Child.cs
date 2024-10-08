﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendars
{
    public class Child
    {   
        private string _name;
        private Date _birthDate;

        public Child(string name, Date birthDate)
        {
            _name = name;
            _birthDate = birthDate;
        }

        public override string ToString() => 
            _name + " born on " + _birthDate;

        public Date GetDateByAge(int minAge) => 
            throw new NotImplementedException();
    }
}
