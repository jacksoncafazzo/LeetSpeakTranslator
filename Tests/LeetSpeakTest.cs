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
    public void Translate_ChangingOneWordToLeet_true()
    {
      LeetSpeakTranslator testLeetSpeak = new LeetSpeakTranslator();
      Assert.Equal("101z", testLeetSpeak.Translate("LoLs"));
    }
    [Fact]
    public void Translate_ChangeZToLeetIfFirst_false()
    {
      LeetSpeakTranslator testLeetSpeak = new LeetSpeakTranslator();
      Assert.Equal("s0faz", testLeetSpeak.Translate("sofas"));
    }
  }
}
