using System;
using System.Collections;

namespace CanSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CanSum(7, new int[] { 2, 3 }));
            Console.WriteLine(CanSum(7, new int[] { 5, 3, 4, 7 }));
            Console.WriteLine(CanSum(7, new int[] { 2, 4 }));
            Console.WriteLine(CanSum(8, new int[] { 2, 3, 5 }));
            Console.WriteLine(CanSum(300, new int[] { 7, 14 }));
        }

        static bool CanSum(int targetSum, int[] numbers, Hashtable hash = null)
        {
            if (hash == null)
            {
                hash = new Hashtable();
            }
            if (targetSum == 0) return true;
            if (targetSum < 0) return false;
            if (hash.Contains(targetSum)) return (bool) hash[targetSum];

            foreach(var num in numbers)
            {
                if (CanSum(targetSum - num, numbers, hash))
                {
                    hash.Add(targetSum, true);
                    return true;
                }
            }

            hash.Add(targetSum, false);
            return false;
        }
    }
}
