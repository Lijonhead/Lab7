using System.Drawing;

namespace Lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            Geometri[] former = new Geometri[5];

            former[0] = new Rektangel();
            former[1] = new Fyrkant();
            former[2] = new Cirkel();
            former[3] = new Parallellogram();
            former[4] = new Ellips();

            foreach (var form in former)
            {
                Console.WriteLine(form.Area());
            }


        }
    }
}