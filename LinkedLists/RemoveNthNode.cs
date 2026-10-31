using System;
using System.Collections;
using System.Collections.Generic;

public class LinkedLists {
    public static void Main() {
        LinkedList<int> list = new LinkedList<int>();
        for(int i=0; i< 20; i++) list.AddLast(i);

        RemoveNthElement(list, 19); 
        PrintList(list);
    }

    public static void PrintList(LinkedList<int> list) {
        foreach(int i in list)
            Console.WriteLine($" {i} ");
    }

    public static bool RemoveNthElement(LinkedList<int> list, int n){
        //checking the bounds of position n
        if(n<0 || n>=list.Count){
            Console.WriteLine("Out of bounds!!");
            return false;
        }

        //create the current node 
        LinkedListNode<int>? current;

        //if n<list.Count/2 we are close to the upper half side
        if(n<list.Count/2) {
            current = list.First;
            //iterate through to see each node
            for (int i=0; i<n && current!=null; i++) {
                current = current.Next;
            }
        }
        //closer to the back (tail)
        else {
            current = list.Last;
            for(int i=0; i<list.Count-1-n && current !=null; i++) {
                current = current.Previous;
            }
        }

        if (current ==null) return false;
        list.Remove(current!);
        return true;
    }
}
