using System;

namespace TaskForMinInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int min,index=0;
            int[] arr = { 23,56,56,47,87,17,97,89};
            min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i]) 
                {
                    min = arr[i];
                    index = i;
                }
            }
            Console.WriteLine("Minimum value in arr: " + min + " In index: " + index);

        }
    }
}
