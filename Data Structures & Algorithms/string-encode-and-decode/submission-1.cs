public class Solution {

    public string Encode(IList<string> strs) {
        var result = new System.Text.StringBuilder();
        foreach(string str in strs){
            result.Append(str.Length);
            result.Append('#');
            result.Append(str);
        }
        return result.ToString();
    }

    public List<string> Decode(string s) {
        List<string> result = new List<string>();
        int i = 0;
        while( i< s.Length){
            var j = i;
            while(s[j]!= '#'){
                j++;
            }
            var length = int.Parse(s.Substring(i, j-i));
            j++;
            string str = s.Substring(j, length);
            result.Add(str);
            i = j+ length;
        }
        return result;
    }
}
