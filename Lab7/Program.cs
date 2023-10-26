using System.Drawing;

namespace Lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {


            
            List<Geometri> list = new()
            {
                new Fyrkant(),
                new Cirkel(),
                new Rektangel(),
                new Ellips(),
                new Parallellogram()
            };
            foreach (var item in list)
            {
                Console.WriteLine(item.Area());
            }
        }
    }
}