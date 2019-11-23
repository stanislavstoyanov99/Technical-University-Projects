namespace HufmanCoding
{
    using System;

    public class BinaryTree
    {
        private Node root;

        public BinaryTree()
        {
            this.root = null;
        }

        public void Insert(int data)
        {
            if (this.root == null)
            {
                this.root = new Node(data);
                return;
            }

            InsertRec(this.root, new Node(data));
        }

        public void DisplayTree()
        {
            DisplayTree(this.root);
        }

        private void DisplayTree(Node root)
        {
            if (root == null)
            {
                return;
            }

            DisplayTree(root.Left);
            Console.Write(root.Frequency + " ");
            DisplayTree(root.Right);
        }

        private void InsertRec(Node root, Node newNode)
        {
            if (root == null)
            {
                root = newNode;
            }

            if (newNode.Frequency < root.Frequency)
            {
                if (root.Left == null)
                {
                    root.Left = newNode;
                }
                else
                {
                    InsertRec(root.Left, newNode);
                }
            }
            else
            {
                if (root.Right == null)
                {
                    root.Right = newNode;
                }
                else
                {
                    InsertRec(root.Right, newNode);
                }
            }
        }
    }
}
