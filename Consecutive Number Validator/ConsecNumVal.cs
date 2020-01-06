using System;

namespace ConsecutiveNumberValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers seperated by a hyphon '-': ");
            string inputString = Console.ReadLine();
            string[] stringArray = inputString.Split("-");
            int[] intArray = Array.ConvertAll(stringArray, s => int.Parse(s));

            for (int i = 0; i < intArray.Length; i++)
            {
                if ((intArray[i] - intArray[i + 1]) == 1 || (intArray[i] - intArray[i + 1]) == -1)
                {
                    if(intArray[i] == intArray[-i])
                        Console.WriteLine("Consecutive");
                } else
                {
                    if (intArray[i] == intArray[-i])
                        Console.WriteLine("Not Consecutive");
                }
            }
        }
    }
}
