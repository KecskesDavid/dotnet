using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_b.Model
{
    public class DrinkProduct
    {
        public int AnnualSales { get; set; }
        public MaterialType Material { get; set; }
        public string PackageType { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }

        public DrinkProduct(int annualSales, MaterialType material, string packageType, string productId, string productName, int quantity)
        {
            AnnualSales = annualSales;
            Material = material;
            PackageType = packageType;
            ProductId = productId;
            ProductName = productName;
            Quantity = quantity;
        }

        public DrinkProduct()
        {
        }
    }

    public enum MaterialType
    {
        Granules, Leaf, Liquid, Paste, Powder, Other,
    }
}
