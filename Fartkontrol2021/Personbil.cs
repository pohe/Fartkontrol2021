using System;
using System.Collections.Generic;
using System.Text;

namespace Fartkontrol2021
{
    public class Personbil: Køretøj
    {
        private int _noOfPersons;

        public int NoOfPersons
        {
            get { return _noOfPersons; }
            set { _noOfPersons = value; }
        }
        public Personbil(string regnr, int noOfPersons) : base(regnr)
        {
            _noOfPersons = noOfPersons;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Personbil antal personer {_noOfPersons}";
        }
    }
}
