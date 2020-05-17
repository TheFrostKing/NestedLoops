using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSumsAnd
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            for (int i = start; i <= end; i++)
            {
              //catch every digit as a string
               string currentNumber= i.ToString();
                int oddCounter = 0;
                int evenCounter = 0;
                for (int j = 0; j < currentNumber.Length; j++)
                {
                    if (j % 2 == 0)
                    {
                        evenCounter += int.Parse(currentNumber[j].ToString());
                    }
                    else
                    {
                        oddCounter += int.Parse(currentNumber[j].ToString());
                    }

                }

                if (evenCounter==oddCounter)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
