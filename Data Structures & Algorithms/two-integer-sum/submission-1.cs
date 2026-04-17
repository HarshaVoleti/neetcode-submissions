public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] indexes = new int[2];
        var hm = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i ++){
            int req = target - nums[i];
            if(hm.ContainsKey(req)){
                var reqindex = hm[req];
                if(i < reqindex){
                    indexes[0] = i;
                    indexes[1] = reqindex;
                } else {
                    indexes[1] = i;
                    indexes[0] = reqindex;
                }
                return indexes;
            } else {
                hm.Add(nums[i], i);
            }
        }
        return indexes;
    }
}
