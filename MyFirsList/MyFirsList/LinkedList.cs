using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirsList
{
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        public Node(int value)
        {
            Value = value;
            Next = null;
        }
    }
    class LinkedList
    {
        
        public int Length { get; private set; }
        private Node _root;
        public int this [int index]
        {
            get
            {
                Node current = _root;

                for(int i = 1; i<=index;i++)
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
               
        public LinkedList() 
        {
            Length = 0;
            _root = null;

        }
        public LinkedList(int value)
        {
            Length = 1;
            _root = new Node(value);

        }
        public LinkedList(int[] value)
        {
            Length = value.Length;
            if(value.Length!=0)
            {
                _root = new Node(value[0]);

                for (int i = 0; i < value.Length; i++)
                {
                    _root.Next = new Node(value[i]);
                    _root = _root.Next;
                }
            }
            else
            {
                _root = null;
            }
            
        }

        public void Add(int value)
        {
            Length++;
            _root.Next = new Node(value);
            _root = _root.Next;
        }
        public void RemoveFirst()
        {
            _root = _root.Next;
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

        public override bool Equals(object obj)
        {
            LinkedList list = (LinkedList)obj;
            if(this.Length!= list.Length)
            {
                return false;
            }

            Node currentThis = _root;
            Node currentList = list._root;

            do
            {
                if (currentThis.Value != currentList.Value)
                {
                    return false;
                }
                currentList = currentList.Next;
                currentThis = currentThis.Next;
            }
            while (!(currentThis.Next is null));
                return true;
        }
        public override string ToString()
        {   
            if(Length!=0)
            {
                Node current = _root;
                string s = current.Value + " ";
                while (!(current.Next is null))
                {
                    current = current.Next;
                    s += current.Value + " ";
                }


                return s;
            }
            else
            {
                return String.Empty;
            }

        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

}
