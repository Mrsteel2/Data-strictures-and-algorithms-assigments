using System;

namespace StackAssignment;

public class Stack<T>
{
    private readonly T[] _items;
    private int _top;

    public Stack(int capacity)
    {
        if (capacity <= 0)
            throw new ArgumentOutOfRangeException(nameof(capacity), "Capacity must be greater than zero.");

        _items = new T[capacity];
        _top = -1;
    }

    public int Capacity => _items.Length;

    public int Count => _top + 1;

    public bool IsEmpty => _top == -1;

    public bool IsFull => _top == _items.Length - 1;

    public void Push(T item)
    {
        if (IsFull)
            throw new InvalidOperationException("Stack Overflow: the stack is full.");

        _items[++_top] = item;
    }

    public T Pop()
    {
        if (IsEmpty)
            throw new InvalidOperationException("Stack Underflow: the stack is empty.");

        T item = _items[_top];
        _items[_top--] = default!;
        return item;
    }

    public T Peek()
    {
        if (IsEmpty)
            throw new InvalidOperationException("Stack Underflow: the stack is empty.");

        return _items[_top];
    }

    public override string ToString()
    {
        if (IsEmpty)
            return "[ empty ]";

        var elements = new string[Count];
        for (int i = 0; i < Count; i++)
            elements[i] = _items[_top - i]!.ToString()!;

        return "TOP -> " + string.Join(" | ", elements) + " <- BOTTOM";
    }
}
