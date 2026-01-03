using aspnet10.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aspnet10.Model
{
    [Table("books")]
    public class Book : BaseEntity
    {
        [Required]
        [Column("title", TypeName = "VARCHAR(200)")]
        [MaxLength(200)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [Column("author", TypeName = "VARCHAR(150)")]
        [MaxLength(150)]
        public string Author { get; set; } = string.Empty;

        [Required]
        [Column("price", TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }

        [Required]
        [Column("launch_date")]
        public DateTime LaunchDate { get; set; }
    }
}
