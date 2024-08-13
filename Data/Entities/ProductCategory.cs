using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    [Table("ProductCategory")]
    public class ProductCategory : BaseEntity
    {
        public ProductCategory(int id) : base(id) { }

        [Column("CaregoryName")]
        public string CategoryName { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
