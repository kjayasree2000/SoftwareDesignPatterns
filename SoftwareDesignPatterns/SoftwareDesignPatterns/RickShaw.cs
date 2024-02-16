using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignPatterns
{
    public class RickShaw : IVehicle
    {
        private readonly int wheels;

        public RickShaw()
        {
            this.wheels = 3;
        }

        public int NumberofWheels()
        {
            return wheels;
        }

        public string VehicleType()
        {
            return "RickShaw Class";
        }

    }
}
