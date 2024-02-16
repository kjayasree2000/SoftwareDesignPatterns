using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignPatterns
{
    public class Bike : IVehicle
    {
        private readonly int wheels;

        public Bike()
        {
            this.wheels = 2;
        }

        public int NumberofWheels()
        {
            return this.wheels;
        }

        public string VehicleType()
        {
            return "bike class";
        }
    }
}
