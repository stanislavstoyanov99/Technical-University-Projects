namespace Tree
{
    using System;

    public class Tree<T>
    {
        public Tree(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(Exceptions.InvalidInsertValue);
            }

            this.Root = new TreeNode<T>(value);
        }

        public Tree(T value, params Tree<T>[] children)
            : this(value)
        {
            foreach (var child in children)
            {
                this.Root.AddChild(child.Root);
            }
        }

        public TreeNode<T> Root { get; set; }
    }
}
