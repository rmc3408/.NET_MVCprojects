namespace api.Entities.DTO
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public long Price { get; set; }
    }
}
