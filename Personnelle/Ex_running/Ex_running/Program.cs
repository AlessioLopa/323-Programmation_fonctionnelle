using System.Net.Http;
using Newtonsoft.Json;

namespace Ex_running
{
    internal class Program
    {
        public record WeatherData(Hourly hourly);

        public record Hourly(string[] time, float[] temperature_2m, float[] precipitation, float[] wind_speed_10m);
        static async Task Main(string[] args)
        {
            HttpClient client = new HttpClient();
            string url = "https://api.open-meteo.com/v1/forecast?latitude=46.3833&longitude=6.2348&hourly=temperature_2m,precipitation,wind_speed_10m";

            var data = await client.GetStringAsync(url);

            var weatherData = JsonConvert.DeserializeObject<WeatherData>(data);

            var runningHours = GetBestRunningHours(weatherData.hourly);
            var countIdealHours = CountIdealSportHours(weatherData.hourly);

            Console.WriteLine(countIdealHours);
            foreach ( var hourly in runningHours )
            {
                if (runningHours.Count() == 0)
                {
                    Console.WriteLine("Aucune heure est idéal pour aller courir.");
                }
                else
                {
                    Console.WriteLine($"À {Convert.ToDateTime(hourly.Time)} la température est de {hourly.Temperature}, le niveau de précipitation est à {hourly.Precipitation} et le vent à une vitesse de {hourly.WindSpeed} km/h");
                }
            }


        }

        public static IEnumerable<(string Time, float Temperature, float Precipitation, float WindSpeed)> GetBestRunningHours(Hourly data)
        {
            return data.time.Select((t, Index) => new { Time = t, Temperature = data.temperature_2m[Index], Precipitation = data.precipitation[Index], Wind_speed = data.wind_speed_10m[Index] })
                .Where(item => item.Temperature < 22 && item.Temperature > 18 && item.Precipitation == 0 && item.Wind_speed < 10)
                .Select(x => (x.Time, x.Temperature, x.Precipitation, x.Wind_speed));
        }

        public static (float AvgTemmperature, float AvgWindSpeed) CalculateAverages(Hourly data)
        {
            float AvgTemmperature = data.temperature_2m.Average();
            float AvgWindSpeed = data.wind_speed_10m.Average();
            return (AvgTemmperature, AvgWindSpeed);
        }

        public static int CountIdealSportHours(Hourly data)
        {
            return data.time.Select((t, Index) => new { Temperature = data.temperature_2m[Index], Precipitation = data.precipitation[Index], Wind_Speed = data.wind_speed_10m[Index] })
                .Aggregate(0, (count, hour) =>
                {
                    if (hour.Temperature < 22 &&  hour.Temperature > 18 && hour.Precipitation == 0 && hour.Wind_Speed < 10)
                    {
                        return count++;
                    }
                    else
                    {
                        return count;
                    }
                });
        }


    }
}
