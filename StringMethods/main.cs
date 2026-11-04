using System;
using System.Collections;
using System.Collections.Generic;

public class SampleStack {
    public static bool check_palindrome(int x) {
        if(x<0) return false;
        string str = x.ToString();
        Stack<char> s = new Stack<char>(str);
        foreach(char c in str) {
            if(c != s.Pop()) return false;
        }
        return true;
    }
    public static void Main() {
        int bin = 11000111;
        int num1 = 12121;

        Console.WriteLine(check_palindrome(bin));
        Console.WriteLine(check_palindrome(num1));

    }
}
