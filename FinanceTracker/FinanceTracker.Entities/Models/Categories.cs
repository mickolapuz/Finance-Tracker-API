using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinanceTracker.Entities.Models
{
    [Table("TblCategory")]
    public class Categories
    {
        [Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }  
        public string Type { get; set; } 
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
