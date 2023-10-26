using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class Cirkel : Geometri
    {

        public double  Radius { get; set; }
        public Cirkel() 
        {
            
        Radius = 3;
        }
        public override double Area()
        {
            Console.Write("Cirkel Area: ");
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
