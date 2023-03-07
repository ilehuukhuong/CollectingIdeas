﻿using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace WebCollectingIdeas.Controllers
{
    public class ErrorController : Controller
    {
        [Route("/Error/{statusCode}")]
        public IActionResult HttpStatusCodeHandler(int statusCode)
        {
            string message;
            if (statusCode == 404)
            {
                message = "Sorry, the resource you requested could not be found";
                ViewBag.Path = HttpContext.Request.Path;
                ViewBag.QueryString = HttpContext.Request.QueryString;
            }
            else
            {
                message = "An error occurred while processing your request";
            }

            ViewBag.ErrorMessage = message;
            return View("NotFound");
        }
    }
}
