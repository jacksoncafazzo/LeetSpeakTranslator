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
        List<LeetSpeak> allLeets = LeetSpeak.GetAll();
        return View["translated.cshtml", allLeets];
      };
      // Post["/more_leets"] = _ => {
      //   LeetSpeak messageForUser = new LeetSpeak(Request.Form["translate-me"], "");
      //   messageForUser = messageForUser.Translate();
      //   List<LeetSpeak> allLeets = LeetSpeak.GetAll();
      //   return View["translated.cshtml", allLeets];
      // };
      Post["/leet/{id}"] = parameters => {
        List<LeetSpeak> allLeets = LeetSpeak.GetAll();
        allLeets.RemoveAt(parameters.id - 1);
        return View["translated.cshtml", allLeets];
      };

    }
  }
}
