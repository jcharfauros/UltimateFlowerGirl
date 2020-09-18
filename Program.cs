using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateFlowerGirl
{
    class Program
    {
        static void Main(string[] args)
        {
            FlowerGirl isobel = new FlowerGirl
                ("Isobel", 150, 70, 5); //NAME, FLOWERS, ATTACK power, BLOCK power

            FlowerGirl persephone = new FlowerGirl
                ("Persephone", 150, 70, 5);

            Battle.StartFlowerFight(isobel, persephone);

            Console.ReadLine();

        }
    }
}
