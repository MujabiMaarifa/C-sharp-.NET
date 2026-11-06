using System;

class LeetProblem {
    public static string LongestCommonSubstring(string[] arr) {
        //sort the arr
        Array.Sort(arr);
        int i=0;
        string first = arr[0];
        string last = arr[arr.Length-1];
        //get the minimum length of the array substrings -- outof bound index 
        int minLength = Math.Min(first.Length, last.Length);

        while(i<minLength && first[i] == last[i]) i++;

        return first.Substring(0, i);
    }
    public static void Main(string[] args) {
        string[] strs = {"flight", "flow", "fly", "fry"};
        Console.WriteLine(LongestCommonSubstring(strs));
    }
}
