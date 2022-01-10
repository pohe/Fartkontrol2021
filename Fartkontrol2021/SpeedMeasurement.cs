using System;
using System.Collections.Generic;
using System.Text;

namespace Fartkontrol2021
{
    public class SpeedMeasurement
    {
        public DateTime TimeStamp { get; private set; }
        public int Speed { get; private set; }

        private int _id;

        public int Id
        {
            get { return _id; }
        }

        private static int counter = 0; 
        public SpeedMeasurement(int speed)
        {
            TimeStamp = DateTime.Now;
            Speed = speed;
            counter++;
            _id = counter; 
        }

        public override string ToString()
        {
            return $"Speedmeasurement id {_id} speed { Speed.ToString("0.##")} time {TimeStamp}";
        }

    }
}
