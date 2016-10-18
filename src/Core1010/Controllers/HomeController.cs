using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Core1010.Configure;
using Core1010.Repository.Interfaces;
using Core1010.Repository.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Core1010.Controllers
{
    public class HomeController : Controller
    {
	    private readonly IEngagementRepository _engagementRepository;
		public HomeController(IEngagementRepository engagementRepository)
		{
			_engagementRepository = engagementRepository;
		}

        public IActionResult Index()
        {
	        //var engagements = _engagementRepository.GetEngagements().ToList();
			//engagements.
			var engagement = new Engagement() {Name = "test1", Id = 3};
	        _engagementRepository.AddEngagement(engagement);

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
            return View();
        }
    }
}
