using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {


            Product product1 = new Product();
            product1.ID = 1;
            product1.CategoryID = 2;
            product1.ProductName = "masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            Product product2 = new Product() { ID = 2, CategoryID = 3, ProductName = "sandalye", UnitPrice = 250, UnitInStock = 6 };


            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            
           
           




        }
    }
}
