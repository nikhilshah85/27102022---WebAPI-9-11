﻿using repositoryPattern_demo.Model.Repository;

namespace repositoryPattern_demo.Model.InMemoryCollection
{
    public class ProductsCollection : IProductRepository
    {

        static List<ProductsModel> pList = new List<ProductsModel>()
        {
            new ProductsModel(){ pId=101, pName="Collection 1", pCategory="Collection", pIsIsStock=true, pPrice=20},
            new ProductsModel(){ pId=102, pName="Collection 2", pCategory="Collection", pIsIsStock=true, pPrice=20},
            new ProductsModel(){ pId=103, pName="Collection 3", pCategory="Collection", pIsIsStock=true, pPrice=20},
            new ProductsModel(){ pId=104, pName="Collection 4", pCategory="Collection", pIsIsStock=true, pPrice=20},
        };

        public string AddProduct(ProductsModel pObj)
        {
            pList.Add(pObj);
            return "Product Added To Collection";
        }

        public string DeleteProduct(int pId)
        {

            pList.Remove(pList.Find(p => p.pId == pId));
            return "Product Deleted from Collection";
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
            return "Product Updated in Collection";
        }
    }
}
