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

    [Route("/arcade-form")]
    public ActionResult ArcadeForm() { return View(); }

    [Route("/arcade-story")]
    public ActionResult ArcadeStory(string pluralNoun1, string pluralNoun2, string pluralNoun3, string pluralNoun4, string noun1, string noun2, string verb, string ingVerb)
    {
      ArcadeStory arcadeStory = new ArcadeStory();
      arcadeStory.PluralNoun1 = pluralNoun1;
      arcadeStory.PluralNoun2 = pluralNoun2;
      arcadeStory.PluralNoun3 = pluralNoun3;
      arcadeStory.PluralNoun4 = pluralNoun4;
      arcadeStory.Noun1 = noun1;
      arcadeStory.Noun2 = noun2;
      arcadeStory.Verb = verb;
      arcadeStory.IngVerb = ingVerb;
      return View(arcadeStory);
    }

    [Route("/jungle-form")]
    public ActionResult JungleForm() { return View(); }

    [Route("/jungle-story")]
    public ActionResult JungleStory(string adjective1, string adjective2, string adjective3, string adjective4, string adjective5, string adjective6, string adjective7, string noun1, string noun2, string noun3, string noun4, string verb1, string verb2, string verb3, string verb4)
    {
      JungleStory jungleStory = new JungleStory();
      jungleStory.Adjective1 = adjective1;
      jungleStory.Adjective2 = adjective2;
      jungleStory.Adjective3 = adjective3;
      jungleStory.Adjective4 = adjective4;
      jungleStory.Adjective5 = adjective5;
      jungleStory.Adjective6 = adjective6;
      jungleStory.Adjective7 = adjective7;
      jungleStory.Noun1 = noun1;
      jungleStory.Noun2 = noun2;
      jungleStory.Noun3 = noun3;
      jungleStory.Noun4 = noun4;
      jungleStory.Verb1 = verb1;
      jungleStory.Verb2 = verb2;
      jungleStory.Verb3 = verb3;
      jungleStory.Verb4 = verb4;
      return View(jungleStory);
    }
  }
}