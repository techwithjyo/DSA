public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        int[] output = new int[2];
        for(int i=0 ; i< nums.Length - 1; i++)
        {
            for(int j=i+1 ; j< nums.Length ; j++)
            {
                if (nums[i] + nums[j] == target)
                    {
                        output[0]=i;
                        output[1]=j;
                    }
            }
           
        }
         return output;
        
    }
}