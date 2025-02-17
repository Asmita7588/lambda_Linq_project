using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaLinqProject
{
    internal class FindDuplicateInSentence
    {

        public void RemoveDuplicateWordInSentance()
        {
            string sentence = "This is me ,this is! her ,and, this and that is";

            List<string> words = sentence.ToLower().Split(new char[] { ',', '.', '!', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> duplicateWords = words.GroupBy(word => word).Where(group => group.Count() > 1).Select(group => group.Key).ToList();



            Console.WriteLine("Duplicate Words:");

            foreach (string word in duplicateWords)
            {
                Console.WriteLine(word);
            }
        }

        public void MostFrequentWord()
        {
            string sentence = "This is me ,this is! her ,and, this and that is";

            List<string> words = sentence.ToLower().Split(new char[] { ',', '.', '!', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            var mostFrequentWord = words
            .GroupBy(word => word)
            .OrderByDescending(group => group.Count())
            .FirstOrDefault();
            Console.WriteLine("Most Frequent Words:");

            foreach (string word in mostFrequentWord)
            {

                Console.WriteLine(word);
            }

        }
    }

}

