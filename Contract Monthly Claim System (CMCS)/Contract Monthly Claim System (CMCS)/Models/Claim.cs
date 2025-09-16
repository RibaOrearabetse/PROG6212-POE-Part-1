using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contract_Monthly_Claim_System__CMCS_.Models
{
    public class Claim
    {
        [Key]
        public int ClaimID { get; set; }
        public DateTime ClaimDate { get; set; }
        public string ClaimStatus { get; set; }
        public decimal HoursWorked { get; set; }
        public decimal HourlyRate { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime SubmissionDate { get; set; }

        [ForeignKey("User")]
        public int UserID { get; set; }
        public virtual User User { get; set; }

        // Navigation properties
        public virtual ICollection<SupportingDocument> SupportingDocuments { get; set; }
        public virtual ICollection<Approval> Approvals { get; set; }
    }
}
