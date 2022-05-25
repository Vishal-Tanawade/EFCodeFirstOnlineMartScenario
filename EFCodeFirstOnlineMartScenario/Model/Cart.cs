using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstOnlineMartScenario.Model
{
    //[Table("tblCart")]
    class Cart
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CartId { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        [ForeignKey("Product")]
        public int ProductID { get; set; }
        [Required]
        public decimal ProductPrice { get; set; }
        [Required]
        public int ProductQTY { get; set; }
        [Required]
        public decimal TotalAmout { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }

    }
}
