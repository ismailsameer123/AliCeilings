namespace SampleRazorPage.Models
{
    public class ImageModel
    {
        public string Url { get; set; }
        public string AltText { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }

    public class CarouselViewModel
    {
        public List<ImageModel> Images { get; set; }
    }
}
