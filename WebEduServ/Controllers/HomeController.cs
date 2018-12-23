using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebEduServ.Models;

namespace WebEduServ.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        [Route("api/Home/GetClasses")]
        public IEnumerable<Classe> GetClasses()
        {
            return Classe.GetAllClasses();
        }

        [HttpGet]
        [Route("api/Home/GetEtablissement/{classeid?}")]
        public IEnumerable<Etablissement> GetEtablissement(int classeid = 1)
        {
            List<Etablissement> lstEtablissement = Etablissement.GetAllEtablissements();
            return lstEtablissement.Where(item => item.classeid == classeid);
        }
    }
}
