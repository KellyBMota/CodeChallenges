using System;
using System.Collections;
using System.Collections.Generic;

namespace BestSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = BestSum(7, new int[] { 5, 3, 4, 7 });
            if (list != null)
            {
                foreach (var num in list)
                    Console.Write(num + " ");
            }
            else
            {
                Console.Write("null");
            }
            Console.WriteLine("");

            list = BestSum(8, new int[] { 2, 3, 5 });
            if (list != null)
            {
                foreach (var num in list)
                    Console.Write(num + " ");
            }
            else
            {
                Console.Write("null");
            }

            Console.WriteLine("");

            list = BestSum(8, new int[] { 1, 4, 5 });
            if (list != null)
            {
                foreach (var num in list)
                    Console.Write(num + " ");
            }
            else
            {
                Console.Write("null");
            }

            Console.WriteLine("");

            list = BestSum(100, new int[] { 1, 2, 5, 25 });
            if (list != null)
            {
                foreach (var num in list)
                    Console.Write(num + " ");
            }
            else
            {
                Console.Write("null");
            }
        }

        static List<int> BestSum(int targetSum, int[] numbers, Hashtable hash = null)
        {
            if (hash == null) hash = new Hashtable();            
            if (hash.Contains(targetSum)) return hash[targetSum] as List<int>;
            if (targetSum == 0) return new List<int>();
            if (targetSum < 0) return null;

            List<int> shortestCombination = null;
            foreach (var num in numbers)
            {
                var remainder = targetSum - num;
                var remainderCombination = BestSum(remainder, numbers, hash);
                if(remainderCombination != null)
                {
                    remainderCombination.Add(num);
                    if (shortestCombination == null || remainderCombination.Count < shortestCombination.Count)
                    {
                        shortestCombination = remainderCombination;
                    }
                }
            }

            hash.Add(targetSum, shortestCombination);
            return shortestCombination;
        }
    }
}
