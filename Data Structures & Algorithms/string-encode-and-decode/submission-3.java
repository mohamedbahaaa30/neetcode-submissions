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
        int j=i;
        while(i<str.length()){
            while(str.charAt(j)!='#')
            {
                j++;
            }
            int len=Integer.parseInt(str.substring(i,j));
            i=j+1;
            j=i+len;
            res.add(str.substring(i,j));
            i=j;
        }
        return res;
    }
}
