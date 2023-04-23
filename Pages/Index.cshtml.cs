using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ProductManager.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Manager.Instance.RemoveProduct();
            GC.Collect();
        }

        public IActionResult OnPost()
        {
            if (Request.Form.ContainsKey("AddProduct"))
            {
                string name = Request.Form["name"];
                int year = int.Parse(Request.Form["year"]);
                int month = int.Parse(Request.Form["month"]);
                int day = int.Parse(Request.Form["day"]);

                Manager.Instance.AddProduct(new Product(name, new DateTime(year, month, day)));
            }
            else if (Request.Form.ContainsKey("RemoveProduct"))
            {
                Manager.Instance.RemoveProduct(Request.Form["RemoveProduct"],
                    Request.Form["year"],
                    Request.Form["month"],
                    Request.Form["day"]);
            }

            return RedirectToPage();
        }

    }
}