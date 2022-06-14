using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DevExp.EntityFramework.Models;

namespace DevExp.EntityFramework.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        public float UnitPrice { get; set; }
        public virtual ICollection<ProductSale> Sales { get; set; }

    }
}
