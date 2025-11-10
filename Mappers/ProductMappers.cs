using learning_api.Models;

namespace learning_api.Mappers
{
    public static class ProductMappers
    {
        public static ProductDto ToProductDto(this Product product)
        {
            return new ProductDto
            {
                ID = product.ID,
                Name = product.Name,
                Price = product.Price,
                ImageURL = product.ImageURL
            };
        }

        public static Product CreateProductDtoToEntity(this CreateProductDto productDto)
        {
            return new Product
            {
                Name = productDto.Name,
                Price = productDto.Price,
                ImageURL = productDto.ImageURL
            };
        }
    }
}