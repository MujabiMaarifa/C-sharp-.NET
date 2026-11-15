using System;
using System.Collections;
using System.Collections.Generic;

public class TwoSum
{
    public static void Main(string[] args)
    {
        int[] nums = {3, 2, 4};
        int target = 6;

        Console.WriteLine(string.Join(", ", twoSum(nums, target)));
    }
    public static int[] twoSum(int[] nums, int target)
    {
        int n = nums.Length;
        var map = new Dictionary<int, int>();

        for(int i=0; i<n; i++)
        {
            int needed = target-nums[i];
            if(map.TryGetValue(needed, out int j)) return new int[]{j, i};
            map[nums[i]]=i;
        }
        return Array.Empty<int>();
    }
}