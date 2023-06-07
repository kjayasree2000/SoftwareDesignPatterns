using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignPatterns
{
    public class MyEventArgs: EventArgs
    {
        public int Value { get; set; }

        public MyEventArgs(int Value)
        {
            this.Value = Value;
        }

    }
}
