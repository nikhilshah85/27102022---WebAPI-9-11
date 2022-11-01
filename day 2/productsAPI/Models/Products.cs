namespace productsAPI.Models
{
    public class Products
    {
        #region Properties
        public int pId { get; set; }
        public string pName { get; set; }

        public string pCategory { get; set; }
        public double pPrice { get; set; }
        public bool pIsInStock { get; set; }
        #endregion

        #region Data Containers
       private static List<Products> pList = new List<Products>()
        {
            new Products(){ pId =101, pName="Nike", pCategory="Shoes", pIsInStock=true, pPrice=8000},
            new Products(){ pId =102, pName="Nike", pCategory="Shoes", pIsInStock=true, pPrice=8000},
            new Products(){ pId =103, pName="Nike", pCategory="Shoes", pIsInStock=true, pPrice=8000},
            new Products(){ pId =104, pName="Nike", pCategory="Shoes", pIsInStock=true, pPrice=8000},
        };
        #endregion

        #region Get Products
        public List<Products> GetAllproducts()
        {
            return pList;
        }


        public Products GetProductById(int id)
        {
            var p = pList.Find(pr => pr.pId == id);
            if (p!= null)
            {
                return p;
            }
            throw new Exception("Product Not Found");
        }

        public List<Products> GetAvailableProduct(bool yesOrNo)
        {
            var p = pList.FindAll(pr => pr.pIsInStock == yesOrNo);
            return p;
        }
        #endregion

        #region Add, Delete and Update
        public string AddProduct(Products newProduct)
        {
            //do any type of validation before addiing the product
            pList.Add(newProduct);
            return "Product Added Succesfully";
        }

        public string DeleteProduct(int pid)
        {
            var p = pList.Find(pr => pr.pId == pid);
            if (p != null)
            {
                pList.Remove(p);
                return "Product Removed Successfully";
            }
            throw new Exception("Product Not Found");
        }

        public string EditProduct(Products changes)
        {
            var p = pList.Find(pr => pr.pId == changes.pId);
            if (p!=null)
            {
                p.pName = changes.pName;
                p.pPrice = changes.pPrice;
                p.pIsInStock = changes.pIsInStock;
                p.pCategory = changes.pCategory;
                return "Product Updated Successfully";
            }
            throw new Exception("Product Not Found");
        }

        #endregion
    }
}
