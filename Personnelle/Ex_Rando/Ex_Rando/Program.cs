using Aspose.Gis;
using Aspose.Gis.Geometries;

namespace Ex_Rando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var layer = Drivers.Gpx.OpenLayer(@"C:\Users\pu41ecx\Documents\Github\323-Programmation_fonctionnelle\exos\rando\gpx\Ballade_châtaignère_🌰.gpx");

            foreach (var feature in layer)
            {
                var lines = (MultiLineString)feature.Geometry;
                foreach (var line in lines)
                {
                    Console.WriteLine(line.AsText());
                }
            }

        }
    }
}

