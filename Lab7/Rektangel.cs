using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class Rektangel : Geometri
    {
        public Rektangel() 
        {
            Length = 20;
            Width = 4;
            
        }

        public double Length { get; set; }
        public double Width { get; set; }
        public override double Area()
        {
            Console.Write("Rektangel Area: ");
            return Length * Width;
        }
    }
}
