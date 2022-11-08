using repositoryPattern_demo.Model.Repository;
namespace repositoryPattern_demo.Model.Oracle
{
    public class OracleProducts : IProductRepository
    {
        static List<ProductsModel> pList = new List<ProductsModel>()
        {
            new ProductsModel(){ pId=101, pName="Oracle 1", pCategory="Oracle", pIsIsStock=true, pPrice=20},
            new ProductsModel(){ pId=102, pName="Oracle 2", pCategory="Oracle", pIsIsStock=true, pPrice=20},
            new ProductsModel(){ pId=103, pName="Oracle 3", pCategory="Oracle", pIsIsStock=true, pPrice=20},
            new ProductsModel(){ pId=104, pName="Oracle 4", pCategory="Oracle", pIsIsStock=true, pPrice=20},
        };

        public string AddProduct(ProductsModel pObj)
        {
            pList.Add(pObj);
            return "Product Added To Oracle";
        }

        public string DeleteProduct(int pId)
        {

            pList.Remove(pList.Find(p => p.pId == pId));
            return "Product Deleted from Oracle";
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
            return "Product Updated in Oracle";
        }
    }
}
