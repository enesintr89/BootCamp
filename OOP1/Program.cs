namespace OOP0
{
    public class Program
    {

        public static void Main(String[] args)
        {
            Product product1 = new Product();

            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock= 10;

            Product product2 = new Product { Id = 2, CategoryId = 3, ProductName ="Kalem",UnitsInStock= 10,UnitPrice=35 };
            
            ProductManager productManager= new ProductManager();
            productManager.Add(product1);
 
        }
    }








}



