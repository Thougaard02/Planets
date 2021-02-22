using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets
{
    class Planet
    {

        private string  planetName;

        public string  PlanetName
        {
            get { return planetName; }
            set { planetName = value; }
        }

        private double mass;

        public double Mass
        {
            get { return mass; }
            set { mass = value; }
        }

        private double diameter;

        public double Diameter
        {
            get { return diameter; }
            set { diameter = value; }
        }

        private int density;

        public int Density
        {
            get { return density; }
            set { density = value; }
        }

        private double gravity;

        public double Gravity
        {
            get { return gravity; }
            set { gravity = value; }
        }

        private TimeSpan rotationPeriod;

        public TimeSpan RotationPeriod
        {
            get { return rotationPeriod; }
            set { rotationPeriod = value; }
        }

        private TimeSpan lengthOfDay;

        public TimeSpan LengthOfDay
        {
            get { return lengthOfDay; }
            set { lengthOfDay = value; }
        }

        private double distanceFromSun;

        public double DistanceFromSun
        {
            get { return distanceFromSun; }
            set { distanceFromSun = value; }
        }

        private TimeSpan orbitalPeriod;

        public TimeSpan OrbitalPeriod
        {
            get { return orbitalPeriod; }
            set { orbitalPeriod = value; }
        }

        private double orbitalVelocity;

        public double OrbitalVelocity
        {
            get { return orbitalVelocity; }
            set { orbitalVelocity = value; }
        }

        private double meanTemperature;

        public double MeanTemperature
        {
            get { return meanTemperature; }
            set { meanTemperature = value; }
        }

        private int numberOfMoons;

        public int NumberOfMoons
        {
            get { return numberOfMoons; }
            set { numberOfMoons = value; }
        }

        private bool ringSystem;

        public bool RingSystem
        {
            get { return ringSystem; }
            set { ringSystem = value; }
        }

        public Planet(string planetName, double mass, double diameter, int density, double gravity, TimeSpan rotationPeriod, TimeSpan lengthOfDay, double distanceFromSun, TimeSpan orbitalPeriod, double orbitalVelocity, double meanTemperature, int numberOfMoon, bool ringSystem)
        {
            PlanetName = planetName;
            Mass = mass;
            Diameter = diameter;
            Density = density;
            Gravity = gravity;
            RotationPeriod = rotationPeriod;
            LengthOfDay = lengthOfDay;
            DistanceFromSun = distanceFromSun;
            OrbitalPeriod = orbitalPeriod;
            OrbitalVelocity = orbitalVelocity;
            MeanTemperature = meanTemperature;
            NumberOfMoons = numberOfMoon;
            RingSystem = ringSystem;
        }
    }
}
