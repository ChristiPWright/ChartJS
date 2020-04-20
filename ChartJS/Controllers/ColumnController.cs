﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StackedChartwithCoreMVCDemo.Models;

namespace StackedChartwithCoreMVCDemo.Controllers
{
    public class ColumnChartController : Controller
    {
        // GET: /<controller>/  
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public JsonResult PopulationChart()
        {
            var populationList = PopulationDataAccessaLayer.GetCityPopulationList();
            return Json(populationList);
        }
    }
}