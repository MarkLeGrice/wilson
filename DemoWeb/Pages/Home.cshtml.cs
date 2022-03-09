using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DemoWeb.Pages
{
    public class HomeModel : PageModel 
    {
        public string Greeting { get; set; }

        public void OnGet()
        {
            this.Greeting = "Hello i am injected from the controller!";
        }
    }
}
