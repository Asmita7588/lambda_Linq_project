using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaLinqProject
{
    internal class SortListOfInt
    {
        public void SortListOfIntergersInDesc()
        {
            List<int> sortInt = new List<int> { 12, 2, 11, 3, 10, 4, 9, 1, 5, 7, 6, 8 };

            var result = sortInt.OrderByDescending(x => x).ToList();

            foreach (var item in result) { 

                Console.WriteLine(item);
            }
        }
    }
}
