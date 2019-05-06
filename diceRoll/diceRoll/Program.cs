using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace diceRoll
{
    class Program
    {


        public static int rollDice()
        {
            Random number = new Random();

            int dice = number.Next(1,6);

            return dice;
        }

        public static void displayStats(List<int> allNumbersRolled, int size)
        {
            Console.WriteLine("\n ====================== Displaying Stats ====================== \n\n");
            int sum = 0;
            int amountOfRolls = 1;

            if (allNumbersRolled.Count != 0)
            {
                for (int numberRolled = 0; numberRolled < size; numberRolled++)
                {
                    Console.WriteLine("Roll no. " + amountOfRolls + " the number rolled was " + allNumbersRolled[numberRolled]);
                    amountOfRolls++;
                    sum += allNumbersRolled[numberRolled];



                }
            }

            double average = (float) sum / (float) size;
            Console.WriteLine("Total sum of all rolls : " + sum);
            Console.WriteLine("Total average of all rolls : " + average);
            Console.WriteLine(allNumbersRolled.Count);
        } 

        static void Main(string[] args)
        {

            bool stillPlaying = true;
            int choice, numberRolled;
            List<int> allNumbersRolled = new List<int>();
            string secondInput; 
            while (stillPlaying)
            {
                Console.WriteLine("Enter in '1' to roll. \nEnter in '2' to display stats \nEnter '3' to quit. \n\n");
                choice = int.Parse(Console.ReadLine()); 

                if (choice == 1)
                {
                    numberRolled = rollDice();
                    Console.WriteLine("Rolling.......\t" + numberRolled);
                    allNumbersRolled.Add(numberRolled);
                } else if (choice == 2)
                {
                    Console.WriteLine("Enter in a number to calculate stats upto \nOr enter in 'a' to display stats for all numbers entered until now. \n");
                    secondInput = Console.ReadLine().ToLower();

                    if (secondInput == "a")
                    {
                        displayStats(allNumbersRolled, allNumbersRolled.Count);
                    } else
                    {
                        displayStats(allNumbersRolled, int.Parse(secondInput));
                    }
                    
                } else if (choice == 3)
                {
                    Console.WriteLine("\n ====================== Quitting Program ====================== \n\n");
                    displayStats(allNumbersRolled, allNumbersRolled.Count);
                    break;
                }

            }


            Console.ReadKey();
        }
    }
}
