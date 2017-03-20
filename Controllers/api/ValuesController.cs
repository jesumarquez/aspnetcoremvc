using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace aspnetcoremvc
{
    [Route("api/[controller]")]
    public class ValuesController
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}