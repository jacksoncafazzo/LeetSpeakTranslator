using System;

namespace LeetSpeakTranslator
{
  public class LeetSpeakTranslator
  {
    public string Translate(string word)
    {
      char[] wordArray = word.ToCharArray();
      char[] testArray = "eoLs".ToCharArray();
      char[] replaceArray = "30lz".ToCharArray();
      for (int i = 0; i < testArray.Length; i++)
      {
        for (int j = 0; j < wordArray.Length; j++)
        {
          if (wordArray[j] == testArray[i])
          {
            wordArray[j] = replaceArray[i];
          }
        }
      }
      string translatedString = String.Join("", wordArray);
      return translatedString;
    }
  }
}
