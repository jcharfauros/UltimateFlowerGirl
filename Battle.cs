using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateFlowerGirl
{
    class Battle // THIS IS THE UI JC note: utility class, all methods are going to be static
    {
        // StartFight
        // FlowerGirl1 FlowerGirl2
        public static void StartFlowerFight(FlowerGirl flowerGirl1, FlowerGirl flowerGirl2)
        {
            /* Note: this loop method is giving each flowergirls a chance 
             * to attack/block each turn until 1 has no more flowers in her hand 
             * 'While' loop that cont. forever until it meets game over and that ends the loop */

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
        /*FlowerGirlA, FlowerGirlB (named this way because it's going to be random 
         * if it's flowergirl1 or flowergirl2) string because it's going to be 
         * returning the string "This Flower Throwdown is OVER!" */

        public static string GetAttackResult(FlowerGirl flowerGirlA, FlowerGirl flowerGirlB)
        {
            // Calculate 1 flowergirls attack and the others block (pulling from methods)
            int flowAAttkAmt = flowerGirlA.Attack();
            int flowBBlkAmt = flowerGirlB.Block();

            // Subtract block from attack   
            int dmg2FlowB = flowAAttkAmt - flowBBlkAmt;

            // If there was damage subtract that from the number of flowers
            if (dmg2FlowB > 0)
            {
                // calculates how many flowers are left
                flowerGirlB.Flowers = flowerGirlB.Flowers - dmg2FlowB;
                // if they are left with a negative number  
                if (flowerGirlB.Flowers <= 0)
                {
                    // this sets it to 0, otherwise it skips this statement and keeps going
                    flowerGirlB.Flowers = 0;
                }
            }
            else dmg2FlowB = 0;

            // Print out info on who attacked who and for how much damage
            /* Note: flowergirl attacks other flowergirl and causes 
             * damage (damage = loss of flowers that wasn't blocked) */
            Console.WriteLine("\n\n{0} attacks {1} and knocks {2} flower(s) out of {1} arms!",
                flowerGirlA.Name,
                flowerGirlB.Name,
                  dmg2FlowB); //total damage done

            // ADD Print out a reaction from the wedding guest depending on damage dealt
            if (dmg2FlowB >= 59 || dmg2FlowB == 70)
            {
                Console.WriteLine("\nThere's an audible gasp from one of the wedding guests..");
            }
            else if (dmg2FlowB >= 49 || dmg2FlowB == 58)
            {
                Console.WriteLine("\n..the bride faints as the flowers scatter onto the lawn..");
            }
            else if (dmg2FlowB >= 39 || dmg2FlowB == 48)
            {
                Console.WriteLine("\nOne of the Bridesmaids starts gathering fallen petals.");
            }
            else if (dmg2FlowB >= 29 || dmg2FlowB == 38)
            {
                Console.WriteLine("\nThe groom's uncle's, cousin's, niece's date starts taking bets..");
            }
            else if (dmg2FlowB >= 19 || dmg2FlowB == 28)
            {
                Console.WriteLine("\nThe mother of the bride moans, '...we spent so much money on this!'");
            }
            else if (dmg2FlowB >= 9 || dmg2FlowB == 18)
            {
                Console.WriteLine("\nThe groom whispers to his new bride, '..let's get out of here *wink wink*..");
            }
            else if (dmg2FlowB >= 1 || dmg2FlowB == 8)
            {
                Console.WriteLine("\nOne of the wedding guests holds up a fist full of money and says,\n" +
                    " '..I got fifty on {0}!!'",
                        flowerGirlA.Name);
            }
            else
            {
                return null;
            }
            Console.ReadKey();

            // ADD Print out how much was blocked by the defending flowergirl
            Console.WriteLine("{1} manages to block {0}'s attack and saves {2} flower(s)!!",
                flowerGirlA.Name,
                flowerGirlB.Name,
                    flowBBlkAmt);

            // Provide output on the change in number of flowers a flowergirl is holding
            Console.WriteLine("\n{0} is holding {1} flower(s)!!!\n\n",
                flowerGirlB.Name,
                flowerGirlB.Flowers);

            // Check if the number of flowers the flowergirls are holding fell below 0,
            // if so, print a msg and then send a responds that ends the loop
            if (flowerGirlB.Flowers <= 0)
            {
                Console.WriteLine("\n{0} has lost all her flowers! " +
                    "{1} is the ULTIMATE FLOWER GIRL!!!\n" +
                    "THE GUESTS GO WILD!!\n" +
                    "Tears runs down {0}'s face as she watches \n" +
                    "{1} do a victory dance.\n",
                     flowerGirlB.Name,
                     flowerGirlA.Name);
                return "This Flower Throwdown is OVER!";
            }
            else //NOTE: NOT SURE IF THIS IS DOING ANYTHING
            {
                return "Flower Throwdown Again";
            }
        }
    }
}
