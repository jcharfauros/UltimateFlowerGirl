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
                ("Isobel", 1200, 110, 50); //JC note: name, number of flowers she is holding, attack power, blocking power

            FlowerGirl persephone = new FlowerGirl
                ("Persephone", 1200, 110, 50);

            Battle.StartFlowerFight(isobel, persephone);

            Console.ReadLine();

        }
    }
}
