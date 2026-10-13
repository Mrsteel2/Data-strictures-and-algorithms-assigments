# Data Structures and Algorithms Assignments

A collection of data structures and algorithms assignments written in C#.

## Assignments

| # | Assignment | Project | Description |
|---|------------|---------|-------------|
| 1 | Stack | `src/StackAssignment` | Build a stack and demonstrate its core operations |

## Assignment 1 - Stack

Demonstrates a fixed-capacity LIFO stack built on an array:

1. Push the six data elements (1-6) onto the stack.
2. Remove the top element with `Pop()`.
3. Replace the removed element with a new value.
4. Insert another element at the top of the stack.
5. Fill the stack to capacity and verify the overflow guard.
6. Inspect the top element with `Peek()` (no removal).

### Operations supported

| Operation | Description |
|-----------|-------------|
| `Push(item)` | Adds an item to the top of the stack |
| `Pop()` | Removes and returns the top item |
| `Peek()` | Returns the top item without removing it |
| `IsFull` / `IsEmpty` | State checks |
| `Count` / `Capacity` | Current size and maximum size |

### Running

```bash
dotnet run --project src/StackAssignment/StackAssignment.csproj
```

### Project structure

```
Data-strictures-and-algorithms-assigments/
├── DataStructuresAndAlgorithms.sln
└── src/
    └── StackAssignment/
        ├── Stack.cs        # Generic fixed-capacity Stack<T>
        ├── Program.cs      # Demo of the required operations
        └── StackAssignment.csproj
```
