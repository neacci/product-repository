public class ProductRepository : IProductRepository
{
    private readonly List<Product> _products = new List<Product>();

    public Product Create(Product product)
    {
        _products.Add(product);
        return product;
    }

    public Product GetById(int id)
    {
        return _products.FirstOrDefault(p => p.Id == id);
    }

    public Product Update(Product product)
    {
        var existingProduct = GetById(product.Id);
        if (existingProduct == null) throw new NotFound("Product not found");
        
        existingProduct.Name = product.Name;
        existingProduct.Price = product.Price;
        
        return existingProduct;
    }

    public void Delete(int id)
    {
        var product = GetById(id);
        if (product == null) throw new NotFound("Product not found");
        
        _products.Remove(product);
    }
}
