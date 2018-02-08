using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Hangman.Models;

namespace Hangman.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/game")]
    public ActionResult CreateGame()
    {
      string gameWord = Request.Form["word"];
      Game newGame = new Game(gameWord);
      newGame.SetGameBoard();
      newGame.MakeGameBoardString();
      return View("Game", newGame);
    }
  }
}
