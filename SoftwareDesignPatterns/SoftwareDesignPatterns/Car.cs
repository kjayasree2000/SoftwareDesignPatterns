using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignPatterns
{
    public class Car : IVehicle
    {
        private readonly int wheels;

        public Car()
        {
            this.wheels = 4;
        }

        public int NumberofWheels()
        {
            return wheels;

        }
        public string VehicleType()
        {
            return "Car class";
        }

    }
}
