using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;

namespace StartMeWeb.Pages
{
    public class IndexModel : PageModel
    {
        public string ServerName { get; }
        public string OSVersion { get; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            ServerName = System.Environment.MachineName;
            OSVersion = System.Environment.OSVersion.ToString();
        }

        public void OnGet()
        {
            
        }
    }
}
