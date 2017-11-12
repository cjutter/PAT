﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PAT.UI.Areas.Calculations.Models;

namespace PAT.UI.Areas.Calculations.Controllers
{
    public class BenefitsCalculationController : Controller
    {
        // GET: Calculations/BenefitsCalculation
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CalculationResult(int employeeId)
        {
            var model = new CalculationResultViewModel();
            return PartialView(model);
        }
    }
}