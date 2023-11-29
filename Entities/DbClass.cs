using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task1.Entities
{
    public class DbClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Field1 { get; set; }
        public int Field2 { get; set; }
        public DateTimeOffset Field3 { get; set; }
    }
}
