using System;
using System.Collections;

class ContainerWithMostWater {
    public static void Main(string[] args) {
        int[] walls = [1, 8, 6, 2, 5, 4, 8, 3, 7];
        Console.WriteLine(maxArea(walls));
    }
    public static int maxArea(int[] heights) {
        int n = heights.Length;
        int left=0, right=n-1, maxArea = 0;
        while(left<right) {
            int width = right-left;
            int currentHeight = heights[right]-heights[left];
            int currentArea = width * currentHeight;
            if(currentArea > maxArea) maxArea = currentArea;
            if(heights[left]<heights[right]) left++;
            else right--;
        }
        return maxArea;
    }
}
