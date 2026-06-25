using System;
using System.Collections.Generic;


public class MyStack
{
    private LinkedList<int> stack;

    public MyStack()
    {
        stack = new LinkedList<int>();
    }

    public void Push(int x)
    {
        stack.AddLast(x);
    }

    public int pop()
    {
        int top = stack.Last.Value;
        stack.RemoveLast();
        return top;

    }

    public int top()
    {
        return stack.Last.Value;
    }

    public bool Empty()
    {
        return stack.Count == 0;
    }

}
class Design_Stack_Using_LinkedList
{
    static void Main(string[] args)
    {
        MyStack stack = new MyStack();
        stack.Push(1);
        stack.Push(2);
        Console.WriteLine(stack.top());   // returns 2
        Console.WriteLine(stack.pop());   // returns 2
        Console.WriteLine(stack.Empty()); // returns false
    }
}