using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace AS91880.Services
{
    /// <summary>
    /// Retrieves content from ~/Content folder, if not found displays an error msg
    /// </summary>
    public class ContentService
    {
        private readonly ILogger<ContentService> _logger;
        private readonly IConfiguration _config;

        public ContentService(IConfiguration config, ILogger<ContentService> logger)
        {
            _config = config;
            _logger = logger;
        }
        private string GetPath(string sub)
        {
            _logger.LogInformation("Retrieving path at {sub}", sub);
            return $"{Directory.GetCurrentDirectory()}{_config[sub]}";
        }
        public string[] GetContent(string key) => File.ReadAllLines(GetPath(key)) ?? new string[] { "Couldn't load content" };
        
    }
}
