namespace Tree
{
    using System;
    using System.Collections.Generic;

    public class TreeNode<T>
    {
        private bool hasParent;

        private readonly List<TreeNode<T>> children;

        public TreeNode(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(Exceptions.InvalidInsertValue, nameof(value));
            }

            this.Value = value;

            this.children = new List<TreeNode<T>>();
        }

        public T Value { get; set; }

        public T Root { get; private set; }

        public int ChildrenCount => this.children.Count;

        public TreeNode<T> this[int index] => this.children[index];

        public IReadOnlyCollection<TreeNode<T>> Children => 
            this.children.AsReadOnly();

        public void AddChild(TreeNode<T> child)
        {
            if (child == null)
            {
                throw new ArgumentNullException(Exceptions.InvalidInsertValue, nameof(child));
            }

            if (child.hasParent)
            {
                throw new ArgumentException(Exceptions.ChildAlreadyHasParent);
            }

            child.hasParent = true;
            this.children.Add(child);
        }

        public bool RemoveChild(TreeNode<T> node)
        {
            if (node == null)
            {
                throw new ArgumentNullException(Exceptions.InvalidDeleteValue);
            }

            bool isRemoved = this.children.Remove(node);

            return isRemoved;
        }

        public TreeNode<T> GetChild(int index)
        {
            TreeNode<T> child = this.children[index];

            if (child == null)
            {
                throw new ArgumentException(Exceptions.ChildNotFound);
            }

            return child;
        }

        //public TreeNode<T> Find(T name, TreeNode<T> node)
        //{
        //    if (node == null)
        //    {
        //        return null;
        //    }

        //    // TODO
        //    if ((Object)node.Value == (Object)name)
        //    {

        //    }

        //}

        //public int Depth(IEnumerable<TreeNode<T>> nodes, int depth)
        //{
        //    if (nodes.Count() == 0)
        //    {
        //        return depth - 1;
        //    }

        //    List<TreeNode<T>> nextNodes = new List<TreeNode<T>>();

        //    // TODO
        //    foreach (var node in nodes)
        //    {
        //        nextNodes.Add(node.father);
        //        nextNodes.Add(node.mother);
        //    }

        //    return Depth(nextNodes, depth + 1);
        //}
    }
}
