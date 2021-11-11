using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace AS91880.Pages
{
    public class NotFoundModel : PageModel
    {
        private readonly ILogger<NotFoundModel> _logger;
        public NotFoundModel(ILogger<NotFoundModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
            _logger.LogInformation("Accessed {page} at {Time}", nameof(NotFoundModel), DateTime.Now);
        }
    }
}
