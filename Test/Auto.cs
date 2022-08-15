using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal abstract class Auto
    {
        protected string AutoType { get; set; }
        private double midFuelConsumption;
        protected double MidFuelConsumption
        {
            get
            {
                return midFuelConsumption;
            }
            set
            {
                if (value > 0 && value < 100)
                {
                    midFuelConsumption = value;
                }
                else throw new ArgumentException("Middle fuel consumption must be > 0 and < 100");
            }
        }

        private double fuelTankVolume;
        protected double FuelTankVolume
        {
            get
            {
                return fuelTankVolume;
            }
            set
            {
                if (value > 0)
                {
                    fuelTankVolume = value;
                }
                else throw new ArgumentException("Fuel tank volume must be > 0");
            }
        }

        private double currentFuelTankVolume;
        protected double CurrentFuelTankVolume
        {
            get
            {
                return currentFuelTankVolume;
            }
            set
            {
                if (value >= 0 && value <= FuelTankVolume)
                {
                    currentFuelTankVolume = value;
                }
                else throw new ArgumentException("Current fuel volume must be > or = 0 and < or = Max fuel volume");
            }
        }

        private double maxSpeed;
        protected double MaxSpeed
        {
            get
            {
                return maxSpeed;
            }
            set
            {
                if (value > 0 && value < 500) maxSpeed = value;
                else throw new ArgumentException("Max speed must be > or = 0 and < 500");
            }
        }

        private double currentMidSpeed;
        protected double CurrentMidSpeed
        {
            get
            {
                return currentMidSpeed;
            }
            set
            {
                if (value >= 0 && value <= MaxSpeed)
                {
                    currentMidSpeed = value;
                }
                else throw new ArgumentException("Current speed must be > or = 0 and < or = MaxSpeed");
            }
        }

        private int passengersCount;
        protected int PassengersCount
        {
            get
            {
                return passengersCount;
            }
            set
            {
                if (value > 0 && value <= MaxPassengersCount)
                {
                    passengersCount = value;
                }
                else throw new ArgumentException("Current passengers count must be > 0 and < Max passengers count");
            }
        }

        private int maxPassengersCount;
        protected int MaxPassengersCount
        {
            get
            {
                return maxPassengersCount;
            }
            set
            {
                if (value > 0)
                {
                    maxPassengersCount = value;
                }
                else throw new ArgumentException("Max passengers count must be > 0");
            }
        }

        public Auto(string autoType, double midFuelConsumption, double fuelTankVolume,
            double maxSpeed, int maxPassengersCount)
        {
            AutoType = autoType;
            MidFuelConsumption = midFuelConsumption;
            FuelTankVolume = fuelTankVolume;
            MaxSpeed = maxSpeed;
            MaxPassengersCount = maxPassengersCount;
        }

        public abstract double MaxDistance();
        public abstract double MaxCurrentDistance();
        public double TimeToCross(double distance, double middleSpeed)
        {
            return distance / middleSpeed;
        }
        public void SetCurrentSpeed(double speed)
        {
            CurrentMidSpeed = speed;
        }
        public void SetCurrentPassengersCount(int count)
        {
            PassengersCount = count;
        }
        public void SetCurrentFuel(double volume)
        {
            CurrentFuelTankVolume = volume;
        }
    }
}
