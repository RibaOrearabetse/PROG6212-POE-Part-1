using System.ComponentModel.DataAnnotations;

namespace Contract_Monthly_Claim_System__CMCS_.Models
{
    public class Role
    {
        [Key]
        public int RoleID { get; set; }
        public string RoleName { get; set; }

        // Navigation property
        public virtual ICollection<User> Users { get; set; }
    }
}
