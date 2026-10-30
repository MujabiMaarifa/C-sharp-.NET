using System;
using System.Collections;

public class ArrayInitiallization {
    public static void Main() {
        ArrayList list= new ArrayList();
        for(int i=0; i<=5; i++) list.Add(i*2);
        PrintValues(list);
        Object value_=4; //value exists
        BinaryS(list, value_);
        Object value = 3;
        BinaryS(list, value); // the value does not exist
    }
    public static void BinaryS(ArrayList list, Object target) {
        int index= list.BinarySearch(target);
        if (index<0) Console.WriteLine("The target {0} does not exist!", target );
        else Console.WriteLine("Index {0}, contains the element {1} as the target we are looking for in the List", index, target);
    }
    public static void PrintValues(IEnumerable list) {
        foreach(Object i in list) 
            Console.Write(" {0} ", i);
        Console.WriteLine();
    }
}

