using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace aspnetcoremvc.Controllers
{
    public class SampleController: Controller
    {
        private readonly GeneralOptions _options;
        private readonly ILogger _logger;
        public SampleController(IOptions<GeneralOptions> options, ILogger<SampleController> logger)
        {
            _options = options.Value;
            _logger = logger;
        }
        public ActionResult Index()
        {
            string option1 = _options.Option1;
            _logger.LogWarning(option1);
            return View("Index", option1);
        }
    }
}