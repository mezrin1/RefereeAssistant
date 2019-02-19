using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using ITU.RefereeAssistant.Web.Models;

namespace ITU.RefereeAssistant.Web.Controllers
{
    public class TournamentController : Controller
    {
        // GET: Tournament
        public ActionResult Index(user user)
        {
            //get - передача данных явно
            //post - передача данных скрыто
            //Cookies - отправляются с каждым запросом
           /* var d1 = Request.Form["d"];
            var d2 = Request.QueryString["d"];
            var d3 = Request.Cookies["d"];
            var d4 = Request.Files["d"];

            ViewBag.d = d;
            ViewBag.s = s;*/



            return View("Edit", user);
        }

        [HttpPost]
        public ActionResult Save(user user)
        {
            if(!ModelState.IsValid) //доп. проверка на сервере так как на клиенте можно изменить данные
            {
                return View("Edit", user);
            }

            if(user.Age < 10)
            {
                ModelState.AddModelError("Age", "Что-то не так с возрастом");
                ModelState.AddModelError("", "Что-то не так с возрастом");
                return View("Edit", user);
            }

            user.Age *= 2;
            return View("Edit", user);
        }
    }
}