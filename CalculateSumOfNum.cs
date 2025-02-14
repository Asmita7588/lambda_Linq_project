using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaLinqProject
{
    internal class CalculateSumOfNum
    {
        public void FindSumOfNum()
        {
            List<int> list = new List<int> { 12, 34, 3, 5, 6, 67, 4, 34, 3, 5, 6 };

           int sum = list.Where(num => num % 2 != 0).Sum();

            Console.WriteLine("Sum of Off numbers from list : " +sum);
            
        }

        //Find the maximum number in a list of integers.

        public void FindMaxNum()
        {
            List<int> list = new List<int> { 12, 34, 3, 5, 6, 67, 4, 34, 3, 5, 6 };

            int maxNum = list.Max();

            Console.WriteLine("Max number from list : " + maxNum);

        }

        //Create a list of squares of integers from an existing list.

        public void CreateSquareList()
        {
            List<int> list = new List<int> { 12, 34, 3, 5, 6, 67, 4, 34, 3, 5, 6 };

            var squareOfNum = list.Select((num => num * num));

            Console.WriteLine(" List of Square Of Num");

            foreach (var ele in squareOfNum) { 
                Console.WriteLine(ele);
            }

        }

    }
}
