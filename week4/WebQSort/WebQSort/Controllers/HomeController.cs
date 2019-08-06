using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebQSort.Models;

namespace WebQSort.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("MyView");
        }

        [HttpGet]
        public IActionResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RsvpForm(QSortResponse qSortResponse)
        {
            //int cmp (int x, int y) { return 0; };
            // var vals = qSortResponse.Values.Split(" ").Select(Int32.Parse).ToList();
            List<int> vals = new List<int>();
            foreach (var v in qSortResponse.Values.Split(' '))
                vals.Add(Int32.Parse(v));

            //List<int> a = new List<int>{ 1, 4, 5, 2, 1 };
            if (qSortResponse.Order == true) 
                vals = Algorithms<int>.quickSort(vals, (x, y) => x.CompareTo(y));
            else if (qSortResponse.Order == false)
                vals = Algorithms<int>.quickSort(vals, (x, y) => - x.CompareTo(y));

            qSortResponse.OrderedValues = string.Join(" ", vals); 
            Repository.AddResonses(qSortResponse);
            return View("Thanks", qSortResponse);
        }

        public IActionResult ListResponses()
        {
            return View(Repository.Responses);
        }
    }
}
