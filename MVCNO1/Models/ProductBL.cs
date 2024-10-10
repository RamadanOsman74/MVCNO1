namespace MVCNO1.Models
{
    public class ProductBL
    {
        List<Product> products= new List<Product>();
        public ProductBL()
        {
            products.Add(new Product() {Id = 1 , Name = "IPhone 1" , price = 3000767, Image = "1.png" });
            products.Add(new Product() {Id = 2 , Name = "IPhone 5" , price = 340005 , Image = "1.png" });
            products.Add(new Product() {Id = 3 , Name = "IPhone 4" , price = 304300 , Image = "2.png" });
            products.Add(new Product() {Id = 4 , Name = "IPhone 3" , price = 3000432 , Image = "2.png" });
        }

        public List<Product> GetAll()
        {
            return products;
        } 
    }
}
