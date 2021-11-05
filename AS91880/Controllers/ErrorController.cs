using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AS91880.Controllers
{
    [Route("[controller]")]
    public class ErrorController : ControllerBase
    {
        [Route("404")]
        public IActionResult PageNotFound()
        {
            return RedirectToPage("/NotFound");
        }
    }
}
