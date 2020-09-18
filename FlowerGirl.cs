using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateFlowerGirl
{
    class FlowerGirl //THIS IS THE REPO
    {
        // Name Flowers Attack Maximum Block Maximum        
        public string Name { get; set; } =
            "FlowerGirl";        
        public int Flowers { get; set; }
        public int AttkMax { get; set; }
        public int BlockMax { get; set; }
                
        // Note: create a single random instance and reuse it over again,
        //  otherwise you will get the same random number over again
        Random rnd = new Random();

        // constructor to initialize everything
        public FlowerGirl(string name, int flowers, int attkMax, int blockMax)
        {
            Name = name;
            Flowers = flowers;
            AttkMax = attkMax;
            BlockMax = blockMax;
        }
                
        // ATTACK method: Generate random attack from 1 to max attack        
        public int Attack()
        {
                                //converting int to integer
            return rnd.Next(1,AttkMax);
        }
                
        // BLOCK method: Generate random block from 1 to max block        
        public int Block()
        {
            /*OLD code: converting int to integer
            return rnd.Next(1, (int)BlockMax);*/
            return rnd.Next(1,BlockMax);
        }

    }
}
