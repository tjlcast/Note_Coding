/**
Given an array of integers, return indices of the two numbers such that they add up to a specific target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

Example:

Given nums = [2, 7, 11, 15], target = 9,

Because nums[0] + nums[1] = 2 + 7 = 9,
return [0, 1].
**/

public class Solution {
    public int[] TwoSum(int[] nums, int target) {	
		return TwoSum2(nums, target); 
	}

    public int[] TwoSum1(int[] nums, int target) {
    	for (int i=0; i<nums.Length; i++) {
    		for (int j=i+1; j<nums.Length; j++) {
    			if (target == nums[i] + nums[j]) {
    				return new int[2]{i, j};
    			}
    		}
    	}
    	return new int[2]{-1, -1};
    }

    public int[] TwoSum2(int[] nums, int target) {
    	Hashtable ht = new Hashtable(); 

    	for (int i=0; i<nums.Length; i++) {
    		int rest = target - nums[i]; 
    		if (ht.Contains(rest)) {
                int idx = Convert.ToInt32(ht[rest]); 
    			return new int[2]{idx, i}; 
    		}
    		if(!ht.Contains(nums[i]))ht.Add(nums[i], i); 
    	}

    	return new int[2]{-1, -1};
    }
}