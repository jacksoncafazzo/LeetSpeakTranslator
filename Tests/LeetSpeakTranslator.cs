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
          if (i != 3)
          {
            if (wordArray[j] == testArray[i] || i == 2 && char.IsUpper(wordArray[j]))
            {
              wordArray[j] = replaceArray[i];
            }
          }
          if (j > 0 && i == 3 && wordArray[j] == testArray[i])
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
