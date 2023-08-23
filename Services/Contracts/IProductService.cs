using Entities.DTos;
using Entities.Models;
using Entities.RequestParamaters;

namespace Services.Contracts
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts(bool trackChanges);

        IEnumerable<Product> GetLastestProducts(int n , bool trackChanges);

        IQueryable<Product> GetAllProductsWithDetails(ProductRequestParamaters p);

        IEnumerable<Product> GetShowCaseProducts(bool trackChanges);

        Product? GetOneProduct(int id,bool trackChanges);

        void CreateProduct(ProductDtoForInsertion productDto);

        void UpdateOneProducy(ProductDtoForUpdate productDto);

        void DeleteOneProduct(int id);

        ProductDtoForUpdate GetOneProductForUpdate(int id, bool trackChanges);
    }
} 