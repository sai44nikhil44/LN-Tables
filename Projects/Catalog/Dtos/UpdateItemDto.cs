namespace Catalog.Dtos
{
    public record UpdateItemDto
    {
        public string Name { get; init; }
        public decimal Price { get; init; }
    }
}