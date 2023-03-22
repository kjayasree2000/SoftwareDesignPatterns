using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignPatterns
{
    class DependencyInjection
    {
        // Constructor InJection
        readonly SUV suvobj = new SUV();
        readonly Compact comobj = new Compact();

        public void PrintCar(ICAR obj)
        {
            obj.GetCost();
            obj.GetColor();
        }     

    }

    interface ICAR
    {
        void GetCost();
        void GetColor();
    }

    public class SUV : ICAR
    {
        public void GetCost()
        {
            Console.WriteLine("Cost of SUV is $50K");            
        }

        public void GetColor()
        {
            Console.WriteLine("Available color is Blue");
        }
    }

    public class Compact : ICAR
    {
        public void GetCost()
        {
            Console.WriteLine("Cost of Compact is $30K");
        }

        public void GetColor()
        {
            Console.WriteLine("Available Color is Grey");
        }
    }
}
