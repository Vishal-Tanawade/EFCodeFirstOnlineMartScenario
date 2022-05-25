using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel; // CLASS
using System.ComponentModel.DataAnnotations; // VALIDATION
using System.ComponentModel.DataAnnotations.Schema; // FOREIGN KEY AND IDENTITY COLUMN
namespace EFCodeFirstOnlineMartScenario.Model
{
    internal class Customer
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerId { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 9)]
        [RegularExpression("^[A-Z]{4,10} [A-Z]{4,10}$")] // ABHISHEK SHARMA
        public string CustomerName { get; set; }
        [Required]
        [EmailAddress]
        public string CustomerEmail { get; set; }
        [Required]
        public string CustomerContact { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
    }
}
