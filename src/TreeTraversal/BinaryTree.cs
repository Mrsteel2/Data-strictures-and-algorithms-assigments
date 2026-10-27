using System;
using System.Collections.Generic;

namespace TreeTraversal;

public class BinaryTree
{
    public Node Root;

    public BinaryTree()
    {
        Root = null;
    }

    // Preorder traversal: Root -> Left -> Right
    public void PreOrder(Node node)
    {
        if (node == null)
            return;

        Console.Write(node.Data + " ");
        PreOrder(node.Left);
        PreOrder(node.Right);
    }

    // Inorder traversal: Left -> Root -> Right
    public void InOrder(Node node)
    {
        if (node == null)
            return;

        InOrder(node.Left);
        Console.Write(node.Data + " ");
        InOrder(node.Right);
    }

    // Postorder traversal: Left -> Right -> Root
    public void PostOrder(Node node)
    {
        if (node == null)
            return;

        PostOrder(node.Left);
        PostOrder(node.Right);
        Console.Write(node.Data + " ");
    }

    // Level order traversal using Queue (pointer/links via nodes)
    public void LevelOrder(Node node)
    {
        if (node == null)
            return;

        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(node);

        while (queue.Count > 0)
        {
            Node current = queue.Dequeue();
            Console.Write(current.Data + " ");

            if (current.Left != null)
                queue.Enqueue(current.Left);

            if (current.Right != null)
                queue.Enqueue(current.Right);
        }
    }

    // Helper to call traversals from root
    public void PreOrder() => PreOrder(Root);
    public void InOrder() => InOrder(Root);
    public void PostOrder() => PostOrder(Root);
    public void LevelOrder() => LevelOrder(Root);
}
