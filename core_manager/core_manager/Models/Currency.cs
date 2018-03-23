using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace core_manager.Models
{
    [Table("currencies")]
    public class Currency
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public decimal ExchangeRate { get; set; }
    }
}