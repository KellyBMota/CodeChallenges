using System;
using System.Collections;

namespace CanConstruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CanConstruct("abcdef", new string[] { "ab", "abc", "cd", "def", "abcd" }));
            Console.WriteLine(CanConstruct("skateboard", new string[] { "bo", "rd", "ate", "t", "ska", "sk", "boar" }));
            Console.WriteLine(CanConstruct("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef", new string[] { 
                "e", 
                "ee", 
                "eee",  
                "eeee", 
                "eeeee",
                "eeeeee",
            }));
        }

         static bool CanConstruct(string target, string[] wordBank, Hashtable hash = null)
        {
            if (hash == null) hash = new Hashtable();
            if (target == "") return true;
            if (hash.Contains(target)) return (bool) hash[target];

            for (var i = 0; i < wordBank.Length; i++)
            {
                if (target.StartsWith(wordBank[i]))
                {
                    var suffix = target.Remove(0, wordBank[i].Length);
                    if (CanConstruct(suffix, wordBank, hash)) { 
                        hash.Add(suffix, true);
                        return true;
                    }
                }
            }
            hash.Add(target, false);
            return false;
        }
    }
}
