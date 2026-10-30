using System;
using System.Collections.Generic;

public class LinkedLists {
    public static void Main() {
        LinkedList<int> list = new LinkedList<int>();
        list.AddLast(10);
        list.AddLast(5);
        list.AddLast(15);
        list.AddLast(100);
        list.AddLast(20);
        list.AddFirst(0);
        foreach(int i in list) Console.Write(" {0} ", i);
        Console.WriteLine();

        int[] arr = {1, 2, 3, 5};
        LinkedList<int> list_ = new LinkedList<int>(arr);
        list_.AddFirst(0);
        list_.AddFirst(0);
        foreach(int i in list_) Console.Write(" {0} ", i);
    }
}
