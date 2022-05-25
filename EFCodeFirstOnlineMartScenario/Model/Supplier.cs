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
    internal class Supplier
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SupplierId { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 9)]
        [RegularExpression("^[A-Z]{4,10} [A-Z]{4,10}$")] // ABHISHEK SHARMA
        public string SupplierName { get; set; }
        [Required]
        //(372) 587-2335
        [RegularExpression(@"^\([1-9]{3}\) [1-9]{3}-[1-9]{4}$")] // (666) 663-4518
        public string SupplierContact { get; set; }
        [Required]
        public string SupplierCity { get; set; }
        //NAVIGATION PROPERTY
        public virtual ICollection<Product> Products { get; set; }

    }
}
