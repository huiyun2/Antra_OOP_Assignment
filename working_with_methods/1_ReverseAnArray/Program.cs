using System;

public class ArrayOperations
{
    public static void Main(string[] args)
    {
        int[] numbers = GenerateNumbers(10);
        Reverse(numbers);
        PrintNumbers(numbers);
    }

    public static int[] GenerateNumbers(int length)
    {
        int[] numbers = new int[length];
        for (int i = 0; i < length; i++)
        {
            numbers[i] = i + 1;
        }
        return numbers;
    }
    public static void Reverse(int[] array)
    {
        int length = array.Length;
        for (int i = 0; i < length / 2; i++)
        {
            int temp = array[i];
            array[i] = array[length - i - 1];
            array[length - i - 1] = temp;
        }
    }

    public static void PrintNumbers(int[] array)
    {
        foreach (int number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}



