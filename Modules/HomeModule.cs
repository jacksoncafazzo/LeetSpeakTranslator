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

    }
  }
}
