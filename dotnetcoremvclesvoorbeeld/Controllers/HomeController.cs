using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyHowest;

namespace dotnetcoremvclesvoorbeeld.Controllers
{
    public class HomeController : Controller
    {

        private string[] groenten = { "Rode kool", "Spruitjes", "Wortel", "Spinazie" };

        public ViewResult Index(string name)
        {
            ViewBag.Groet = DateTime.Now.Hour < 12 ? "Goeiemorgen" : "Goeiemiddag";
            return View();
        }

        public ViewResult Groenten(string ZoekGroente)
        {
            ViewBag.Groenten = groenten;
            if (string.IsNullOrEmpty(ZoekGroente))
            {
                ViewBag.Zoekresultaat = $"de gezochte groente is " +
                                                    $"de {Array.IndexOf(groenten, ZoekGroente) + 1}e uit de lijst";
            }
            
            return View();
        }

        public ViewResult Student()
        {
            List<Student> studenten = new List<Student>
            {
                new Student {id =23, Naam = "Jefke", AfstudeerGraad = Graad.Voldoening},
                new Student {id = 23, Naam = "Marieke", AfstudeerGraad = Graad.Onderscheiding},
            };

            ViewBag.Studenten = studenten;

            return View();
        }

    }
}