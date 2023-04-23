namespace Practice5
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
    public class LLPop
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

        public void Pop()// 56 30 40 70
        {
            if (head == null)
                throw new NullReferenceException("list is empty");
            Node t = head, prev = null;
            while (t.next != null)
            {
                prev = t;
                t = t.next;
            }
            prev.next = null;
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
            LLPop ll = new LLPop();
            ll.insert(70);
            ll.insert(40);
            ll.insert(30);
            ll.insert(56);
            ll.Pop();
            ll.display();

        }
    }
  }

}