﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyEgitimAkademi_Portfolio.Controllers
{
    public class CVController : Controller
    {
        // GET: CV
        public FileResult GetCv()
        {
            byte[] fileBytes = System.IO.File.ReadAllBytes(Server.MapPath("~/Templates/Cv/" + "2.pdf"));
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Pdf);

        }
    }
}