using System;
using System.Collections.Generic;

namespace LeetSpeakTranslator.Objects
{
  public class LeetSpeak
  {
    private string _leetness;
    private int _id;
    private static List<LeetSpeak> _instances = new List<LeetSpeak>() {};

    public LeetSpeak(string leetness)
    {
      _leetness = leetness;
      _instances = _instances.Add(this);
      _id = _instances.Count;
    }
    public string GetLeetSpeak()
    {
      return _leetness;
    }
    public void SetLeetSpeak(LeetSpeak leetness)
    {
      _leetness = leetness;
    }
    public int GetId()
    {
      return _id;
    }
    public static List<LeetSpeak> GetAll()
    {
      return _instances;
    }
    public void ClearAll()
    {
      _instances.Clear();
    }

    public LeetSpeak Translate(string word)
    {
      char[] wordArray = word.ToCharArray();
      char[] testArray = "eoLsEOS".ToCharArray();
      char[] replaceArray = "301z30S".ToCharArray();

      for (int i = 0; i < replaceArray.Length; i++)
      {
        for (int j = 0; j < wordArray.Length; j++)
        {
          if (wordArray[j] == testArray[i])
          {
            if (i != 3 && i != 7 || j > 0)
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
      LeetSpeak leetness = new LeetSpeak(String.Join("", wordArray));
      return leetness;
    }
  }
}
