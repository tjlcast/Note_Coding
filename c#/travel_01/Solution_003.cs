public class Solution {
    static int maxWL = 0, maxWR = 0;
    
    public int LengthOfLongestSubstring(string s) {
        if (s.Equals("")) {
            return 0; 
        }
        
        maxWL = 0; 
        maxWR = 0;
        int wL = 0, wR = 0; 
        Hashtable ht = new Hashtable(); // <char, idx>
        
        int lastI = 0; 
        for (int i=0; i<s.Length; i++) {
            char c = s[i]; 
            int idx = i; 
            if (ht.Contains(c)) {
                int newIdx = (int)ht[c] + 1; 
                while (lastI < newIdx) {
                    ht.Remove(s[lastI]); 
                    lastI++; 
                }
                ht.Add(c, idx); 
            } else {
                // not in records. 
                ht.Add(c, idx); 
            }
            updateMaxW(lastI, i); 
        }
        
        return maxWR - maxWL + 1; 
    }
    
    private void updateMaxW(int wL, int wR) {
        if (wR - wL > maxWR - maxWL) {
            maxWL = wL; 
            maxWR = wR; 
        }
    }
}