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
    /// Retrieves privacy policy from ~/Content folder, if not found displays an error msg
    /// </summary>
    public class PrivacyService
    {
        private readonly string[] content = null;
        private readonly ILogger<PrivacyService> _logger;
        private readonly IConfiguration _config;
        private string Path => $"{Directory.GetCurrentDirectory()}{_config["privacy-path"]}";
        public PrivacyService(IConfiguration config, ILogger<PrivacyService> logger)
        {
            _config = config;
            _logger = logger;
            _logger.LogInformation("Loaded privacy message located at {Path}\n at {Date}", Path, DateTime.Now);
            content = File.ReadAllLines(Path);
        }
        public string[] Content
        {
            get
            {

                return content
                    ??
#if (DEBUG)
                    new[] { $"Couldn't find content at {Path}" };
#else
                    new[] { "Couldn't find content"};
#endif


            }
        }
    }
}
