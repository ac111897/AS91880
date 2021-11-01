using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace AS91880.Services
{
    public class PrivacyService
    {
        private readonly string content = null;
        private ILogger<PrivacyService> _logger;
        public PrivacyService(IConfiguration config, ILogger<PrivacyService> logger)
        {
            _logger = logger;
            _logger.LogInformation($"Got privacy at {Directory.GetCurrentDirectory() + config["privacy-path"]}");
            content = File.ReadAllText(Directory.GetCurrentDirectory() + config["privacy-path"]);
        }
        public string Content
        {
            get
            {

                return content
                    ??
#if (DEBUG)
                    "Couldn't find content";
#else
                    string.Empty;
#endif


            }
        }
    }
}
