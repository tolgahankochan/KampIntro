using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product //ENTITY
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public string ProductName { get; set; }
        //Ürün birim fiyatı
        public double UnitPrice { get; set; }
        //Ürün stok miktarrı
        public int UnitInStock { get; set; }

    }
}
