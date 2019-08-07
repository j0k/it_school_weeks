using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FileUpload.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace FileUpload.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHostingEnvironment _host;
        public HomeController(IHostingEnvironment host)
        {
            _host = host;
        }
        public IActionResult Index()
        {            
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(Picture picture)
        {
            if (picture.File.Length > 0)
            {
                var filename = Path.GetFileName(picture.File.FileName);                
                var path = Path.Combine(_host.WebRootPath + "/upload", filename);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await picture.File.CopyToAsync(stream);
                }
            }
            return View();
        }
    }
}
