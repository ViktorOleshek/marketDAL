using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    [Table("Product")]
    public class Product : BaseEntity
    {
        public Product(int id) : base(id) { }

        [Column("ProductCategoryId")]
        [ForeignKey(nameof(Category))]
        public int ProductCategoryId { get; set; }

        [Column("ProductName")]
        public string ProductName { get; set; }

        [Column("Price")]
        public decimal Price { get; set; }

        public ProductCategory Category { get; set; }
        public ICollection<ReceiptDetail> ReceiptDetails { get; set; }
    }
}
