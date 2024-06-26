﻿using NLog;
using System;
using System.Web.Mvc;

namespace Falzoni.Presentation.Administrator.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public ActionResult Index()
        {
            try
            {
                return View();
            }

            catch (Exception ex)
            {
                _logger.Fatal("Ocorreu um erro: ", ex);
                throw;
            }
        }
    }
}