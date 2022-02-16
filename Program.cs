using System;

namespace binarySearchFunction
{
    class Program
    {
        static int linearSearch(int[] anArray, int item){
            for (int i=0; i < anArray.Length; i++){
                if (anArray[i] == item){
                    return i;
                }
            }
            return -1;
        }

        static int linearSearchStr(string[] anArray, string item){
           for (int i=0; i < anArray.Length; i++){
                if (String.Equals(anArray[i], item)){
                    return i;
                }
            }
           return -1;
        }

        static void Main(string[] args)
        {
            int[] nums = {10, 30, 40, 45, 70, 80, 85, 90, 100};
            string[] words = {"at", "ball", "cat", "dog", "eye", "fish", "good"};
            int[] unsorted = {30, 20, 70, 40, 50, 100, 90};
            linearSearch(nums, 100);
            linearSearch(nums, 75);
            linearSearchStr(words, "fish");
            linearSearchStr(words, "at");
            linearSearch(unsorted, 70);
        }
    }
}
