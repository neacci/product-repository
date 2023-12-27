public interface IProductRepository
{
    Product Create(Product product);
    Product GetById(int id);
    Product Update(Product product);
    void Delete(int id);
}
