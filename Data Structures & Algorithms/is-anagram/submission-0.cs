public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length){
            return false;
        }
        var hs1 = new Dictionary<char, int>();
        var hs2 = new Dictionary<char, int>();
        foreach( var str in s){
            if(hs1.ContainsKey(str)){
                var freq = hs1[str];
                hs1[str] = freq +1;
            } else {
                hs1[str] = 1;
            }
        }
        foreach( var str in t){
             if(hs2.ContainsKey(str)){
                var freq = hs2[str];
                hs2[str] = freq +1;
            } else {
                hs2[str] = 1;
            }
        }
        foreach( var map in hs1){
            if(hs2.ContainsKey(map.Key)){
                var freq1 = hs2[map.Key];
                var freq2 = map.Value;
                if(freq1 != freq2){
                    return false;
                }
            } else {
                return false;
            }
        }
        return true;
    }
}
