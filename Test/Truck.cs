using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Truck : Auto
    {
        private double maxCargoWeight;
        private double MaxCargoWeight
        {
            get
            {
                return maxCargoWeight;
            }
            set
            {
                if (value > 0) maxCargoWeight = value;
                else throw new ArgumentException("Max cargo weight must be > 0");
            }
        }
        private double currentCargoWeight;
        private double CurrentCargoWeight
        {
            get
            {
                return currentCargoWeight;
            }
            set
            {
                if (value >= 0 && value <= MaxCargoWeight) currentCargoWeight = value;
                else throw new ArgumentException("Current cargo weight must be > or = 0 and < or = Max weight");
            }
        }

        public Truck(string autoType, double midFuelConsumption, double fuelTankVolume,
            double maxSpeed, int maxPassengersCount, int currentPassengersCount, double currentFuelVolume,
            double maxCargoweight, double currentCargoweight) 
            : base(autoType, midFuelConsumption, fuelTankVolume, maxSpeed, maxPassengersCount)
        {
            PassengersCount = currentPassengersCount;
            CurrentFuelTankVolume = currentFuelVolume;
            MaxCargoWeight = maxCargoweight;
            CurrentCargoWeight = currentCargoweight;
        }

        public override double MaxCurrentDistance()
        {
            double koef = 1 - 0.06 * PassengersCount - 0.04 * (200 / CurrentCargoWeight);
            return (CurrentFuelTankVolume / MidFuelConsumption) * 100 * koef;
        }

        public override double MaxDistance()
        {
            double koef = 1 - 0.06 * PassengersCount - 0.04 * (200 / CurrentCargoWeight);
            return (FuelTankVolume / MidFuelConsumption) * 100 * koef;
        }
    }
}
