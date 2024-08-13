using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    [Table("Customer")]
    public class Customer : BaseEntity
    {
        public Customer(int id) : base(id) { }

        public int PersonId { get; set; }
        public int DiscountValue { get; set; }

        public Person Person { get; set; }
        public ICollection<Receipt> Receipts { get; set; }
    }
}
