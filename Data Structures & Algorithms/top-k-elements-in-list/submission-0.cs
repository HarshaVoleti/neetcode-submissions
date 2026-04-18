public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        /// dictionary to hold key = number, value its frequence
        var hm = new Dictionary<int, int>();

        /// to hold the final lsit
        var result = new List<int>();

        /// iterating through each number int he list and for it updating frequency
        foreach( int num in nums){
            if(hm.ContainsKey(num)){
                hm[num]++;
            } else {
                hm[num] = 1;
            }
        }

        /// creating buckets enough to store all the numbers in the list num
        /// for buckets, index would be the frequency and value would be list of ints with that frequency
        var buckets = new List<int>[nums.Length + 1];

        /// iterating through each number and creating buckets with empty list
        for(int i = 0; i <= nums.Length; i++){
            buckets[i] = new List<int>();
        }

        /// iteraing through each dictionary 
        /// for bucket with that frequency adding the number
        foreach(var map in hm){
            var key = map.Key;
            var value = map.Value;
            buckets[value].Add(key);
        }

        /// iterating through all the buckets in the reverse order of frequency
        /// and adding the values to the result list
        /// but once the count of result matches thr k, we should stop
        for(int i = buckets.Length - 1; i >= 0 && result.Count() < k; i--){
            foreach(int num in buckets[i]){
                if(result.Count() == k){
                    return result.ToArray();
                } else {
                    result.Add(num);
                }
            }
        }
        return result.ToArray();
    }
}
