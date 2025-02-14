using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaLinqProject
{
    internal class RetrieveDistinctInts
    {
        public void FindDistinctListOfInts()
        {
            List<int> list = new List<int> { 12, 34, 3, 5, 6, 67, 4, 34, 3, 5, 6 };

            var distinctNum = list.Distinct();

            Console.WriteLine("Even numbers from list : ");

            foreach (var i in distinctNum)
            {
                Console.WriteLine(i);
            }
        }
    }
}
