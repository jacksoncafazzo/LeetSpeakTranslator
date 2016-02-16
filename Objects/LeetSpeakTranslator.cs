using System;
using System.Collections.Generic;

namespace LeetSpeakTranslator.Objects
{
  public class LeetSpeak
  {
    private string _unTranslated;
    private string _leetness;
    private int _id;
    private static List<LeetSpeak> _instances = new List<LeetSpeak>() {};

    public LeetSpeak(string unTranslated, string leetness)
    {
      _unTranslated = unTranslated;
      _leetness = leetness;
      _instances.Add(this);
      _id = _instances.Count;
    }

    public string GetUntranslated()
    {
      return _unTranslated;
    }
    public void SetUnTranslated(string newUserInput)
    {
      _unTranslated = newUserInput;
    }
    public string GetLeetSpeak()
    {
      return _leetness;
    }
    public void SetLeetSpeak(string newLeet)
    {
      _leetness = newLeet;
    }
    public int GetId()
    {
      return _id;
    }
    public void SetId(int newId)
    {
      _id = newId;
    }
    public static List<LeetSpeak> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static LeetSpeak Find(int searchId)
    {
      return _instances[searchId-1];
    }
    public static void RefreshIds(List<LeetSpeak> allTheLeets)
    {
      foreach (LeetSpeak leet in allTheLeets)
      {
        leet.SetId(_instances.IndexOf(leet) + 1);
      }
    }
    public LeetSpeak Translate()
    {
      string userInput = _unTranslated;
      char[] wordArray = userInput.ToCharArray();
      char[] testArray = "eoLsEOS".ToCharArray();
      char[] replaceArray = "301z30S".ToCharArray();

      for (int i = 0; i < replaceArray.Length; i++)
      {
        for (int j = 0; j < wordArray.Length; j++)
        {
          if (wordArray[j] == testArray[i])
          {
            if (i != 3 && i != 6 || j > 0)
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
      _leetness = String.Join("", wordArray);

      return this;
    }
  }
}
