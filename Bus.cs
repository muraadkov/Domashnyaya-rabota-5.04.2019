using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race
{
    class Bus : Car
    {
        public string Name { get; set; }
        public void StartRide()
        {
            Start(Name, Speed(new Random(), 200, 600));
        }
    }
}
