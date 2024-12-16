using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SampleRazorPage.Models;

namespace SampleRazorPage.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public CarouselViewModel carouselViewModel { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public IActionResult OnGet()
        {
            carouselViewModel = new CarouselViewModel
            {
                Images = new List<ImageModel>
                {
                    new ImageModel { Url = "https://5.imimg.com/data5/SELLER/Default/2023/3/296898052/GA/YV/SE/50163139/fall-ceiling-designing-services.jpg", AltText = "Image 1 Description", Title = "Hall Ceiling", Description = "" },
                    new ImageModel { Url = "https://i.pinimg.com/564x/05/92/da/0592da6fe00af95f1a660404264940e8.jpg", AltText = "Image 2 Description", Title = "Living Room Ceiling", Description = ""  },
                    new ImageModel { Url = "https://www.montdorinterior.com/wp-content/uploads/2024/09/5-best-false-ceiling-designs-bedrooms.jpg", AltText = "Image 3 Description", Title = "Bedroom Ceiling", Description = ""  }
                }
            };

            return Page();
        }
    }

}
