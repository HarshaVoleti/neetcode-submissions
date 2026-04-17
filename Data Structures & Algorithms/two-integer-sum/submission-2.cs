public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] indexes = new int[2];
        for(int i = 0; i < nums.Length; i++){
            for(int j = i + 1; j < nums.Length; j++){
                if(nums[i] + nums[j] == target){
                    if(i < j){
                        indexes[0] = i;
                        indexes[1] = j;
                    } else{
                        indexes[0] = j;
                        indexes[1] = i;
                    }
                    return indexes;
                }
            }
        }

        return indexes;
    }
}
