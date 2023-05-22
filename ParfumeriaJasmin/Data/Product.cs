using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParfumeriaJasmin.Data
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; } 
        public Category Categories { get; set; }
        public int TypeId { get; set; }
        public Type Types { get; set; }
        public string ImageURL { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Price { get; set; }
        public DateTime RegisterOn { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
    }
}
