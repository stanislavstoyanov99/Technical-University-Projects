namespace HufmanCoding
{
    public class Node
    {
        public Node()
        {

        }

        public Node(int frequency)
        {
            this.Frequency = frequency;
        }

        public Node Left { get; set; }

        public Node Right { get; set; }

        public char Letter { get; set; }

        public int Frequency { get; set; }
    }
}
