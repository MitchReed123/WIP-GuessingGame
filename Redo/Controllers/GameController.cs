using Redo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Redo.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult Index()
        {
            Session["Answer"] = new Random().Next(10, 50);

            return View();
        }
        //old statement for GuessWasCorrect
        //private bool GuessWasCorrect(int guess)
        //{
        //    return guess == (int)Session["Answer"];
        //}


        //Easier way to do the higher or lower.
        private int GuessWasCorrect(int guess)
        {
            return guess.CompareTo((int)Session["Answer"]);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Index(GameModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Win = GuessWasCorrect(model.Guess);
            }
            
            return View(model);
        }
        // More difficult way to do the higher low 
        //public int HighLow(int guess)
        //{
        //    if (guess == ViewBag.Win)
        //    {
        //        return 0;
        //    }
        //    if (guess < ViewBag.Win)
        //    {
        //        return -1;
        //    }
        //    return 1;
        //}  

    }
}