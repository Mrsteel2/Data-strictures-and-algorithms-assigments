using System;
using TreeTraversal;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Binary Tree Traversal (Node + Pointers) ===");
        Console.WriteLine();

        BinaryTree tree = new BinaryTree();

        // Creating nodes and linking with pointers
        tree.Root = new Node(1);
        tree.Root.Left = new Node(2);
        tree.Root.Right = new Node(3);
        tree.Root.Left.Left = new Node(4);
        tree.Root.Left.Right = new Node(5);
        tree.Root.Right.Left = new Node(6);
        tree.Root.Right.Right = new Node(7);

        Console.WriteLine("Tree Structure:");
        Console.WriteLine("        1");
        Console.WriteLine("       / \\");
        Console.WriteLine("      2   3");
        Console.WriteLine("     / \\ / \\");
        Console.WriteLine("    4   5 6   7");
        Console.WriteLine();

        // Calling all traversal functions
        Console.Write("Preorder Traversal  (Root -> Left -> Right): ");
        tree.PreOrder();
        Console.WriteLine();
        Console.WriteLine();

        Console.Write("Inorder Traversal   (Left  -> Root -> Right): ");
        tree.InOrder();
        Console.WriteLine();
        Console.WriteLine();

        Console.Write("Postorder Traversal (Left  -> Right -> Root): ");
        tree.PostOrder();
        Console.WriteLine();
        Console.WriteLine();

        Console.Write("Level Order Traversal (Level by Level):       ");
        tree.LevelOrder();
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("=== End of Program ===");
    }
}
