using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaLinqProject
{
    internal class CheckPositiveList
    {
        public void CheckPositiveInts()
        {
            List<int> list = new List<int> { 12, 34, 4, 5, -6, 45, -67, 34, 45};
             
            bool result = list.All(x => x > 0);

            Console.WriteLine( result ? "All number in list are Positive" : "All number in list are not Positive");
        }

        //Find the first number in a list that is divisible by 3 and 5.

        public void FindFirstNumDivisible() {
            List<int> list = new List<int> { 12, 34, 4, 5, -6, 45, -67, 34, 45 };

            int result = list.FirstOrDefault(x => x % 3 == 0 && x % 5 == 0);

            Console.WriteLine("first number in a list that is divisible by 3 and 5 = " + result);
        }

       public void CombineTwoListWithoutDuplicate()
        {
            List<int> list1 = new List<int> { 11, 34, 45, 5, -7, 45, 74, 34, 25 };
            List<int> list2 = new List<int> { 11, 34, 4, 5, -6, 45, -67, 34, 45 };

            var combinedList = list1.Union(list2).ToList();
            Console.WriteLine("Combined Two List :");

            foreach (var item in combinedList)
            {
                Console.Write(item + "  ");
            }
        }
    }
}
