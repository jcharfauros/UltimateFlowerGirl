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
            FlowerGirl karen = new FlowerGirl
                ("Karen", 150, 70, 5); //NAME, FLOWERS, ATTACK power, BLOCK power

            FlowerGirl claire = new FlowerGirl
                ("Claire", 150, 70, 5);

            Battle.StartFlowerFight(karen, claire);

            Console.ReadLine();

        }
    }
}
