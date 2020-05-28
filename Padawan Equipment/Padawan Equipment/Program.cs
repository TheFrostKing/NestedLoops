using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            float amountOfMoney = float.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            float priceOfLightsaber = float.Parse(Console.ReadLine());
            float priceOfRobes = float.Parse(Console.ReadLine());
            float priceOfBelts = float.Parse(Console.ReadLine());
            for (int i = 1; i <= students; i++)
            {
                if (i%6==0)
                {
                    float studentsPrice = priceOfBelts *students * 10+ priceOfRobes * students + priceOfBelts * (students - priceOfBelts);
                    if (amountOfMoney<=studentsPrice)
                    {
                        Console.WriteLine(studentsPrice);
                    }
                    else
                    {
                         studentsPrice = priceOfBelts * students * 10  +priceOfRobes * students + priceOfBelts * students;
                        Console.WriteLine(studentsPrice);
                    }
                }
            }
          
            
               
            

        }
    }
}
