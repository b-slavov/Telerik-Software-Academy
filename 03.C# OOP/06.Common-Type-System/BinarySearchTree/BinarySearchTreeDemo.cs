namespace BinarySearchTree
{
    using System;

    public class BSTDemo
    {
        public static void Main()
        {
            var tree = new BST<int>(7);

            // tree.Insert(7);
            tree.Insert(2);
            tree.Insert(3);
            tree.Insert(12);
            tree.Insert(29);
            tree.Insert(1);

            Console.WriteLine(tree);
            Console.WriteLine("The root is {0}", tree.Root.Value);

            bool isFound = BST<int>.Search(16, tree.Root);
            Console.WriteLine(isFound);
            Console.WriteLine();

            tree.Remove(16);
            Console.WriteLine(tree);

            var anotherTree = tree.Clone();
            Console.WriteLine(anotherTree);

            Console.WriteLine(anotherTree.Equals(tree));
        }
    }
}