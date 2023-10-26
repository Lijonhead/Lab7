using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class Fyrkant : Geometri
    {
        
        public double Side { get; set; }
        public Fyrkant() 
        {
            
        Side = 100;
        }
        public override double Area()
        {
            Console.Write("Fyrkant Area: ");
            return Side * Side;
        }
    }
}
