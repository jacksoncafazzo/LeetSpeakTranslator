using System;

namespace LeetSpeakTranslator
{
  public class LeetSpeakTranslator
  {
    public string Translate(string word)
    {
      char[] wordArray = word.ToCharArray();
      char[] testArray = "eoLs".ToCharArray();
      char[] replaceArray = "301z".ToCharArray();

      for (int i = 0; i < 4; i++)
      {
        for (int j = 0; j < wordArray.Length; j++)
        {
          if (wordArray[j] == testArray[i])
          {
            if (i != 3 || j > 0)
            {
              wordArray[j] = replaceArray[i];
            }
            else if (i == 2 && char.IsUpper(wordArray[j]))
            {
              wordArray[j] = replaceArray[i];
            }
          }
        }
      }
      string translatedString = String.Join("", wordArray);
      return translatedString;
    }
  }
}
