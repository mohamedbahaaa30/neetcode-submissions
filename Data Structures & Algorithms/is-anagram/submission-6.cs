public class Solution {
    public bool IsAnagram(string s, string t) {
       if (s.Length != t.Length)
            return false ;

        var count = new Dictionary<char,int>();
        foreach (var c in s){
            if (count.ContainsKey(c))
                count[c]++;
            else 
                count[c]=1;
        }
        foreach (var c in t){
            if (!count.ContainsKey(c))
                return false ;
 
            count[c]--;
            //may have the same characters but with different count 
            if(count[c]<0)
                return false ;
            
        }
        return true ;
        
    }
}
