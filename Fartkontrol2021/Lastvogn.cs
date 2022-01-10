using System;
using System.Collections.Generic;
using System.Text;

namespace Fartkontrol2021
{
    public class Lastvogn: Køretøj   
    {
        private int _maxLoad;

        public int MaxLoad
        {
            get { return _maxLoad; }
            set { _maxLoad = value; }
        }
        public Lastvogn(string regnr, int maxload): base(regnr)
        {
            _maxLoad = maxload;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Lastvogn maxload {_maxLoad}";
        }

    }
}
