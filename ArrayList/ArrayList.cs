using System;
using System.Collections;

public class SampleArrayList {
    public static void Main() {
        ArrayList Al = new ArrayList();

        //Add values in the array list
        Al.Add("Hello");
        Al.Add("World");
        
        Console.WriteLine("Array Lists which can grow dynamically. List<T>");
        Console.WriteLine("Count property: {0}", Al.Count);
        Console.WriteLine("Capacity property: {0}",  Al.Capacity);
        Console.WriteLine("Values: ");
        PrintValues(Al);
    }

    public static void PrintValues(IEnumerable list) {
        foreach (Object i in list) Console.WriteLine(" {0} ", i);
    }
}
