class Solution {

    public String encode(List<String> strs) {
        StringBuilder encoded=new StringBuilder();
        // len#word
        for(int i=0;i<strs.size();i++)
        {
            encoded.append(strs.get(i).length());
            encoded.append("#");
            encoded.append(strs.get(i));
        }
        return encoded.toString();
    }

    public List<String> decode(String str) {
        ArrayList<String> res=new ArrayList<>();
        int i=0;
        int j=0;
        while(i<str.length()){

            while(str.charAt(j)!='#')
            {
                j++;
            }
            int len=Integer.parseInt(str.substring(i,j));
            i=j+1; //skip the # and stay at the first char of word
            j=i+len; //stop at the begin of the next number 
            res.add(str.substring(i,j));
            i=j;
        }
        return res;
    }
}
