using System;
using System.Collections.Generic;
using System.Linq;

namespace AllConstruct
{
    class Program
    {
        static void Main(string[] args)
        {
            var allConstruct = AllConstruct("abcdef", new string[] { "ab", "abc", "cd", "def", "abcd" });
            if (allConstruct == null) Console.Write("null");
            else
            {
                foreach (var word in allConstruct)
                {
                    Console.Write(word + " ");
                }
            }

            Console.WriteLine(" ");

            allConstruct = AllConstruct("skateboard", new string[] { "bo", "rd", "ate", "t", "ska", "sk", "boar" });
            if (allConstruct == null) Console.Write("null");
            else
            {
                foreach (var word in allConstruct)
                {
                    Console.Write(word + " ");
                }
            }

            Console.WriteLine(" ");

            allConstruct = AllConstruct("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef", new string[] {
                "e",
                "ee",
                "eee",
                "eeee",
                "eeeee",
                "eeeeee",
            });

            if (allConstruct == null) Console.Write("null");
            else
            {
                foreach (var word in allConstruct)
                {
                    Console.Write(word + " ");
                }
            }
        }

        private static List<List<string>> AllConstruct(string target, string[] wordBank)
        {
            if(target == "") return new List<List<string>>();

            List<List<string>> allConstruct = new List<List<string>>();
            foreach(var word in wordBank)
            {
                if (target.StartsWith(word))
                {
                    var suffix = target.Remove(0, word.Length);
                    var suffixWays = AllConstruct(suffix, wordBank);
                    foreach(var ways in suffixWays)
                    {
                        ways.Add(word);
                    }
                    var targetWays = suffixWays;
                    allConstruct.Concat(targetWays);
                }
            }
            return allConstruct;
        }
    }
}
