using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirsList
{
    class DoubleLinkedList
    {
        public int Length { get; private set; }
        public int this[int index]
        {
            get
            {
                Node current = _root;

                for (int i = 1; i <= index; i++)
                {
                    current = current.Next;
                }

                return current.Value;

            }
            set
            {
                Node current = _root;

                for (int i = 1; i <= index; i++)
                {
                    current = current.Next;
                }

                current.Value = value;
            }
        }

        private Node _root;
        private Node _tail;
        public DoubleLinkedList()
        {
            Length = 0;
            _root = null;
            _tail = null;
        }
        public DoubleLinkedList(int value)
        {
            Length = 1;
            _root = new Node(value);
            _tail = _root;
        }
        public DoubleLinkedList(int[] value)
        {
            Length = value.Length;
            if (value.Length != 0)
            {
                _root = new Node(value[0]);
                _tail = _root;
                for (int i = 0; i < value.Length; i++)
                {
                    _tail.Next = new Node(value[i]);
                    _tail = _tail.Next;
                }
            }
            else
            {
                _root = null;
                _tail = null;
            }

        }
        public void AddFirst(int value)
        {
            Length++;
            _root.Next = new Node(value);
            _root = _root.Next;
        }

        public void AddLast(int value)
        {
            Length++;
            _tail.Next = new Node(value);
            _tail = _tail.Next;
        }

        public void RemoveFirst()
        {
            _root = _root.Next;
        }
        public void RemoveLast()
        {
            _tail = _tail.Next;
        }
        public void RemoveByIndex(int index)
        {
            Node current = _root;

            for (int i = 1; i < index; i++)
            {
                current = current.Next;
            }

            current.Next = current.Next.Next;

            Length--;
        }
    }
}
