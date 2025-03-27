using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Engine
    {
        public double mileage { get; set; }
        public double fuelEfficiency { get; set; }

        public bool isEngineOn = false;

        public void engineOn()
        {
            isEngineOn = true;
        }

        public void engineOff()
        {
            isEngineOn = false;
        }

    }
}
