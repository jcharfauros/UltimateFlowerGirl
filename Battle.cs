using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateFlowerGirl
{
    class Battle // THIS IS THE UI: utility class, all methods are going to be static
    {
        // StartFight
        // FlowerGirl1 FlowerGirl2
        public static void StartFlowerFight(FlowerGirl flowerGirl1, FlowerGirl flowerGirl2)
        {
            /* Note: this loop method is giving each flowergirls a chance 
             * to attack/block each turn until 1 has no more flowers in her hand 
             * 'While' loop that cont. forever until it meets game over and that ends the loop */

            Console.WriteLine("Welcome to the Bridezilla's ULTIMATE FLOWERGIRL BATTLE!\n" +
                "\nToday's UFB match is between Clare and Karen\n\n\n" +
                "LET'S GET REEEEADYYYY TO RUMBLE!!\n" +
                "(Press any key to start to start...)");

            Console.ReadKey();
            Console.Clear();

            bool keepAttacking = true;

            while (keepAttacking)
            {
                // flowergirl1 attacking flowergirl2
                // if this returns the value of "This Flower Throwdown is OVER!", then break the loop
                if (GetAttackResult(flowerGirl1, flowerGirl2) == "This Flower Throwdown is OVER!")
                {
                    Console.WriteLine("This Flower Throwdown is OVER!");
                    keepAttacking = false;
                }
                // flowergirl2 attacking flowergirl1
                if (GetAttackResult(flowerGirl2, flowerGirl1) == "This Flower Throwdown is OVER!")
                {
                    Console.WriteLine("This Flower Throwdown is OVER!");
                    keepAttacking = false;
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
                    //this sets it to 0, otherwise it skips this statement and keeps going
                    flowerGirlB.Flowers = 0;
                }
            }
            else dmg2FlowB = 0;


            Console.WriteLine("\n\n{0} growls, lunges and hits {1} {2} times!!\n",
                flowerGirlA.Name,
                flowerGirlB.Name,
                  dmg2FlowB); //total damage done                       

            // Print out how much was blocked by the defending flowergirl
            // OLD Console.WriteLine("{1} manages to block {0}'s attack and saves {2} flower(s)!!",
            Console.WriteLine("{1} dodges some of {0}'s punches and looks down \n" +
                "to see how many flowers she's still holding...",
                flowerGirlA.Name,
                flowerGirlB.Name);
            //flowBBlkAmt);

            // Provide output on the change in number of flowers a flowergirl is holding
            Console.WriteLine("\nAnnnd...{0} is holding {1} flower(s)!!!\n\n",
                flowerGirlB.Name,
                flowerGirlB.Flowers);

            // ADD Print out a reaction from the wedding guest depending on damage dealt
            if (dmg2FlowB >= 59 || dmg2FlowB == 70)
            {
                Console.WriteLine("There's an audible gasp from one of the wedding guests..\n");
            }
            else if (dmg2FlowB >= 49 || dmg2FlowB == 58)
            {
                Console.WriteLine("..the bride faints as the flowers scatter onto the lawn..\n");
            }
            else if (dmg2FlowB >= 39 || dmg2FlowB == 48)
            {
                Console.WriteLine("One of the Bridesmaids starts gathering fallen petals.\n");
            }
            else if (dmg2FlowB >= 29 || dmg2FlowB == 38)
            {
                Console.WriteLine("The groom's uncle's, cousin's, niece's date starts taking bets..\n");
            }
            else if (dmg2FlowB >= 19 || dmg2FlowB == 28)
            {
                Console.WriteLine("The mother of the bride moans, '...we spent so much money on this!'\n");
            }
            else if (dmg2FlowB >= 9 || dmg2FlowB == 18)
            {
                Console.WriteLine("The groom whispers to his new bride, '..let's get out of here *wink wink*..\n");
            }
            else if (dmg2FlowB >= 1 || dmg2FlowB == 8)
            {
                Console.WriteLine("One of the wedding guests holds up a fist full of money and says,\n" +
                    " '..I got fifty on {0}!!'\n",
                        flowerGirlA.Name);
            }
            else
            {
                return null;
            }
            Console.ReadKey(); //breaks so that the user can read the story            
            Console.Clear();

            // Check if the number of flowers the flowergirls are holding fell below 0,
            // if so, print a msg and then send a responds that ends the loop
            if (flowerGirlB.Flowers <= 0)
            {
                Console.WriteLine("\n{0} has lost all her flowers! " +
                    "{1} is the ULTIMATE FLOWER GIRL!!!\n" +
                    "THE GUESTS GO WILD!!\n" +
                    "{0} is bawls as she watches {1} do a victory dance.\n",
                     flowerGirlB.Name,
                     flowerGirlA.Name);
                return "This Flower Throwdown is OVER!";
            }
            else
            {
                return null;
            }
        }
    }
}