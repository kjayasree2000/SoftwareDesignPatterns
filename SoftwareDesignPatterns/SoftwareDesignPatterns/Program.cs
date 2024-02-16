using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            ////DependencyInjection ds = new DependencyInjection();
            ////SUV suvcar = new SUV();
            ////Compact comcar = new Compact();
            //////Constructor Injection
            ////ds.PrintCar(suvcar);
            ////ds.PrintCar(comcar);
            ////Console.ReadLine();
            ///


            string vehiclename = Console.ReadLine();
            VehicleFactory vf = new VehicleFactory();
            Console.WriteLine(vf.GetVehicle(vehiclename).NumberofWheels());
            Console.ReadLine();
            

        }
    }
}
