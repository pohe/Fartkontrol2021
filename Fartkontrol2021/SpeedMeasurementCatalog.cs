using System;
using System.Collections.Generic;
using System.Text;

namespace Fartkontrol2021
{
    class SpeedMeasurementCatalog
    {
        private List<SpeedMeasurement> measurements;

        public string Address { get; set; }
        public string Zone { get; set; }

        public int SpeedLimit { get; set; }

        public SpeedMeasurementCatalog(string address, string zone, int speedLimit)
        {
            Address = address;
            Zone = zone;
            SpeedLimit = speedLimit;
            measurements = new List<SpeedMeasurement>();
        }

        public void AddSpeedMeasurement(int speed)
        {
            if (speed > 0 && speed <= 300)
                measurements.Add(new SpeedMeasurement(speed));
            else
            {
                throw new ArgumentException("Incorrect speed");
            }
        }

        public double AvarageSpeed()
        {
            if (measurements.Count == 0)
                return 0.0;
            int total = 0;
            foreach (SpeedMeasurement speedMeasurement in measurements)
            {
                total = total + speedMeasurement.Speed;
            }

            return ((double)total) / measurements.Count;
        }

        public override string ToString()
        {
            string speedMeasurements = "";
            foreach(SpeedMeasurement m in measurements)
            {
                speedMeasurements += m.ToString() + "\n\t";
            }

            return $"Address {Address} Zone {Zone} SpeedLimit {SpeedLimit}\n SpeedMeasurements: \n\t{speedMeasurements}";
        }

        public int NoOfOverSpeedLimit()
        {
            int no = 0;
            foreach (SpeedMeasurement speedMeasurement in measurements)
            {
                if (speedMeasurement.Speed > SpeedLimit)
                    no++;
            }
            return no;
        }

        public int NoOfCutInLicense()
        {
            int no = 0;
            for(int i =0; i<measurements.Count; i++)
            {
                if (measurements[i].Speed > (SpeedLimit * 1.30))
                {
                    no++;
                }
            }
            return no;
        }

        public int NoOfCutInLicenseForeach()
        {
            int no = 0;
            foreach (SpeedMeasurement speedMeasurement in measurements)
            {
                if (speedMeasurement.Speed > (SpeedLimit * 1.30))
                {
                    no++;
                }
            }
            return no;
        }

        public int NoOfConditionalRevocation()
        {
            int no = 0;
            foreach (SpeedMeasurement speedMeasurement in measurements)
            {
                if (Zone == "Motorvej" && SpeedLimit == 130 && speedMeasurement.Speed > (SpeedLimit * 1.30))
                {
                    no++;
                }
                else if (speedMeasurement.Speed > (SpeedLimit * 1.60))
                {
                    no++;
                }
            }
            return no;
        }

    }
}
