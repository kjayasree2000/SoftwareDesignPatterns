using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDesignPatterns
{
    public class Pub
    {
        public event EventHandler<MyEventArgs> onchange = delegate { };

        public void Raise()
        {
            if (onchange != null)
            {
                onchange(this, new MyEventArgs(33));
            }
        }

    }
}
