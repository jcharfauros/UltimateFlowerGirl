using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateFlowerGirl
{
    class Battle // JC note: utility class, all methods are going to be static
    {
        // StartFight
        // FlowerGirl1 FlowerGirl2
        public static void StartFlowerFight(FlowerGirl flowerGirl1, FlowerGirl flowerGirl2)
        {
            // JC note: this loop method is giving each flowergirls a chance 
            // to attack/block each turn until 1 has no more flowers in her hand
            // 'While' loop that cont. forever until it meets game over and that ends the loop
            while (true)
            {
                // flowergirl1 attacking flowergirl2
                // if this returns the value of "This Flower Throwdown is OVER!", then break the loop
                if (GetAttackResult(flowerGirl1, flowerGirl2) == "This Flower Throwdown is OVER!")
                {
                    Console.WriteLine("This Flower Throwdown is OVER!");
                    break;
                }
                // flowergirl2 attacking flowergirl1
                if (GetAttackResult(flowerGirl2, flowerGirl1) == "This Flower Throwdown is OVER!")
                {
                    Console.WriteLine("This Flower Throwdown is OVER!");
                    break;
                }
            }
        }

        // GetAttackResults
        // FlowerGirlA, FlowerGirlB (named this way because it's going to be random if it's flowergirl1 or flowergirl2)
        // string because it's going to returning the string "Game Over"

        public static string GetAttackResult(FlowerGirl flowerGirlA, FlowerGirl flowerGirlB)
        {
            // Calculate 1 flowergirls attack and the others block
            //JC note: pulling from methods
            double flowAAttkAmt = flowerGirlA.Attack();
            double flowBBlkAmt = flowerGirlB.Block();

            // Subtract block from attack   
            double dmg2FlowB = flowAAttkAmt - flowBBlkAmt;

            // If there was damage subtract that from the number of flowers
            if (dmg2FlowB > 0)
            {
                flowerGirlB.Flowers = flowerGirlB.Flowers - dmg2FlowB;
            }
            else dmg2FlowB = 0;

            // Print out info on who attacked who and for how much damage
            // JC note: flowergirl attacks other flowergirl and damage (loss of flowers to blocking flowergirl)
            Console.WriteLine("{0} Attacks {1} and Deals {2} Damage",
                flowerGirlA.Name,
                flowerGirlB.Name,
                  dmg2FlowB); //total damage done

            // Provide output on the change in number of flowers a flowergirl is holding
            Console.WriteLine("{0} is holding {1} Flowers\n",
                flowerGirlB.Name,
                flowerGirlA.Flowers);

            // Check if the number of flowers the flowergirls
            // are holding fell below 0 and if so print a msg
            // and then send a respond that ends the loop
            if (flowerGirlB.Flowers <= 0)
            {
                Console.WriteLine("{0} has lost all her flowers! " +
                    "{1} is the Ultimate Flower Girl!!!\n",
                     flowerGirlB.Name,
                     flowerGirlA.Name);
                return "This Flower Throwdown is OVER!";
            }
            else
            { 
                return "Flower Throwdown Again";  //NOTE: NOT SURE WHAT THIS IS DOING, ASK SOMEONE
            }

            //Console.WriteLine("Please press any key to throwdown again...");
            //Console.ReadKey();
            //Console.Clear();

        }
    }
}
