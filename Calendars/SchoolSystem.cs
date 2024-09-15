using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendars
{
    public class SchoolSystem
    {
        private YearDate _cutoff;
        private int _minAge;
        private YearDate _schoolStart;

        public SchoolSystem(YearDate cutOff, int minAge, YearDate schoolStart)
        {
            _cutoff = cutOff;
            _minAge = minAge;
            _schoolStart = schoolStart;
        }

        public Date GetSchoolBeginningForChild(Child schoolChild) 
        {
            Date oldEnough = schoolChild.GetDateByAge(_minAge);
            Date cutoff = schoolChild.GetDateByAge(_minAge);
            return oldEnough;
        }
    }
}
