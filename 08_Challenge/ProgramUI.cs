using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Challenge
{
    public class ProgramUI
    {
        private Rates _rates;

        public ProgramUI()
        {
            _rates = new Rates(); 
        }

        public void Run()
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("What would you like to do?\n" +
                    "1. Get \"SafeDriver\" Quote\n" +
                    "2. View \"SafeDriver\" Rate Information\n" +
                    "3. Exit Application");

                string inputAsString = Console.ReadLine();
                int input = int.Parse(inputAsString);

                switch (input)
                {
                    case 1:
                        GetQuote();
                        break;
                    case 2:
                        ViewRates();
                        break;
                    case 3:
                        running = false;
                        break;
                }
            }
        }

        private void GetQuote()
        {
            Console.Clear(); 
            Console.WriteLine("What is the client's name?");
            string name = Console.ReadLine(); 

            Console.WriteLine("Number of times speed limit was exceeded?");
            int speedViolations = int.Parse(Console.ReadLine());

            decimal speedCost = 0m;
            if (speedViolations > 10)
            {
                speedCost = 50m;
            }

            Console.WriteLine("Number of times driver swerved outside of their lane?");
            int swerveViolations = int.Parse(Console.ReadLine());

            decimal swerveCost = 0m;
            if (swerveViolations > 5)
            {
                swerveCost = 25m;
            }

            Console.WriteLine("Number of times driver did not come to a complete stop at a stop sign?");
            int stopViolations = int.Parse(Console.ReadLine());

            decimal stopCost = 0m;
            if (stopViolations > 2)
            {
                stopCost = 100m;
            }

            Console.WriteLine("Number of times driver followed too closely?");
            int spaceViolations = int.Parse(Console.ReadLine());

            decimal spaceCost = 0m;
            if (spaceViolations > 3)
            {
                spaceCost = 30m;
            }

            decimal basePremium = 75m;

            decimal totalCost = basePremium + speedCost + swerveCost + stopCost + spaceCost;

            Console.Clear(); 
            Console.WriteLine
                ($"Base Premium:             {basePremium.ToString("C2")}\n" +
                $"Speed Violations:         {speedCost.ToString("C2")}\n" +
                $"Swerve Violations:        {swerveCost.ToString("C2")}\n" +
                $"Stop Sign Violations:     {stopCost.ToString("C2")}\n" +
                $"Tailgating Violations:    {spaceCost.ToString("C2")}\n" +
                $"\n" +
                $"The monthly premium for {name} is {totalCost.ToString("C2")}. Press return...");

            Console.ReadLine();
        }

        private void ViewRates(decimal basePremium = 75m, decimal speedCost = 50m, decimal swerveCost = 25m, decimal stopCost = 100m, decimal spaceCost = 30m)
        {

            Console.Clear(); 
            Console.WriteLine($"Here are the 2019 \"SafeDriver\" Rates:\n" +
                $"Base Premium:                       {basePremium.ToString("C2")}\n" +
                $"More than 10 speed violations:     +{speedCost.ToString("C2")}\n" +
                $"More than 5 lane violations:       +{swerveCost.ToString("C2")}\n" +
                $"More than 2 stop sign violations:  +{stopCost.ToString("C2")}\n" +
                $"More than 3 tailgating violations: +{spaceCost.ToString("C2")}\n" +
                    "Press any key to continue...");
            Console.ReadLine(); 

        }

        
    }
}
