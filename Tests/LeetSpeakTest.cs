using Xunit;
namespace LeetSpeakTranslator
{
  public class LeetSpeakTest
  {
    [Fact]
    public void Translate_ChangingOneLetterToLeet_true()
    {
      LeetSpeakTranslator testLeetSpeak = new LeetSpeakTranslator();
      Assert.Equal("3", testLeetSpeak.Translate("e"));
    }
    [Fact]
    public void Translate_ChangingOneWordToAnArrayOfChars_true()
    {
      LeetSpeakTranslator testLeetSpeak = new LeetSpeakTranslator();
      Assert.Equal("l0lz", testLeetSpeak.Translate("LoLs"));
    }
  }
}
