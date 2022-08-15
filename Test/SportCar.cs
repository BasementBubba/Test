using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class SportCar : Auto
    {
        public SportCar(string autoType, double midFuelConsumption, double fuelTankVolume,
            double maxSpeed, int currentPassengersCount, double currentFuelVolume)
            : base(autoType, midFuelConsumption, fuelTankVolume,
            maxSpeed, 2)
        {
            PassengersCount = currentPassengersCount;
            CurrentFuelTankVolume = currentFuelVolume;
        }
        public override double MaxCurrentDistance()
        {
            double koef = 1 - PassengersCount * 0.06;
            return (CurrentFuelTankVolume / MidFuelConsumption) * 100 * koef;
        }

        public override double MaxDistance()
        {
            double koef = 1 - PassengersCount * 0.06;
            return (FuelTankVolume / MidFuelConsumption) * 100 * koef;
        }
    }
}
