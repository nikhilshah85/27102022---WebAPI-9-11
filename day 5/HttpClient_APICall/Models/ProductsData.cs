namespace HttpClient_APICall.Models
{
    public class ProductsData
    {

        public int pId { get; set; }
        public string pName { get; set; }

        public string pCategory { get; set; }
        public double pPrice { get; set; }
        public bool pIsInStock { get; set; }

        List<ProductsData> pData = new List<ProductsData>();

        public List<ProductsData> GetProductData()
        {


            string url = "https://localhost:7202/api/Products/plist";

            HttpClient _HClient = new HttpClient();
            _HClient.DefaultRequestHeaders.Accept.Clear(); //clear the default format
            _HClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            var call = _HClient.GetAsync(url);

            if (call.Result.IsSuccessStatusCode)
            {
                var data = call.Result.Content.ReadAsAsync<List<ProductsData>>();
                call.Wait();
                pData = data.Result;
                return pData;
            }
            else
            {
                throw new Exception("Call failed, please contact Admin");
            }

        }
    }
}
