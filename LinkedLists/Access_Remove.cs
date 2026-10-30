using System;
using System.Collections.Generic;

public class LinkedLists {
    public static void Main() {
        LinkedListNode<int>i? list= new LinkedList<int>();

        //add elements in the linked list
        for(int i=0; i<=5; i++) 
            list.AddLast(i*10);

        //access the first and the last element
        Console.WriteLine("The first node in the linked list: " +  list.First?.Value);
        Console.WriteLine("The last node in the linked list: " +  list.Last?.Value);

        //finding the target value
        int target = 30;
        LinkedList<int>? node = list.Find(target);
        if (node != null)
            Console.WriteLine($"{node.Value} has been found");
    }
}
