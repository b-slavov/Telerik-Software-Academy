namespace BinarySearchTree
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class BST<T> : IEnumerable<T>, ICloneable
        where T : IComparable<T>
    {
        private TreeNode root;

        public BST(T rootValue)
        {
            this.root = new TreeNode(rootValue);
            this.Count = 1;
        }

        public TreeNode Root
        {
            get
            {
                return this.root;
            }
        }

        public int Count { get; private set; }

        // if element exist -> true, else -> false
        public static bool Search(T element, TreeNode root)
        {
            if (root == null)
            {
                return false;
            }

            if (element.CompareTo(root.Value) == 0)
            {
                return true;
            }

            if (element.CompareTo(root.Value) < 0)
            {
                return Search(element, root.LeftChild);
            }
            else
            {
                return Search(element, root.RightChild);
            }
        }

        public static bool operator ==(BST<T> firstTree, BST<T> secondTree)
        {
            return BST<T>.Equals(firstTree, secondTree);
        }

        public static bool operator !=(BST<T> firstTree, BST<T> secondTree)
        {
            return !BST<T>.Equals(firstTree, secondTree);
        }

        public void Insert(T element)
        {
            this.Insert(element, ref this.root);
        }

        public void Remove(T element)
        {
            this.Remove(element, ref this.root);
            this.Count--;
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            this.InOrderTreeWalk(this.root, x => result.AppendFormat("{0} ", x));

            return result.ToString();
        }

        public override int GetHashCode()
        {
            int result = 0;
            this.InOrderTreeWalk(this.root, x => result ^= x.GetHashCode());

            return result;
        }

        public override bool Equals(object obj)
        {
            BST<T> bst = obj as BST<T>;

            if ((object)bst == null)
            {
                return false;
            }

            if (this.Count != bst.Count)
            {
                return false;
            }

            if (this.ToString() != bst.ToString())
            {
                return false;
            }

            return true;
        }

        public BST<T> Clone()
        {
            var result = new BST<T>(this.root.Value);

            foreach (var node in this)
            {
                result.Insert(node);
            }

            return result;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var allTreeNodes = new List<T>(this.Count);

            // iterrate over the tree nodes as in order they added
            this.PreOrderTreeWalk(this.root, x => allTreeNodes.Add(x));

            for (int i = 0; i < this.Count; i++)
            {
                yield return allTreeNodes[i];
            }
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        // find min value ( we need it for Remove())
        private TreeNode FindMin(TreeNode node)
        {
            // use to find the min node out
            if (node == null)
            {
                return null;
            }

            if (node.LeftChild == null)
            {
                return node;
            }

            return this.FindMin(node.LeftChild);
        }

        // iterrate over the tree methods
        private void InOrderTreeWalk(TreeNode root, Action<T> action)
        {
            // Left subTree -> Root -> Right subTree
            if (root == null)
            {
                return;
            }

            action(root.Value);
            this.InOrderTreeWalk(root.LeftChild, action);
            this.InOrderTreeWalk(root.RightChild, action);
        }

        private void PreOrderTreeWalk(TreeNode root, Action<T> action)
        {
            // Root -> Left subTree -> Right subTree
            if (root == null)
            {
                return;
            }

            this.InOrderTreeWalk(root.LeftChild, action);
            action(root.Value);
            this.InOrderTreeWalk(root.RightChild, action);
        }

        // insert a node
        private void Insert(T element, ref TreeNode node)
        {
            if (node == null)
            {
                node = new TreeNode(element);
                this.Count++;
                return;
            }

            if (element.CompareTo(node.Value) < 0)
            {
                this.Insert(element, ref node.LeftChild);
                return;
            }

            if (element.CompareTo(node.Value) > 0)
            {
                this.Insert(element, ref node.RightChild);
                return;
            }
        }

        // remove a node
        private void Remove(T element, ref TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            if (element.CompareTo(node.Value) < 0)
            {
                this.Remove(element, ref node.LeftChild);
            }
            else if (element.CompareTo(node.Value) > 0)
            {
                this.Remove(element, ref node.RightChild);
            }
            else if (node.LeftChild != null && node.RightChild != null)
            {
                node.Value = this.FindMin(node.RightChild).Value;

                this.Remove(node.Value, ref node.RightChild);
            }
            else
            {
                node = (node.LeftChild != null) ? node.LeftChild : node.RightChild;
            }
        }

        public class TreeNode
        {
            public TreeNode LeftChild;

            public TreeNode RightChild;

            public TreeNode(T value)
            {
                this.Value = value;
                this.LeftChild = null;
                this.RightChild = null;
            }

            public T Value { get; set; }
        }
    }
}
