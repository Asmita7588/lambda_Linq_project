using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaLinqProject
{
    internal class FindEvenFromList
    {
        public void FindEven()
        {
            List<int> list = new List<int> { 12, 34, 3, 5, 6, 67, 4 };

            var evenNum = list.Where(x  => x % 2 == 0).ToList();

            Console.WriteLine("Even numbers from list : ");

            foreach (var i in evenNum) {
                Console.WriteLine(i);
            }
        }
    }
}
