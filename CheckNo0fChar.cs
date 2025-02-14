using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaLinqProject
{
    internal class CheckNo0fChar
    {
        public void CheckNo0fCharInList() {

            List<string> stringList = new List<string> { "Hello", "independent", "Am", "Java", "Asmita", "Ask" };

            int count = stringList.Count(name => name.Length > 5);

            Console.WriteLine("String start with A: ");

          

                Console.WriteLine(" Number of Strings more than 5 char : "+count);
            
        }
    }
}
