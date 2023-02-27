using Microsoft.AspNetCore.Mvc;
using ProjectName.Models;

namespace ProjectName.Controllers
{
  public class HomeController : Controller
  {
    [Route("/path")]
    public ActionResult Path()
    {
      ClassName variableName = new ClassName();
      variableName.PropertyName = "";
      return View(variableName);
    }
  }
}