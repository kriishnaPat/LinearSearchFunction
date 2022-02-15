using System;

namespace binarySearchFunction
{
    class Program
    {
        static void linearSearch(int[] anArray, int array){
            for (int i=0; i < anArray.Length; i++)
                if (anArray[i] == array){
                    Console.WriteLine(i);
                }
                Console.WriteLine("-1");
        }
        static void Main(string[] args)
        {
            int[] nums = {10, 30, 40, 45, 70, 80, 85, 90, 100};
            string[] words = {"at", "ball", "cat", "dog", "eye", "fish", "good"};
            int[] unsorted = {30, 20, 70, 40, 50, 100, 90};
            linearSearch(nums, 100);
            linearSearch(nums, 75);
            //linearSearch(words, "fish");
            //linearSearch(words, "at");
            linearSearch(unsorted, 70);

        }
    }
}
