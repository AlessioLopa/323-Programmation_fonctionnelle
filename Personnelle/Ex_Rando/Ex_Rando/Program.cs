using Aspose.Gis;
using Aspose.Gis.Formats.FileGdb;
using Aspose.Gis.Geometries;
using Aspose.Gis.GeoTools.Extensions;

namespace Ex_Rando
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var layer = Drivers.Gpx.OpenLayer(@"C:\Users\pu41ecx\Documents\Github\323-Programmation_fonctionnelle\exos\rando\gpx\Petit_mountet_2019.gpx");


            //extraire sous forme de LAT,LONG,ELE ...
            var data = layer.First().Geometry.AsText().Replace("((","").Replace("))","").Replace("MULTILINESTRING Z","").Trim();

            var tp = data
                .Split(",")
                .Select(rawPoint => rawPoint.Trim().Split(" "))
                .Select(rp => new Trackpoint(rp[0], rp[1], rp[2]));

            double distance = CalculateDistance(tp.First()._latitude, tp.First()._longitude, tp.Last()._latitude, tp.Last()._longitude);

            Console.WriteLine($"{distance:F2} Km");

            

        }

        // Méthode principale pour calculer la distance entre deux points avec latitude et longitude uniquement
        public static double CalculateDistance(double lat1, double lon1, double lat2, double lon2)
        {

            const double EarthRadius = 6371.0;

            // Conversion des degrés en radians
            double lat1Rad = DegreesToRadians(lat1);
            double lat2Rad = DegreesToRadians(lat2);
            double lon1Rad = DegreesToRadians(lon1);
            double lon2Rad = DegreesToRadians(lon2);

            // Calcul de la différence des coordonnées
            double deltaLat = lat2Rad - lat1Rad;
            double deltaLon = lon2Rad - lon1Rad;

            // Application de la formule de Haversine pour la distance horizontale
            double a = Math.Sin(deltaLat / 2) * Math.Sin(deltaLat / 2) +
                       Math.Cos(lat1Rad) * Math.Cos(lat2Rad) *
                       Math.Sin(deltaLon / 2) * Math.Sin(deltaLon / 2);

            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            double horizontalDistance = EarthRadius * c;

            return horizontalDistance;
        }

        // Méthode pour convertir des degrés en radians
        private static double DegreesToRadians(double degrees)
        {
            return degrees * Math.PI / 180.0;
        }
    }
}

