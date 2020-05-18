using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfComittee = int.Parse(Console.ReadLine());
            string presentation = "";
            decimal presentationSingleScore = 0;
            decimal counter = 0;
            decimal scoreCounter = 0;
            decimal allPresentationScore = 0;
            while (true)
            {
                presentation = Console.ReadLine();
                if (presentation=="Finish")
                {
                    decimal scoreSum = allPresentationScore / scoreCounter;
                    Console.WriteLine($"Student's final assessment is {scoreSum:F2}.");
                    break;
                }
                for (int i = 1; i <= numberOfComittee; i++)
                {
                    decimal grade = decimal.Parse(Console.ReadLine());
                    counter += grade;
                    allPresentationScore += grade;
                    scoreCounter++;
                    
                }

                 presentationSingleScore = counter / numberOfComittee;
                Console.WriteLine($"{presentation} - {presentationSingleScore:F2}.");

            }
          

        }
    }
}
