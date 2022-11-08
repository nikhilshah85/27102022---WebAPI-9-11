namespace DI_Demo
{
    public class Products
    {

        public int pId { get; set; }
        public string pName { get; set; }
        public string pCategory { get; set; }
        public bool pIsInStock { get; set; }
        public int pPrice { get; set; }

        static List<Products> pList = new List<Products>()
        {
            new Products(){ pId=101, pName="Pepsi", pCategory="Cold-Drink", pIsInStock=true, pPrice=50},
            new Products(){ pId=102, pName="Pepsi", pCategory="Cold-Drink", pIsInStock=true, pPrice=50},
            new Products(){ pId=103, pName="Pepsi", pCategory="Cold-Drink", pIsInStock=true, pPrice=50},
            new Products(){ pId=104, pName="Pepsi", pCategory="Cold-Drink", pIsInStock=true, pPrice=50},
            new Products(){ pId=105, pName="Pepsi", pCategory="Cold-Drink", pIsInStock=true, pPrice=50},
        };

        public List<Products> GetAllProducts()
        {
            return pList;
        }
    }
}
