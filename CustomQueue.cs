namespace DeckOfCards
{
    public class CustomQueue
    {
        public class Node
        {
            public string NameOrCard;
            public Node Next;

            public Node(string nameOrCard)
            {
                NameOrCard = nameOrCard;
            }
        }

        public Node Head;
        public Node Tail;
        public int Size;

        public void Enqueue(string nameOrCard)
        {
            var newNode = new Node(nameOrCard);

            if (Head == null)
                Head = Tail = newNode;

            else
            {
                newNode.Next = Head;
                Head = newNode;
            }

            Size++;
        }

        public void Print()
        {
            var temp = Head;
            while (temp != null)
            {
                Console.WriteLine(temp.NameOrCard);
                temp = temp.Next;
            }
        }
    }
}