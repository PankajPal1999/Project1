using Project1.Entity.Common;
using System.ComponentModel.DataAnnotations;

namespace Project1.Entity.Model.UserRole
{

    public class UserRole : BaseEnitity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public long RoleTypeId { get; set; }
        //public long? CompanyId { get; set; }
        //public Guid? RoleTypeId { get; set; }
        public long? CompanyId { get; set; }
        public int OrderNo { get; set; }
        public bool IsSendSMS { get; set; }
        public bool IsActive { get; set; }
        public bool IsSuperAdmin { get; set; } = false;
    }
}

