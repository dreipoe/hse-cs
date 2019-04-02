namespace LabLauncher.TestDir
{
    public class MyList
    {
        private class ListNode
        {
            public object data;
            public ListNode next;
        }

        private ListNode head;

        public void Push(object add)
        {
            head = new ListNode
            {
                data = add,
                next = head
            };
        }

        public void Pop()
        {
            if (head != null) head = head.next;
        }

        public int IndexOf(object findMe)
        {
            int i = 0;
            ListNode current = head;

            while (current != null)
            {
                if (!current.data.Equals(findMe))
                {
                    current = current.next;
                    i++;
                } else return i;
            }

            return -1;
        }
    }
}