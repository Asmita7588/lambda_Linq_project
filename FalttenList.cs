using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaLinqProject
{
    internal class FalttenList
    {

        public void FlattenLists()
        {
            List<List<int>> listOfLists = new List<List<int>>
            {
            new List<int> { 1, 2, 3 },
            new List<int> { 4, 5, 6 },
            new List<int> { 7, 8, 9 }
            };

            List<int> flattenedList = listOfLists.SelectMany(list => list).ToList();

            Console.WriteLine("Flattened List:");
            Console.WriteLine(string.Join(", ", flattenedList));
        }
    }
}
