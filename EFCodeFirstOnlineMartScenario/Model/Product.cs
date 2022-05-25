using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EFCodeFirstOnlineMartScenario.Model
{
    internal class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { get; set; }
        [Required]
        [ForeignKey("Supplier")] //TABLE NAME 
        public int SupplierId { get; set; }
        [Required]
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public decimal ProductPrice { get; set; }
        [Required]
        public int ProductQty { get; set; }
        [Required]
        public virtual Supplier Supplier { get; set; }
        public virtual Category Category { get; set; }

        public virtual ICollection<Cart> Carts { get; set; }

    }
}
