using repositoryPattern_demo.Model.Repository;
namespace repositoryPattern_demo.Model.MongoDB
{
    public class MongoDBProducts : IProductRepository
    {
        static List<ProductsModel> pList = new List<ProductsModel>()
        {
            new ProductsModel(){ pId=101, pName="Mongo 1", pCategory="Mongo", pIsIsStock=true, pPrice=20},
            new ProductsModel(){ pId=102, pName="Mongo 2", pCategory="Mongo", pIsIsStock=true, pPrice=20},
            new ProductsModel(){ pId=103, pName="Mongo 3", pCategory="Mongo", pIsIsStock=true, pPrice=20},
            new ProductsModel(){ pId=104, pName="Mongo 4", pCategory="Mongo", pIsIsStock=true, pPrice=20},
        };

        public string AddProduct(ProductsModel pObj)
        {
            pList.Add(pObj);
            return "Product Added To Mongo";
        }

        public string DeleteProduct(int pId)
        {

            pList.Remove(pList.Find(p => p.pId == pId));
            return "Product Deleted from Mongo";
        }

        public List<ProductsModel> GetAllProducts()
        {
            return pList;
        }

        public ProductsModel GetProductById(int id)
        {
            return pList.Find(p => p.pId == id);
        }

        public string UpdateProduct(ProductsModel pObjUpdates)
        {
            return "Product Updated in Mongo";
        }
    }
}
