using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaLinqProject
{
    internal class FindStringStartsWithA
    {
        public void FindString() {
            List<string> stringList = new List<string> { "Hello", "i", "Am", "Java", "Asmita", "Ask" };

            var stringStartsWithA = stringList.Where(name => name.StartsWith("A") );

            Console.WriteLine("String start with A: ");

            foreach (var str in stringStartsWithA) { 

                Console.WriteLine(str);
            }

        }

        //Filter a list of strings to only include those ending with ".com".
        public void FilterListOfStr()
        {
            List<string> stringList = new List<string> { "Hello.com", "i", "Am", "Java.com", "Asmita", "Ask.com" };

            var stringEndsWith = stringList.Where(name => name.EndsWith(".com"));

            Console.WriteLine("String ends with .com : ");

            foreach (var str in stringEndsWith)
            {

                Console.WriteLine(str);
            }

        }

        //Find the longest string in a list of strings.
        public void FindLongestStringInList()
        {
            List<string> stringList = new List<string> { "HelloIndia", "ironMan", "Am", "Java.com", "Asmita", "Ask.com" };

            string findLongestStr = stringList.OrderByDescending(name => name.Length).FirstOrDefault();

            Console.WriteLine("Longest String list  : ");

                Console.WriteLine(findLongestStr);
            

        }

    }
}
