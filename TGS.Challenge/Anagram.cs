namespace TGS.Challenge
{
  /*
        Devise a function that checks if 1 word is an anagram of another, if the words are anagrams of
        one another return true, else return false

        "Anagram": An anagram is a type of word play, the result of rearranging the letters of a word or
        phrase to produce a new word or phrase, using all the original letters exactly once; for example
        orchestra can be rearranged into carthorse.

        areAnagrams("horse", "shore") should return true
        areAnagrams("horse", "short") should return false

        NOTE: Punctuation, including spaces should be ignored, e.g.

        horse!! shore = true
        horse  !! shore = true
          horse? heroes = true

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */
    public class Anagram
    {
      public bool AreAnagrams(string word1, string word2)
      {
       
        
        if (a.Length != b.Length) {
            return false;
        }
 
        Dictionary<char, int> map
            = new Dictionary<char, int>();
 
       
        for (int i = 0; i < a.Length; i++) {
 
            
            if (map.ContainsKey(a[i])) {
 
             
                map[a[i]] = map[a[i]] + 1;
            }
            else {
 
                map.Add(a[i], 1);
            }
        }

        for (int i = 0; i < b.Length; i++) {
 

            if (map.ContainsKey(b[i])) {
 

                map[b[i]] = map[b[i]] - 1;
            }
            else {
                return false;
            }
        }
 
        var keys = map.Keys;

        foreach(char key in keys)
        {
            if (map[key] != 0) {
                return false;
            }
        }
         return true;

    }
}
}
