namespace Practice1
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
    public class LLInsertMiddle
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
        public void Middle(int data, int key)
        {
            Node t = head;
            Node n = new Node(data);
            while (t != null)
            {
                if (t.data.Equals(key))
                {
                    n.next = t.next;
                    t.next = n;
                }
                t = t.next;
            }
        }
        public void display()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }

        static void Main()
        {
            LLInsertMiddle ll = new LLInsertMiddle();
            ll.insert(70);
            //ll.insert(40);
            ll.insert(30);
            ll.insert(56);
            ll.display();
            ll.Middle(40, 30);
            ll.display();


        }
    }
  }

}