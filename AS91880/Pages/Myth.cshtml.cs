using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace AS91880.Pages
{
    public class MythModel : PageModel
    {
        private readonly ILogger<MythModel> _logger;
        public MythModel(ILogger<MythModel> logger)
        {
            _logger = logger;
        }
        public void OnGet() // log access time
        {
            _logger.LogInformation("Accessed {page} at {Time}", nameof(NotFoundModel), DateTime.Now);
        }
    }
}
