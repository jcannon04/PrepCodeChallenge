// See https://aka.ms/new-console-template for more information
using System;
class PrepCodeChallenge
{
    static int ArrayMaxResult(int[] array, int n)
    {
        int count = 0;

        for(int i = 0; i < array.Length; i++)
        {
            if (array[i] == n)
            {
                count++;
            }
        }

        return count * n;
    }

    static void Main()
    {
        //challenge 1

        int[] maxResultArr = new int[5];

        Console.WriteLine("Hello Please enter 5 numbers (1-10) followed by enter");

        for(int i = 0; i < maxResultArr.Length; i++)
        {

            maxResultArr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine($"now select one of your numbers [{maxResultArr[0]},{maxResultArr[1]},{maxResultArr[2]},{maxResultArr[3]},{maxResultArr[4]}]");

        int choice = Convert.ToInt32(Console.ReadLine());
        int result = ArrayMaxResult(maxResultArr, choice);

        Console.WriteLine($"Your score is {result}");
        Console.ReadLine();
    }

}
