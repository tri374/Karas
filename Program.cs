using System;
public class Program
{
    public static void Main()
    {
        Random rar = new Random();
        int x = rar.Next();
        int c = rar.Next(1, 50);
        int[] arr = x.ToString().Select(o => Convert.ToInt32(o) - c).ToArray();
        Console.WriteLine("оригинальные массивы:");
        PrintArray(arr);
        Console.WriteLine("\nСортированные массивы:");
        BubbleSortAlgorithm(arr);
        PrintArray(arr);
    }

    static void BubbleSortAlgorithm(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    static void PrintArray(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; i++)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
    }
}

