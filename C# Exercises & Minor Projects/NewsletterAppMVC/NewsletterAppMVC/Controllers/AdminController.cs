using NewsletterAppMVC.Models;
using NewsletterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsletterAppMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (NewsletterEntities db = new NewsletterEntities())
            {
                //var signups = db.SignUps.Where(x => x.Removed == null).ToList();
                var signups = (from c in db.SignUps where c.Removed == null select c).ToList();
                var signupVms = new List<SignUpVM>();
                foreach (var signup in signups)
                {
                    var signUpVM = new SignUpVM();
                    signUpVM.Id = signup.Id;
                    signUpVM.FirstName = signup.FirstName;
                    signUpVM.LastName = signup.LastName;
                    signUpVM.EmailAddress = signup.EmailAddress;
                    signupVms.Add(signUpVM);
                }

                return View(signupVms);
            }
        }

        public ActionResult Unsubscribe(int Id)
        {
            using (NewsletterEntities db = new NewsletterEntities())
            {
                var signup = db.SignUps.Find(Id);
                signup.Removed = DateTime.Now;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}