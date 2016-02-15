using Nancy;
using LeetSpeakTranslator.Objects;
using System.Collections.Generic;

namespace LeetSpeakTranslator
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];
      Post["/translate"] = _ => {
        LeetSpeak messageForUser = new LeetSpeak(Request.Form["translate-me"], "");
        messageForUser = messageForUser.Translate();
        // List<LeetSpeak> messagesForUser = new List<LeetSpeak>() {};
        // messagesForUser = messagesForUser.GetAll();
        return View["translated.cshtml", messageForUser];
      };
      Post["/more_leets"] = _ => {
        LeetSpeak messageForUser = new LeetSpeak(Request.Form["another-leet"], "");
        messageForUser = messageForUser.Translate();
        return View["translated.cshtml", messageForUser];
      };

    }
  }
}
