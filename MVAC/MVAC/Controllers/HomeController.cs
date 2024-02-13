using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PayPal.Api;

namespace MVAC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TestLayout()
        {
            return View();
        }

        public ActionResult OnlinePayment()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult PayPalRegistration()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult PayPalYearly()
        {
            return View();
        }

        public ActionResult PayPalYearlyandRegsitration()
        {
            return View();
        }



        public ActionResult TestingShared()
        {
            return View();
        }


    }


}