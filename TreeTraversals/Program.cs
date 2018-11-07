using System;
using System.Collections.Generic;

namespace TreeTraversals
{
  public class TreeNode
  {
    public int Value { get; set; }
    public TreeNode Left { get; set; }
    public TreeNode Right { get; set; }
  }

  public class Program
  {
    public static void Main()
    {
      TreeNode tree = new TreeNode
      {
        Value = 7,
        Left = new TreeNode
        {
          Value = 2,
          Left = new TreeNode { Value = 1 },
          Right = new TreeNode
          {
            Value = 4,
            Left = new TreeNode { Value = 3 },
            Right = new TreeNode { Value = 5 }
          }
        },
        Right = new TreeNode { Value = 8 }
      };

      Console.Write("Breadh first: ");
      PrintBreadth(tree);

      Console.Write("Depth first: ");
      PrintDepthInOrder(tree);
      Console.WriteLine();

      Console.WriteLine("Press any key to finish...");
      Console.ReadKey();
    }

    public static void PrintDepthInOrder(TreeNode node)
    {
      Console.Write(node.Value + " - ");

      if (node.Left != null) PrintDepthInOrder(node.Left);
      if (node.Right != null) PrintDepthInOrder(node.Right);
    } 

    public static void PrintBreadth(TreeNode root)
    {
      Queue<TreeNode> queue = new Queue<TreeNode>();
      queue.Enqueue(root);

      while (queue.Count > 0)
      {
        TreeNode currentNode = queue.Dequeue();
        Console.Write(currentNode.Value);
        if (currentNode.Left != null) queue.Enqueue(currentNode.Left);
        if (currentNode.Right != null) queue.Enqueue(currentNode.Right);

        if (queue.Count > 0) Console.Write(" - ");
      }

      Console.WriteLine();
    }
  }
}
