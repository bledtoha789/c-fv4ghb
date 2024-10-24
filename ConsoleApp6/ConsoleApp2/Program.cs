//3
using System;
using System.Collections.Generic;

public class QueueUsingStacks<T>
{
    private Stack<T> stackIn;
    private Stack<T> stackOut;

    public QueueUsingStacks()
    {
        stackIn = new Stack<T>();
        stackOut = new Stack<T>();
    }

    public void Enqueue(T item)
    {
        stackIn.Push(item);
    }

    public T Dequeue()
    {
        if (stackOut.Count == 0)
        {
            while (stackIn.Count > 0)
            {
                stackOut.Push(stackIn.Pop());
            }
        }

        if (stackOut.Count == 0)
        {
            throw new InvalidOperationException("Очередь пуста.");
        }

        return stackOut.Pop();
    }
}


public class Program
{
    public static void Main()
    {
        var queue = new QueueUsingStacks<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        Console.WriteLine(queue.Dequeue());
        queue.Enqueue(3);
        Console.WriteLine(queue.Dequeue());
    }
}