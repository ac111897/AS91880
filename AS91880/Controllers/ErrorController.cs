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
        /// <summary>
        /// Reroutes a 404 to the notfound page
        /// </summary>
        /// <returns></returns>
        [Route("404")]
        public IActionResult PageNotFound()
        {
            return RedirectToPage("/NotFound");
        }
    }
}
