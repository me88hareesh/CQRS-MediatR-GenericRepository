namespace CQRSMediatRExample
{
    public class FakeDataStore
    {
        private static List<Product> _products;
        public FakeDataStore()
        {
            _products = new List<Product>()
            {
                new Product{Id = 1, Name="Test product 1"},
                new Product{Id = 1, Name="Test product 1"},
                new Product{Id = 1, Name="Test product 1"}
            };
        }

        public async Task AddProduct(Product product)
        {
            _products.Add(product);
            await Task.CompletedTask;
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
           return await Task.FromResult(_products);
        }
    }
}
