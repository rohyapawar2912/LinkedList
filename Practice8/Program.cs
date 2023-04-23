namespace Practice8
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
    public class LLRemove
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
        public void Remove(int data)// 56 30 40 70
        {
            if (head == null)
                throw new NullReferenceException("list is empty");
            Node t = head, temp = null;
            bool con = false;
            while (t != null)
            {
                if (t.data.Equals(data))
                {
                    con = true;
                    temp.next = t.next;
                }
                temp = t;
                t = t.next;
            }
            if (con == false)
                Console.WriteLine("not found the value");
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
            LLRemove ll = new LLRemove();
            ll.insert(70);
            ll.insert(40);
            ll.insert(30);
            ll.insert(56);
            ll.Remove(40);
            ll.display();


        }
    }
  }

}