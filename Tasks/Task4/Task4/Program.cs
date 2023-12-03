using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1
            //Console.WriteLine("Input 10 numbers:");

            //CalculateSumAndAverage(10);

            //Task2
            //Console.Write("Input number of terms: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine($"Number is: {i} and cube of the {i} is: {Math.Pow(i, 3)}");
            //}

            //Task3

            int[] years = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };

            int[] result = GetYears(years);

            Console.WriteLine("Years greater than 1950:");
            foreach (var year in result)
            {
                Console.WriteLine(year);
            }


        }

        static void GetYears(int[] years)
        {
            foreach (var item in years)
            {
                if (item>1950)
                {
                    Console.WriteLine(item);
                }
            }
        }




        static void CalculateSumAndAverage(int count)
        {
            int sum = 0;

            for (int i = 1; i <= count; i++)
            {
                Console.Write($"Number-{i}: ");
                int number = Convert.ToInt32(Console.ReadLine());
                sum += number;
            }
            double average = (double)sum / count;
            Console.WriteLine($"sum {sum} , average {average}");

        }
    }
}
