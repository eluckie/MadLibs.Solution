using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult StorySelection() { return View(); }

    [Route("/zoo-form")]
    public ActionResult ZooForm() { return View(); }

    [Route("/zoo-story")]
    public ActionResult ZooStory(string adjective1, string noun1, string pastTenseVerb1, string adverb1, string adjective2, string noun2, string noun3, string adjective3, string verb1, string adverb2, string pastTenseVerb2, string adjective4)
    {
      ZooStory zooStory = new ZooStory();
      zooStory.Adjective1 = adjective1;
      zooStory.Noun1 = noun1;
      zooStory.PastTenseVerb1 = pastTenseVerb1;
      zooStory.Adverb1 = adverb1;
      zooStory.Adjective2 = adjective2;
      zooStory.Noun2 = noun2;
      zooStory.Noun3 = noun3;
      zooStory.Adjective3 = adjective3;
      zooStory.Verb1 = verb1;
      zooStory.Adverb2 = adverb2;
      zooStory.PastTenseVerb2 = pastTenseVerb2;
      zooStory.Adjective4 = adjective4;
      return View(zooStory);
    }

    [Route("/park-form")]
    public ActionResult ParkForm() { return View(); }

    [Route("/park-story")]
    public ActionResult ParkStory(string adjective1, string adjective2, string estAdjective, string pluralNoun, string noun, string pastTenseVerb1, string pastTenseVerb2, string adverb1, string adverb2, string verb, int number)
    {
      ParkStory parkStory = new ParkStory();
      parkStory.Adjective1 = adjective1;
      parkStory.Adjective2 = adjective2;
      parkStory.EstAdjective = estAdjective;
      parkStory.PluralNoun = pluralNoun;
      parkStory.Noun = noun;
      parkStory.PastTenseVerb1 = pastTenseVerb1;
      parkStory.PastTenseVerb2 = pastTenseVerb2;
      parkStory.Adverb1 = adverb1;
      parkStory.Adverb2 = adverb2;
      parkStory.Verb = verb;
      parkStory.Number = number;
      return View(parkStory);
    }
  }
}