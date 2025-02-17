using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaLinqProject
{
    internal class TopThreeHighestNum
    {
        public void TopThreeHighest()
        {
            List<int> list = new List<int> {2, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };

            var topThree = list.OrderByDescending(x => x).Take(3);

            Console.WriteLine("Top three elements :");
            foreach (var item in topThree) { 
                Console.WriteLine(item);
            }
        }

        public void FindAverage()
        {
            List<double> numbers = new List<double> { 10.5, 20.3, 30.7, 40.2, 50.8 };

            double average = numbers.Average();

            Console.WriteLine($"The average is: {average:F2}");
        }
        
    }
}
