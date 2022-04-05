// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AvgMax
{
    class AvgMax
    {
        static void Main(string[] args)
        {
            int[] marks = new int[5];
            Console.WriteLine("Enter the average marks");
        
            for(int i=0; i<5; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
            int result = marks.Max();
            Console.WriteLine("Highest marks is {0}", result);
        }
    }
}
           


