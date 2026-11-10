using System;
using System.Collections;

class TwoSumTarget {
    public static void Main(string[] args) {
        int[] list = {1, 2, 3, 4, 5, 6};
        Console.WriteLine(string.Join(", ", twoSum(list, 9)));
    }
    public static int[] twoSum(int[] arr, int target) {
        int i=0;
        int j =arr.Length-1; 

        while(i<j) {
            int t = arr[i]+arr[j];
            if(t==target) return new int[] {i+1, j+1};
            if(t<target) i++;
            if(t>target) j--;
        }
        return new int[0];
    }

}
