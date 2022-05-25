using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;// BELOW NAME SPACES , YOU MUST TO ADD ENTITY FRAME PACKAGE
using System.ComponentModel.DataAnnotations; // CLASS | MODEL VALIDATION
using System.ComponentModel.DataAnnotations.Schema; // TABLE CREATION 
//Component : one of several parts of which something is made
//Model : A copy of something that is usually smaller than the real thing



namespace EFCodeFirstOnlineMartScenario.Model
{
    internal class Category
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }
        [Required]
        public string CategoryType { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
