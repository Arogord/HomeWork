namespace MergeNodes
{
    public class Program
    {
        public static void Main()
        {
            int[] head = { 0, 1, 2, 0, 3, 0, 78, 0 };

            ListNode head2 = new ListNode(head[0]);
            ListNode head0 = head2;


           // Fill List
            for(int i =1; i< head.Length; i++)
            {
                head2.next = new ListNode(head[i]);
                if (i != head.Length - 1)
                {
                    head2 = head2.next;
                }
            }

            ListNode result = MergeNodes(head0);

            Console.Write("Input List: ");
            foreach(int i in head)
            {
                Console.Write("{0} ",i);
            }
            Console.WriteLine();
            Console.Write("Output List: ");

            //print list
            while (result != null)
            {
                Console.Write("{0} ",result.val);;
                result = result.next;
                if (result == null)
                {
                    break;
                }
            }
            Console.WriteLine();



            ListNode MergeNodes(ListNode head)
            {
                ListNode temp = head;

                while (temp != null)  // Проходим по всему листу
                {
                    if (temp.val == 0 && temp.next!=null)  // Если нашли 0 то суммируем значения до обнаружения след. нуля.
                    {
                        do
                        {
                            temp.val += +temp.next.val;
                            temp.next = temp.next.next;  // удаляем обьект листа между 2 других, другими словами поглощаем.
                            if (temp.next == null)
                            {
                                break;
                            }
                        }
                        while (temp.next.val != 0);
                    }

                    //Не понятно как удалить последний элемент листа, не могу присвоить предпоследнему temp.next=null  - Поэтому создал новый
                    if (temp.val == 0 && temp.next == null)  // если обнаружили ноль  в конце создаем новый экземпляр листа
                    {
                        temp = head;
                        ListNode tmp = new ListNode();
                        ListNode tmp2 = tmp; // ссылка на первый обьект
                        int count = 0;
                        while (temp.val != 0) //последний обьект листа содержащий ноль не копируем
                        {
                            if (count == 0) //первый обьект заполняем через поле
                            {
                                tmp.val = temp.val;
                                count++;
                            }
                            else  //остальные через конструктор
                            {
                                tmp.next = new ListNode(temp.val);
                                tmp = tmp.next;
                            }
                            
                            temp = temp.next;
                        }
                        return tmp2;
                    }

                    if(temp.next != null)
                    {
                        temp = temp.next; // перещилкиваем позицию когда нашли 0 между числами.
                    }
                    
                    
                }
                return temp; //по факту эта ссылка не возвращяется, но что то написать надо :)
            }
        }
    }
}

   