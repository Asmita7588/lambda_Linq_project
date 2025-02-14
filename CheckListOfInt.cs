using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaLinqProject
{
    internal class CheckListOfInt
    {

        public void CheckListOfIntergers()
        {
            List<int> sortInt = new List<int> { 12, 2, 110, 3, 10, 400, 9, 1, 50, 76, 6, 8 };

            var result = sortInt.Where(x => x > 50).ToList();
            Console.WriteLine("Numbers greater than 50 :");

            foreach (var item in result)
            {

                Console.WriteLine(item);
            }
        }
    }
}
