namespace repositoryPattern_demo.Model.Repository
{
    public interface IProductRepository
    {
        public List<ProductsModel> GetAllProducts();

        public ProductsModel GetProductById(int id);

        public string AddProduct(ProductsModel pObj);

        public string DeleteProduct(int pId);
        public string UpdateProduct(ProductsModel pObjUpdates);

    }
}
