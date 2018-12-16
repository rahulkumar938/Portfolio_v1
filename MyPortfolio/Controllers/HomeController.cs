using Highsoft.Web.Mvc.Charts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPortfolio.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Portfolio()
        {
            return View();
        }

        public ActionResult Introduction()
        {
            return View();
        }

        public ActionResult Education()
        {
            return View();
        }

        public ActionResult Certifications()
        {
            return View();
        }

        public ActionResult TechnicalExpertise()
        {
            //List<PieSeriesData> pieData = new List<PieSeriesData>();

            //pieData.Add(new PieSeriesData { Name = "C#", Y = 8 });
            //pieData.Add(new PieSeriesData { Name = "SQL Server", Y = 8.2 });
            //pieData.Add(new PieSeriesData { Name = "ADO.Net", Y = 8 });
            //pieData.Add(new PieSeriesData { Name = "Entity Framework", Y = 8.5 });
            //pieData.Add(new PieSeriesData { Name = "ASp.Net MVC", Y = 9 });
            //pieData.Add(new PieSeriesData { Name = "HTML5", Y = 9 });
            //pieData.Add(new PieSeriesData { Name = "CSS3", Y = 8 });
            //pieData.Add(new PieSeriesData { Name = "Twitter Bootstrap", Y = 8 });
            //pieData.Add(new PieSeriesData { Name = "Javascript", Y = 7 });

            //ViewData["pieData"] = pieData;
            return View();
        }

        public FilePathResult Resume()
        {
            return File(@"..\Documents\CV_Rahul.pdf","pdf");
        }

    }
}