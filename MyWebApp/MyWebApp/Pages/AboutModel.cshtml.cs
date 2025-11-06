using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyWebApp.Pages
{
    public class AboutModelModel : PageModel
    {

        public string Message { get; private set; }

        [BindProperty]
        public string Name { get; set; }

        public void OnGet()
        {
            Message = "Diese Nachricht kommt aus unsere Code-Behind-Datei! Wow!";
        }

        public void OnPost()
        {

        }
    }
}
