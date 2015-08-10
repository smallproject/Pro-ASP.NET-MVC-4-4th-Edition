using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        /*
        public string Index()
        {
            return "Hello World! MVC 4";
         * //this is a string results
        }
        */

        /*
        public ActionResult Index()
        {
            return View();
        }
         */

        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";

            string what = "There is a party around the block";
            ViewBag.What = what;

            string where = "Reiger 32";
            ViewBag.where = where;

            DateTime partydate = DateTime.Now.AddDays(1);
            string when = string.Format("{0}", partydate.ToLongDateString());
            ViewBag.when = when;


            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestReponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                //TODO: Email response to the party oganizer
                return View("Thanks", guestResponse);
            }
            else
            {
                //there is a validation error
                return View();
            }
        }

        [HttpGet]
        public ViewResult Register()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Register(Register register)
        {
            //TODO: Succesful registration
            return View("RegThanks", register);
        }



        [HttpGet]
        public ViewResult Account()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Account(Account account)
        {
            return View("Account_register", account);
        }


    }
}
