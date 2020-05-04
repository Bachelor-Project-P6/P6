using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport_guidance
{
    //Makes a global queue, accessed through the Dest constructor rather than by accessing the queue directly.
    public class Destinations
    {
        private static Queue<string> stops;
        public static Queue<string> Dest
        {
            get { return stops; }
            set { stops = value; }
        }
    }
}
