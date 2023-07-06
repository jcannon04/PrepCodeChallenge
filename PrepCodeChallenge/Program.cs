// See https://aka.ms/new-console-template for more information
using System;
class PrepCodeChallenge
{
    static int ArrayMaxResult(int[] array, int n)
    {
        int count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == n)
            {
                count++;
            }
        }

        return count * n;
    }

    static bool IsLeapYear(int year)
    {

        if (year % 4 == 0)
        {
            if (year % 100 == 0 && year % 400 != 0)
            {
                return false;
            }
            return true;
        }
        return false;
    }

    static bool IsPerfectSequence(int[] array)
    {
        int sum = 0;
        int product = 1;

        foreach (int val in array)
        {
            if (val < 0)
            {
                return false;
            }

            sum += val;
            product *= val;
        }

        return sum == product;
    }

    static int[] SumOfRows(int[,] multArray)
    {
        int[] rowSumArr = new int[multArray.GetLength(0)];

        for (int i = 0; i < multArray.GetLength(0); i++)
        {
            int rowSum = 0;
            for (int j = 0; j < multArray.GetLength(1); j++)
            {
                rowSum += multArray[i, j];
            }
            rowSumArr[i] = rowSum;
        }
        return rowSumArr;

    }
    static void Main()
    {
        //Problem 1

        //int[] maxResultArr = new int[5];

        //Console.WriteLine("Hello Please enter 5 numbers (1-10) followed by enter");

        //for(int i = 0; i < maxResultArr.Length; i++)
        //{

        //    maxResultArr[i] = Convert.ToInt32(Console.ReadLine());
        //}

        //Console.WriteLine($"now select one of your numbers [{maxResultArr[0]},{maxResultArr[1]},{maxResultArr[2]},{maxResultArr[3]},{maxResultArr[4]}]");

        //int choice = Convert.ToInt32(Console.ReadLine());
        //int result = ArrayMaxResult(maxResultArr, choice);

        //Console.WriteLine($"Your score is {result}");

        // Problem 2

        //Console.WriteLine("enter a 4 digit year i.e. 1991");
        //int year = Convert.ToInt32(Console.ReadLine());
        //bool isLeapYear = IsLeapYear(year);
        //string yorN = isLeapYear ? "is" : "is not";
        //Console.WriteLine($"{year} {yorN} a leap year");

        int[,] myArray = new int[3, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } };
        int[] sumOfRows = SumOfRows(myArray);
        foreach (int sum in sumOfRows)
        {
            Console.WriteLine(sum);
        }
        Console.ReadLine();
    }

}
