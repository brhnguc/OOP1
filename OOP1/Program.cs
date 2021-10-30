using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            //Bu şekilde de yazılabilir
            Product product2 = new Product {Id=2,CategoryId=5,UnitInStock=5,
                ProductName="Kalem", UnitPrice=35};

            //PascalCase   //camelCase
            ProductManager productManager = new ProductManager(); //ProductManager türünde productManager adında bir ** tanımladık
            //String productManager gibi düşün string yerine ProductManager sınıfını kullanıyoruz

            productManager.Add(product1);

        }
    }
}
