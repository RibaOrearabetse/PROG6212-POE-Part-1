using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contract_Monthly_Claim_System__CMCS_.Models
{
    public class SupportingDocument
    {
        [Key]
        public int DocumentID { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public DateTime UploadDate { get; set; }

        [ForeignKey("Claim")]
        public int ClaimID { get; set; }
        public virtual Claim Claim { get; set; }
    }
}
