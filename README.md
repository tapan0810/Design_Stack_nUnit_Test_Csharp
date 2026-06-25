# Design Stack Using LinkedList (C#)

This project demonstrates the implementation of a Stack data structure using LinkedList in C# along with NUnit unit testing.

## Features

- Stack implementation using `LinkedList<int>`
- Push operation
- Pop operation
- Top operation
- Empty check
- NUnit unit tests

## Project Structure

```text
Design_Stack_Using_LinkedList
│
├── Design_Stack_Using_LinkedList
│   └── Program.cs
│
├── Design_Stack_Using_LinkedList.Tests
│   └── MyStackTests.cs
│
└── Design_Stack_Using_LinkedList.sln
```

## Stack Implementation

```csharp
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
```

## Example Usage

```csharp
MyStack stack = new MyStack();

stack.Push(1);
stack.Push(2);

Console.WriteLine(stack.top());   // 2
Console.WriteLine(stack.pop());   // 2
Console.WriteLine(stack.Empty()); // False
```

## NUnit Test Cases

The project contains unit tests for:

- Empty stack validation
- Push operation
- Pop operation
- Top operation
- Stack state after pop

Example:

```csharp
[Test]
public void Top_ReturnsLastPushedElement()
{
    stack.Push(10);
    stack.Push(20);

    Assert.That(stack.top(), Is.EqualTo(20));
}
```

## Technologies Used

- C#
- .NET
- NUnit
- Visual Studio

## How to Run

### Clone Repository

```bash
git clone https://github.com/tapan0810/Design_Stack_nUnit_Test_Csharp.git
```

### Open Solution

Open:

```text
Design_Stack_Using_LinkedList.sln
```

in Visual Studio.

### Build Solution

```text
Build → Build Solution
```

### Run Application

```text
Debug → Start Without Debugging
```

### Run Unit Tests

```text
Test → Test Explorer → Run All Tests
```

## Learning Objectives

This project demonstrates:

- Data Structures in C#
- Stack implementation using LinkedList
- Object-Oriented Programming
- NUnit Test Framework
- Unit Testing Best Practices
