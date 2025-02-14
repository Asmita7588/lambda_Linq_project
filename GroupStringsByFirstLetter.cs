using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaLinqProject
{
    internal class GroupStringsByFirstLetter
    {
        public void GroupWordsByFirstLetter()
        {
            List<string> words = new List<string> { "Apple", "Banana", "Cherry" ,"Anime", "Bold", "Creative", "Amount"};
            var groups = words.GroupBy(word => word[0]);

            foreach (var group in groups)
            {
                Console.WriteLine($"Words starts with {group.Key} : {string.Join(",", group)}");
            }
        }
    }
}
