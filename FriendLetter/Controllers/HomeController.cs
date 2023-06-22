using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {
    [Route("/hello")]
    public string Hello()
    {
      return "Hello friend!";
    }

    [Route("/goodbye")]
    public string Goodbye()
    {
      return "Goodbye friend.";
    }

    [Route("/form")]
    public ActionResult Form()
    {
      return View();
    }

    [Route("/postcard")]
    public ActionResult Postcard(string recipient, string sender)
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = recipient;
      myLetterVariable.Sender = sender;
      return View(myLetterVariable);
    }

    [Route("/")]
    public ActionResult Letter()
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = "Lina";
      myLetterVariable.Sender = "Jo";
      return View(myLetterVariable);
    }
  }
}