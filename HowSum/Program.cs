using System;
using System.Collections;
using System.Collections.Generic;

namespace HowSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = HowSum(7, new int[] { 2, 3 });
            if (list != null)
            {
                foreach (var num in list)
                Console.Write(num);
            }
            else
            {
                Console.Write("null");
            }
            Console.WriteLine("");

            list = HowSum(7, new int[] { 5, 3, 4, 7 });
            if (list != null)
            {
                foreach (var num in list)
                    Console.Write(num);
            }
            else
            {
                Console.Write("null");
            }

            Console.WriteLine("");

            list = HowSum(7, new int[] { 2, 4 });
            if (list != null)
            {
                foreach (var num in list)
                    Console.Write(num);
            }
            else
            {
                Console.Write("null");
            }

            Console.WriteLine("");

            list = HowSum(8, new int[] { 2, 3, 5 });
            if (list != null)
            {
                foreach (var num in list)
                    Console.Write(num);
            }
            else
            {
                Console.Write("null");
            }

            Console.WriteLine("");

            list = HowSum(300, new int[] { 7, 14 });
            if (list != null)
            {
                foreach (var num in list)
                    Console.Write(num);
            }
            else
            {
                Console.Write("null");
            }
        }

        static List<int> HowSum(int targetSum, int[] numbers, Hashtable hash = null)
        {
            if (hash == null) hash = new Hashtable();
            if (targetSum == 0) return new List<int>();
            if (targetSum < 0) return null;
            if (hash.Contains(targetSum)) return hash[targetSum] as List<int>;

            foreach(var num in numbers)
            {
                var remainder = targetSum - num;
                var list = HowSum(remainder, numbers, hash);
                if(list != null)
                {
                    list.Add(num);
                    hash.Add(targetSum, list);
                    return list;
                }
            }

            hash.Add(targetSum, null);
            return null;
        }
    }
}
