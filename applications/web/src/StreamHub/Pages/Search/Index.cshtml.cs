using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace dotnet_cloud_run_hello_world.Pages
{
    public class SearchModel : PageModel
    {
        private readonly ILogger<SearchModel> _logger;

        [BindProperty(SupportsGet = true)]
        public string Query  { get; set; }

        public SearchModel(ILogger<SearchModel> logger)
        {
            _logger = logger;
        }
    }
}
