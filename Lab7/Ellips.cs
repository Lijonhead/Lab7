using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class Ellips : Geometri
    {

        public double Major { get; set; }
        public double Minor { get; set; }

        public Ellips() 
        { 
            
        Major = 4;
            Minor = 8;
        }
        public override double Area()
        {
            Console.Write("Ellips Area: ");
            return Math.PI * (Major * Minor);
        }
    }
}
