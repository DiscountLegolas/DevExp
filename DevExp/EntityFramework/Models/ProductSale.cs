using DevExp.EntityFramework.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevExp.EntityFramework.Models
{
    public class ProductSale
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int BuyedUnitAmount { get; set; }
        public DateTime TransictionDate { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }

    }
}
