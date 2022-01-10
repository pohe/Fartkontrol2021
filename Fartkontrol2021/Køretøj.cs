using System;
using System.Collections.Generic;
using System.Text;

namespace Fartkontrol2021
{
    public class Køretøj
    {
        private string _regNr;

        public string RegNR
        {
            get { return _regNr; }
        }

        public Køretøj(string regNR)
        {
            _regNr = regNR;
        }

        public override string ToString()
        {
            return $"Regnummer {_regNr}";
        }

    }
}
