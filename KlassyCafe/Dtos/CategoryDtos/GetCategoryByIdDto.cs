namespace KlassyCafe.Dtos.CategoryDtos
{
    public class GetCategoryByIdDto
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string ImageUrl { get; set; }
        public bool Status { get; set; }
    }
}
