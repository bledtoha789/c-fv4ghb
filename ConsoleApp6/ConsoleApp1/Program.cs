//1
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] arr = { 3, 6, 4, 9, 10, 8, 11,5 };
        int[] result = NearestGreaterRight(arr);

        Console.WriteLine(string.Join(", ", result));
    }

    static int[] NearestGreaterRight(int[] arr)
    {
        int n = arr.Length;
        int[] result = new int[n];
        Stack<int> stack = new Stack<int>();

        for (int i = n - 1; i >= 0; i--)
        {

            while (stack.Count > 0 && stack.Peek() <= arr[i])
            {
                stack.Pop();
            }

            result[i] = stack.Count > 0 ? stack.Peek() : -1;

            stack.Push(arr[i]);
        }

        return result;
    }
}