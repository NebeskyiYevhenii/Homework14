using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework14
{
    public class Human<T>
    {
        public T Data { get; set; }
        public Human<T> Next { get; set; }
        public Human(T data)
        {
            Data = data;
        }
    }
    public class Queue<T> : IEnumerable<T>
    {
        Human<T> head;
        Human<T> tail;
        int count;

        public void AddByIndex(T data, int index)
        {
            Human<T> newNode = new Human<T>(data);
            Human<T> node = head;
            Human<T> previous = null;
            int i = 1;

            while (i <= count)
            {
                if (i == index)
                {
                    previous.Next = newNode;
                    newNode.Next = node;
                    break;
                }
                previous = node;
                node = node.Next;
                i++;
            }
            count++;
        }

        public void AddToEnd(T data)
        {
            Human<T> node = new Human<T>(data);

            if (head == null)
            {
                head = node;
            }
            else
                tail.Next = node;
            tail = node;

            count++;
        }

        public void AddToStart(T data)
        {
            Human<T> node = new Human<T>(data);

            if (head == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                node.Next = head;
                head = node;
                count++;
            }
        }

        public bool Delete(T data)
        {
            Human<T> item = head;
            Human<T> previous = null;
            bool Return = false;
            if (head != null)
            {
                while (item != null)
                {
                    if (item.Data.Equals(data))
                    {
                        previous.Next = item.Next;
                        count--;
                        Return = true;
                    }
                    previous = item;
                    item = item.Next;
                }
                return Return;
            }
            return false;
        }

        public Human<T> this[int index]
        {
            set
            {
                Human<T> node = head;
                int i = 1;

                while (i <= index)
                {
                    if (i == index)
                    {
                        node = value;
                    }
                    node = node.Next;
                    i++;
                }
            }
            get
            {

                Human<T> indexNode = head;
                Human<T> node = head;
                Human<T> previous = null;
                int i = 1;

                while (i <= index)
                {
                    if (i == index)
                    {
                        return node;
                    }
                    previous = node;
                    node = node.Next;
                    i++;
                }

                throw new IndexOutOfRangeException();
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            Human<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

    }

}
