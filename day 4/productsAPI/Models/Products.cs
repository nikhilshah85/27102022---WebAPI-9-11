namespace productsAPI.Models
{
    public class Products
    {

        public int pId { get; set; }
        public string pName { get; set; }

        public string pCategory { get; set; }
        public double pPrice { get; set; }
        public bool pIsInStock { get; set; }

        static List<Products> plist = new List<Products>()
        {
            new Products(){ pId=101, pName="Pepsi", pCategory="Cold-Drink", pIsInStock=true, pPrice=50},
            new Products(){ pId=102, pName="Maggie", pCategory="Fast-Food", pIsInStock=true, pPrice=50},
            new Products(){ pId=103, pName="Sandwitch", pCategory="Fast-Food", pIsInStock=false, pPrice=50},
            new Products(){ pId=104, pName="Dell", pCategory="Electronics", pIsInStock=true, pPrice=50},
            new Products(){ pId=105, pName="IPhone", pCategory="Electronics", pIsInStock=false, pPrice=50},
        };

        public List<Products> GetAllProducts()
        {
            return plist;
        }
    }
}
