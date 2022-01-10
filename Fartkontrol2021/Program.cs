using System;

namespace Fartkontrol2021
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeedMeasurementCatalog catalog = new SpeedMeasurementCatalog("Gade 12", "By", 50);

            try
            {
                catalog.AddSpeedMeasurement(45);
                catalog.AddSpeedMeasurement(100);
                catalog.AddSpeedMeasurement(90);
                catalog.AddSpeedMeasurement(500);
            }
            catch (ArgumentException aex)
            {
                Console.WriteLine(aex.Message);
            }
            Console.WriteLine($"Gennemsnitlig hastighed {catalog.AvarageSpeed().ToString("0.##")}");
            Console.WriteLine(catalog.ToString());
            Console.WriteLine($"Antal registreringer over hastighedsgrænsen {catalog.NoOfOverSpeedLimit()}");
            Console.WriteLine($"Antal klip i kørekortet over hastighedsgrænsen (for-loop) {catalog.NoOfOverSpeedLimit()}");
            Console.WriteLine($"Antal registreringer over hastighedsgrænsen (foreach-loop){catalog.NoOfCutInLicenseForeach()}");

            Lastvogn lastvogn = new Lastvogn("AB 123444", 200000);
            Personbil personbil = new Personbil("CB", 5);
            Console.WriteLine(lastvogn.ToString());
            Console.WriteLine(personbil.ToString());

            Console.WriteLine($"Antal betinget frakendelser {catalog.NoOfConditionalRevocation()}");
        }
    }
}
