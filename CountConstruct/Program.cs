using System;
using System.Collections;

namespace CountConstruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountConstruct("abcdef", new string[] { "ab", "abc", "cd", "def", "abcd" }));
            Console.WriteLine(CountConstruct("skateboard", new string[] { "bo", "rd", "ate", "t", "ska", "sk", "boar" }));
            Console.WriteLine(CountConstruct("purple", new string[] { "purp", "p", "ur", "le", "purpl"}));
            Console.WriteLine(CountConstruct("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef", new string[] {
                "e",
                "ee",
                "eee",
                "eeee",
                "eeeee",
                "eeeeee",
            }));
        }

        /* 
         * target = m
         * wordBank length = n
         * 
         * time = O(n^m * m)
         * space = O(m
         */
        private static int CountConstruct(string target, string[] wordBank, Hashtable hash = null)
        {
            if (hash == null) hash = new Hashtable();
            if (string.IsNullOrEmpty(target)) return 1;
            if (hash.Contains(target)) return (int)hash[target];

            var total = 0;
            foreach(var word in wordBank)
            {
                if (target.StartsWith(word))
                {
                    var count = CountConstruct(target.Remove(0, word.Length), wordBank, hash);
                    total += count;
                }
            }

            hash.Add(target, total);
            return total;
        }
    }
}
