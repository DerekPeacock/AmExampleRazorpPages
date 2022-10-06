using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AmExampleRazorpPages.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string Fullname { get; set; }
        [BindProperty]
        public string Email { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Fullname = "Derek Peacock";
        }

        public void OnPost()
        {

        }
    }
}