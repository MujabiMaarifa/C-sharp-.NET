using System;
using System.Collections.Generic;

public class LinkedLists {
    public static void Main() {
        LinkedList<int>? list= new LinkedList<int>();

        //add elements in the linked list
        for(int i=0; i<=5; i++) 
            list.AddLast(i*10);

        //access the first and the last element
        Console.WriteLine("The first node in the linked list: " +  list.First?.Value);
        Console.WriteLine("The last node in the linked list: " +  list.Last?.Value);

        //finding the target value
        int target = 30;
        LinkedListNode<int>? node = list.Find(target);
        if (node != null)
            Console.WriteLine($"{node.Value} has been found");

        Console.WriteLine();
        PrintList(list);
        Console.WriteLine();
        RemoveNthElement(list, 4);
        PrintList(list);
    }
    public static void PrintList(LinkedList<int> list) {
        foreach(int i in list) 
            Console.WriteLine(" {0} ", i);
    }

    //function to remove the nth element (at n position)
    public static bool RemoveNthElement(LinkedList<int> list, int n) {
        if (n<0 || n>=list.Count) {
            Console.WriteLine("The position is out of bound!!");
            return false;
        }

        //create a current node that keeps track of the value we are at and the links of the next node
        LinkedListNode<int>? current = list.First;
        for(int i=0; i<n && current!=null; i++)
            current = current.Next;

        if (current == null) return false;
        list.Remove(current!);
        return true;
    }
}
