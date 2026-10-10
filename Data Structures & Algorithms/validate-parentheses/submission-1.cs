public class Solution {
    public bool IsValid(string s) {
        if(s.Length % 2 != 0 ) return false ;

        var stack = new Stack<char>();
        foreach(var x in s){
            if(x == '(' || x == '{' || x == '['){
                stack.Push(x);
            }
            else
            {
                if (stack.Count == 0) return false;
                var popped = stack.Pop();
                if(x == ')' && popped != '('  || x == ']' && popped != '['  || x == '}' && popped != '{'){
                    return false ;
                }
            }
        }
        return stack.Count == 0 ;
    }
}
