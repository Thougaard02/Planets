using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Planet> planets = new List<Planet>();
            planets.Add(new Planet("Mercury", 0.330, 4879, 5427, 3.7, TimeSpan.FromHours(1407.6), TimeSpan.FromHours(4222.6), 57.9, TimeSpan.FromDays(88.0), 47.4, 167, 0, false));
            planets.Add(new Planet("Earth", 5.97, 12756, 5514, 9.8, TimeSpan.FromHours(23.9), TimeSpan.FromHours(24), 149.6, TimeSpan.FromDays(365.2), 29.8, 15, 1, false));
            planets.Add(new Planet("Mars", 0.642, 6792, 3933, 3.7, TimeSpan.FromHours(24.6), TimeSpan.FromHours(24.7), 227.9, TimeSpan.FromDays(687.0), 24.1, -65, 2, false));
            planets.Add(new Planet("Jupiter", 1898, 142984, 1326, 23.1, TimeSpan.FromHours(9.9), TimeSpan.FromHours(9.9), 778.6, TimeSpan.FromDays(4331), 13.1, -110, 67, true));
            planets.Add(new Planet("Sarturn", 568, 120536, 687, 9.0, TimeSpan.FromHours(10.7), TimeSpan.FromHours(10.7), 1433.5, TimeSpan.FromDays(10.747), 9.7, -140, 62, true));
            planets.Add(new Planet("Uranus", 86.8, 51118, 1271, 8.7, TimeSpan.FromHours(-17.2), TimeSpan.FromHours(17.2), 2872.5, TimeSpan.FromDays(30.589), 6.8, -195, 27, true));
            planets.Add(new Planet("Neptune", 102, 49528, 1638, 11.0, TimeSpan.FromHours(16.1), TimeSpan.FromHours(16.1), 2872.5, TimeSpan.FromDays(59.8), 5.4, -200, 14, true));
            planets.Add(new Planet("Pluto", 0.0146, 2370, 2095, 0.7, TimeSpan.FromHours(-153.3), TimeSpan.FromHours(153.3), 5906.4, TimeSpan.FromDays(90.56), 4.7, -255, 5, false));

            planets.Insert(1, new Planet("Venus", 4.87, 12104, 5243, 8.9, TimeSpan.FromHours(-5832.5), TimeSpan.FromHours(2802.0), 108.2, TimeSpan.FromDays(224.7), 35.0, 464, 0, false));
            planets.RemoveAt(8);
            planets.Insert(8, new Planet("Pluto", 0.0146, 2370, 2095, 0.7, TimeSpan.FromHours(-153.3), TimeSpan.FromHours(153.3), 5906.4, TimeSpan.FromDays(90.56), 4.7, -255, 5, false));

            List<Planet> noMeanTemperature = new List<Planet>();
            List<Planet> diameter = new List<Planet>();

            foreach (Planet planet in planets)
            {
                //Prints all plants in the planets list
                Console.WriteLine(planet.PlanetName);

                //Adds the planets that has a mean temperature under 0 to the noMeanTemperatue list
                if (planet.MeanTemperature < 0)
                {
                    noMeanTemperature.Add(planet);
                }
                //Adds the planets that has a diameter between 10000km and 50000km to the diameter list
                if (planet.Diameter > 10000 && planet.Diameter < 50000)
                {
                    diameter.Add(planet);
                }
            }

            Console.WriteLine();

            //Plant count
            Console.WriteLine(planets.Count());

            Console.WriteLine();

            //Mean Temperature planet
            foreach (Planet planet in noMeanTemperature)
            {
                Console.WriteLine(planet.PlanetName);
            }

            Console.WriteLine();

            //Diameter of planet
            foreach (Planet planet in diameter)
            {
                Console.WriteLine(planet.PlanetName);
            }

            //Removes all elements in planets list
            planets.Clear();
            foreach (Planet planet in planets)
            {
                //Nohting appear beacuse we have cleared the list
                Console.WriteLine(planet.PlanetName);
            }
        }
    }
}
