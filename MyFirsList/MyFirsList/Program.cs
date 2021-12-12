using System;
using System.Collections.Generic;

namespace MyFirsList
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> list = new List<int>();

            //Console.WriteLine($"{list.Count} / {list.Capacity}");
            //int[] mas = new int[10];

            //list.Add(4);
            //list.Add(42);
            //list.Add(2);
            //list.Add(1);
            //list.Add(1);
            //list.Insert(2, 5);

            //Console.WriteLine($"{list.Count} / {list.Capacity}");

            MyList<int> _list = new MyList<int>();
            Console.WriteLine($"{_list.Count} / {_list.Capasity}");
            int[] mas_l = new int[10];

            _list.Add(4);
            _list.Add(42);
            _list.Add(2);
            _list.Add(1);
            _list.Add(1);

            _list.Insert(2, 5);

            _list.RemovingNElementsFromFirst(1);

            Console.WriteLine($"{_list.Count} / {_list.Capasity}");


            //Node node1 = new Node(10);
            //Node node2 = new Node(10);

            //node1.Next.Next = node2;

            //int a = node1.Next.Next.Next.Value;

            //Console.WriteLine(a);

            //LinkedList linkedList = new LinkedList(new int[] { 1,2,3,4,5,6});

            //Console.WriteLine(linkedList[2]);
            //linkedList[2] = 10;


            //Console.WriteLine(linkedList[2]);
        }
    }
}
