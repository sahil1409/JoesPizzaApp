using JoesPizza.Entitites;
using JoesPizza.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JoesPizza.Pages
{
    public class IndexModel : PageModel
    {
        public List<Product> Products;

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            ProductModel productModel = new ProductModel();
            Products = productModel.findAll();
        }
    }
}