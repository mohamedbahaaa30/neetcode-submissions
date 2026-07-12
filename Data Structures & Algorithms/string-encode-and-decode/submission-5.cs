public class Solution {

    public string Encode(IList<string> strs) {
        var encoded = new StringBuilder();
        var sizes = new List<int>();
        foreach (var item in strs){
            sizes.Add(item.Length);
        }
        foreach(var size in sizes){
            encoded.Append(size).Append(',');
        }
        encoded.Append('#');
        foreach(var item in strs){
            encoded.Append(item);
        }
        return encoded.ToString();
    }

    public List<string> Decode(string s) {
        int i=0 ; 
        while (s[i] != '#'){
            i++;
        }
        var Strsizes = s.Substring(0,i);
        i++;// now i points to the first character
        List<int> sizes = new List<int>();
        var stringSizes = Strsizes.Split(',', StringSplitOptions.RemoveEmptyEntries);
        foreach(var size in stringSizes){
            sizes.Add(int.Parse(size));
        }
        var result = new List<string>();
        foreach(var size in sizes){
            result.Add(s.Substring(i,size));
            i+=size;
        }
    return result;
   }
}
