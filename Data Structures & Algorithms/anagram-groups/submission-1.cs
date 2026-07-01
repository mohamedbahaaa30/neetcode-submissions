public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dict = new Dictionary<string, List<string>>();
        foreach(var item in strs){
            char[] chars = item.ToCharArray();
            Array.Sort(chars);
            string sorted = new string(chars);
            if(dict.ContainsKey(sorted)){
                dict[sorted].Add(item);
            }
            else {
               dict.Add(sorted, new List<string> { item });
            }
        }
        var anagram =new List<List<string>>();
        foreach (var list in dict){
        anagram.Add(list.Value.ToList());
        }
        return anagram;
    }
}
