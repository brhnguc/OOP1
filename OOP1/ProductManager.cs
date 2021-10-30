using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
      //public void Add(String ad) gibi düşün korkma 
        public void Add(Product product)//Product diye sınıf oluşturup içine özelliklei yazdık ya Encapsulation yapmış olduk işte yoksa buraya uzun uzun yazaccaktık String Id, İnt stok falan filan
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");

        }

        

    }
}
