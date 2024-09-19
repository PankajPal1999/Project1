using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Project1.Comman;
using Project1.Entity.Common;

namespace Project1.Entity.Model.Application
{
    public class ApplicationUser: BaseEnitity,IApiResultModel
    {
  
        [Required]
        public string UserName { get; set; }

        public string? NormalizedUserName { get; set; }
        [Required]
        public string Email { get; set; }

        public string? NormalizedEmail { get; set; }

        public bool EmailConfirmed { get; set; }

        [NotMapped]
        [Column("password")]
        public string? Password { get; set; }
        public string? PasswordHash { get; set; }
        public string? PhoneNumber { get; set; }
        public string? OTP { get; set; }

        public DateTime? OTPVerifiedTime { get; set; }
        public DateTime? LastLoginTime { get; set; }
        public bool Status { get; set; }
        public string? ImagePath { get; set; }
    }
}
