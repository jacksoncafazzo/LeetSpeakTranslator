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
        LeetSpeak messageForUser = new LeetSpeak() {};
        messageForUser = messageForUser.Translate(Request.Form["translate-me"]);
        LeetSpeak<LeetSpeak> messagesForUser = new LeetSpeak<LeetSpeak>() {};
        messagesForUser = messagesForUser.GetAll();
        return View["translated.cshtml", messagesForUser];
      };

    }
  }
}
