namespace KlassyCafe.Dtos.ProductDtos
{
    public class ResultProductPreviewDto
    {
        public int ProductId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public bool Feature { get; set; }
    }
}
