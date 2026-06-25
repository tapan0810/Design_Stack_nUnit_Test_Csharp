using System;
using System.Collections.Generic;


public class MyStack
{
    private LinkedList<int> st;

    public MyStack()
    {
        st = new LinkedList<int>();
    }

    public void Push(int x)
    {
        st.AddLast(x);
    }

    public int pop()
    {
        int top = st.Last.Value;
        st.RemoveLast();
        return top;

    }

    public int top()
    {
        return st.Last.Value;
    }

    public bool Empty()
    {
        return st.Count == 0;
    }

}
class Program
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