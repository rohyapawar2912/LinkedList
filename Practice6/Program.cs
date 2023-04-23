namespace Practice6
{
  namespace Stack_Q_LL
  {
    public class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
        }
    }
    public class LLInsert
    {
        Node head;
        public void insert(int data)  // 56 30 70
        {
            Node n = new Node(data);
            if (head == null)
            {
                head = n;
            }
            else
            {
                n.next = head;
                head = n;
            }
        }

        public void display()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data);
                temp = temp.next;
            }
        }

        static void Main()
        {
            LLInsert ll = new LLInsert();
            ll.insert(10);
            ll.insert(20);
            ll.insert(30);

            ll.display();


        }
    }
  }

}