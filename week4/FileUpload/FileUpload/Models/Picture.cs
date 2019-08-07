using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Http;

namespace FileUpload.Models
{
    public class Picture
    {
        public IFormFile File { get; set; }
    }
}
