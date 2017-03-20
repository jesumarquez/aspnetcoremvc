using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace aspnetcoremvc.Controllers
{
    public class SampleController: Controller
    {
        private readonly GeneralOptions _options;
        public SampleController(IOptions<GeneralOptions> options)
        {
            _options = options.Value;
        }
        public ActionResult Index()
        {
            string option1 = _options.Option1;
            return View("Index", option1);
        }
    }
}