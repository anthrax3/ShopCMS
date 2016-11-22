namespace Domain.ShopCMS.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string MetaTagTitle { get; set; }
        public string MetaTagDescription { get; set; }
        public string MetaTagKeywords { get; set; }

    }
}