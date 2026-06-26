public class Solution {
    public bool IsAnagram(string s, string t) {
       if (s.Length != t.Length)
            return false ;

        var list_1 =s.ToCharArray();
        var list_2 =t.ToCharArray();
        Array.Sort(list_1);
        Array.Sort(list_2);
        return new string(list_1) == new string(list_2);
    }
}
