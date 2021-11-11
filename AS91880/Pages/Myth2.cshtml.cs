using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;

namespace AS91880.Pages
{
    public class Myth2Model : PageModel
    {
        private readonly ILogger<Myth2Model> _logger;
        public Myth2Model(ILogger<Myth2Model> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
            _logger.LogInformation("Accessed {page} at {Time}", nameof(NotFoundModel), DateTime.Now);
        }
    }
}
