using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms
{
   class Room
    {
       public double height { get; set; }
       public double width { get; set; }
       public double lenght { get; set; }
       public int window { get; set; }

        public double Square (double w ,double h)
        {
            return w * h;
        }
        public double Volume(double w, double h, double l)
        {
            return w * h * l;
        }
    }
}
