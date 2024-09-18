using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Project1.Entity.Common
{
    public class BaseEnitity
    {

        [Key]
        [Column("Id")]
        //public long Id { get; set; }
        public long Id { get; set; }

        //public long CreatedBy { get; set; } = 0;
        public long CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        //public long? ModifiedBy { get; set; }
        public long? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public bool Status { get; set; } = true;
    }
}
