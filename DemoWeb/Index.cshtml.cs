using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoWeb
{
    public class IndexModel : PageModel
    {
        public string Greeting { get; private set; }

        public void OnGet()
        {
            this.Greeting = "Hello i am injected from the controller!";
        }
    }
}
