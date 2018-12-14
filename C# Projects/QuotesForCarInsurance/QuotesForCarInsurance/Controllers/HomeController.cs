using QuotesForCarInsurance.Models;
using QuotesForCarInsurance.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuotesForCarInsurance.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Admin()
        {
            using (QuotesCarInsuranceEntities db = new QuotesCarInsuranceEntities())
            {
                var listOfQuotes = db.Quotes;
                var quotes = new List<QuoteVM>();
                foreach (var quoteItem in listOfQuotes)
                {
                    var quote = new QuoteVM();
                    quote.Id = quoteItem.Id;
                    quote.FirstName = quoteItem.FirstName;
                    quote.LastName = quoteItem.LastName;
                    quote.EmailAddress = quoteItem.EmailAddress;
                    quote.MonthlyPrice = (float)quoteItem.MonthlyPrice;
                    quotes.Add(quote);
                }

                return View(quotes);
            }
        }

        [HttpPost]
        public ActionResult Quote(
            string firstName, 
            string lastName, 
            string emailAddress, 
            DateTime dateOfBirth, 
            int? carYear, 
            string carMake, 
            string carModel,
            string dUI,
            int? speedingTickets,
            string coverageType
            
        ){
            if (string.IsNullOrEmpty(firstName)
                || string.IsNullOrEmpty(lastName)
                || string.IsNullOrEmpty(emailAddress)
                || dateOfBirth == null
                || carYear == null
                || string.IsNullOrEmpty(carMake)
                || string.IsNullOrEmpty(carModel)
                || speedingTickets == null
                || speedingTickets < 0
                || string.IsNullOrEmpty(coverageType)
            )
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                float monthlyPrice = 50.0f;
                using (QuotesCarInsuranceEntities db = new QuotesCarInsuranceEntities())
                {
                    var quote = new Quote();
                    quote.FirstName = firstName;
                    quote.LastName = lastName;
                    quote.EmailAddress = emailAddress;
                    quote.DateOfBirth = dateOfBirth;
                    quote.CarYear = carYear;
                    quote.CarMake = carMake;
                    quote.CarModel = carModel;
                    quote.DUI = dUI != null;
                    quote.SpeedingTickets = speedingTickets;
                    quote.CoverageType = coverageType;
                    
                    int currentAge = DateTime.Now.Year - dateOfBirth.Year;
                    if (DateTime.Now.Month < dateOfBirth.Month)
                    {
                        currentAge--;
                    }
                    else if (DateTime.Now.Month == dateOfBirth.Month && DateTime.Now.Day < dateOfBirth.Day)
                    {
                        currentAge--;
                    }
                    if (currentAge < 25) { monthlyPrice += 25.0f; }
                    if (currentAge < 18) { monthlyPrice += 100.0f; }
                    if (currentAge > 100) { monthlyPrice += 25.0f; }
                    if (carYear < 2000) { monthlyPrice += 25.0f; }
                    if (carYear > 2015) { monthlyPrice += 25.0f; }
                    if (carMake.ToLower() == "Porsche")
                    {
                        monthlyPrice += 25.0f;
                        if (carModel.ToLower() == "911 carrera")
                        {
                            monthlyPrice += 25.0f;
                        }
                    }
                    monthlyPrice += 10 * Convert.ToInt32(speedingTickets);
                    if (dUI != null) { monthlyPrice += monthlyPrice * 0.25f; }
                    if (coverageType == "Full") { monthlyPrice += monthlyPrice * 0.5f; }
                    quote.MonthlyPrice = monthlyPrice;


                    db.Quotes.Add(quote);
                    db.SaveChanges();
                }


                string priceFormatted = monthlyPrice.ToString("C2");

                ViewBag.MonthlyPrice = priceFormatted;
                return View("SuccessfulQuote");
            }
        }
    }
}