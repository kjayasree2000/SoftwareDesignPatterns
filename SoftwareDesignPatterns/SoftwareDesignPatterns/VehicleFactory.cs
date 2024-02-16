using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignPatterns
{
    public class VehicleFactory 
    {
        IVehicle objecttype = null;        

        public IVehicle GetVehicle(string vehicleName)
        {
            if (vehicleName.ToLower().Equals("car")){
                objecttype = new Car();
            }

            else if (vehicleName.ToLower().Equals("bike"))
            {
                objecttype = new Bike();
            }

            else if (vehicleName.ToLower().Equals("rickshaw"))
            {
                objecttype = new RickShaw();
            }

            return objecttype;

        }

    }
}
