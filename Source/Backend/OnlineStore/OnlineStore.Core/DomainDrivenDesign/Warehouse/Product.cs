using System;
using System.Collections.ObjectModel;
using OnlineStore.Core.DomainDrivenDesign.Sales;

namespace OnlineStore.Core.DomainDrivenDesign.Warehouse
{
    public class Product : IAuditableEntity
    {
        public Product()
        {
        }

        public Product(int? productID)
        {
            ProductID = productID;
        }

        public int? ProductID { get; set; }

        public string ProductName { get; set; }

        public int? ProductCategoryID { get; set; }

        public decimal? UnitPrice { get; set; }

        public string Description { get; set; }

        public bool? Discontinued { get; set; }

        public int? Stocks { get; set; }

        public string CreationUser { get; set; }

        public DateTime? CreationDateTime { get; set; }

        public string LastUpdateUser { get; set; }

        public DateTime? LastUpdateDateTime { get; set; }

        public byte[] Timestamp { get; set; }

        public ProductCategory ProductCategoryFk { get; set; }

        public Collection<ProductInventory> ProductInventories { get; set; }

        public Collection<OrderDetail> OrderDetails { get; set; }
    }
}
