using System;
using System.Collections;

public class Lists {
    public static void Main() {
        List<string> list = ["Hello", "world"]; 
        PrintList(list);
    }
    public static void PrintList(List<string> list) {
        list.ForEach(l => Console.Write(l + " "));
    }
}

