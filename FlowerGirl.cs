using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateFlowerGirl
{
    class FlowerGirl
    {
        // Name Flowers Attack Maximum Block Maximum
        // JC notes: the following are attributes Name/Flowers/AttkMax/BlockMax
        public string Name { get; set; } =
            "FlowerGirl";
                                        //default value
        public double Flowers { get; set; } = 0;
        public double AttkMax { get; set; } = 0;
        public double BlockMax { get; set; } = 0;

        // Random numbers
        // JC note: create a single random instance and reuse it over again
        //  otherwise you will get the same random number over again
        Random rnd = new Random();

        //JC note: constructor to initialize everything
        public FlowerGirl(string name = "FlowerGirl",
            double flowers = 0,
            double attMax = 0,
            double blockMax = 0)
        {
            Name = name;
            Flowers = flowers;
            AttkMax = attMax;
            BlockMax = blockMax;
        }

        // Attack
        // Generate random attack from 1 to max attack
        // JC note: this is a method
        public double Attack()
        {
                                //converting double to integer
            return rnd.Next(1, (int)AttkMax);
        }

        // Block
        // Generate random block from 1 to max block
        // JC note: this is a method
        public double Block()
        {
                                //converting double to integer
            return rnd.Next(1, (int)BlockMax);
        }

    }
}
