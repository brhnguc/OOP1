using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //özellik barındıran bir class
    class Product //Product,Entity gibi isimler veririz bu tip(özellik classı) classlara
    {
        public int Id { get; set; }
        public int CategoryId { get; set; } //referans anahtarları (foreign key gibi bişe dedi) böyle ikinci sıraya yazarız
        public string ProductName { get; set; }//ürün ismi
        public double UnitPrice { get; set; }//ürün fiyatı
        public int UnitInStock { get; set; }//stok adedi


        //CRUD create read update delete
    }
}
