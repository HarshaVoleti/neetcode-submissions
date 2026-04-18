public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var hm = new Dictionary<string, List<string>>();
        foreach(string str in strs){
            int[] freq = new int[26];
            foreach(char ltr in str){
                freq[ltr - 'a']++;
            }
            var sign = string.Join(",", freq);
            if(hm.ContainsKey(sign)){
                hm[sign].Add(str);
            } else {
                hm[sign] = new List<string>();
                hm[sign].Add(str);
            }
        }
        return hm.Values.ToList();
    }
}
