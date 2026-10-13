using System;
using StackAssignment;

const int Capacity = 8;

var stack = new Stack<int>(Capacity);

void Show(string label)
{
    Console.WriteLine($"  {label,-24} {stack}");
    Console.WriteLine($"  {"Count",-24} {stack.Count}/{stack.Capacity}");
    Console.WriteLine();
}

Console.WriteLine("==================================================");
Console.WriteLine(" STACK ASSIGNMENT  (capacity = 8, LIFO)");
Console.WriteLine("==================================================");
Console.WriteLine();

Console.WriteLine("STEP 1: Push the 6 data elements (1 to 6) onto the stack");
Console.WriteLine("--------------------------------------------------");
for (int i = 1; i <= 6; i++)
{
    stack.Push(i);
    Console.WriteLine($"  Push({i})");
}
Console.WriteLine();
Show("Stack after pushes");

Console.WriteLine("STEP 2: Remove the top element (Pop)");
Console.WriteLine("--------------------------------------------------");
int removed = stack.Pop();
Console.WriteLine($"  Pop() removed -> {removed}");
Console.WriteLine();
Show("Stack after pop");

Console.WriteLine($"STEP 3: Replace the removed {removed} with 7");
Console.WriteLine("--------------------------------------------------");
stack.Push(7);
Console.WriteLine("  Push(7)");
Console.WriteLine();
Show("Stack after replacement");

Console.WriteLine("STEP 4: Insert a new element at the top of the stack");
Console.WriteLine("--------------------------------------------------");
stack.Push(8);
Console.WriteLine("  Push(8)");
Console.WriteLine();
Show("Stack after insertion");

Console.WriteLine("STEP 5: Fill to capacity, then test the full-stack guard");
Console.WriteLine("--------------------------------------------------");
stack.Push(9);
Console.WriteLine("  Push(9)");
Show("Stack now full");
try
{
    stack.Push(10);
}
catch (InvalidOperationException ex)
{
    Console.WriteLine($"  Push(10) blocked -> {ex.Message}");
}
Console.WriteLine();
Show("Stack unchanged");

Console.WriteLine("STEP 6: Peek the top element (no removal)");
Console.WriteLine("--------------------------------------------------");
Console.WriteLine($"  Peek() -> {stack.Peek()}");
Console.WriteLine();
