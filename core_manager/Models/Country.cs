using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace core_manager.Models
{
    [Table("countries")]
    public class Country
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
    }
}