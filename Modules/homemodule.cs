using System;
using System.Collections.Generic;
using Nancy;
using AnagramGame.Objects;

namespace AnagramGame
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {return View["index.cshtml"]; };

      Get["/result"] = _ => {
      Anagram newAnagram = new Anagram(Request.Query["userWord"] , Request.Query["compareWord"]);
      return View["result.cshtml", newAnagram];
      };
    }
  }
}
