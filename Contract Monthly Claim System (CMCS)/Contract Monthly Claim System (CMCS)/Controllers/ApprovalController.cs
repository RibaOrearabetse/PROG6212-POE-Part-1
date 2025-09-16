using Microsoft.AspNetCore.Mvc;
using Contract_Monthly_Claim_System__CMCS_.Models;

namespace Contract_Monthly_Claim_System__CMCS_.Controllers
{
    public class ApprovalController : Controller
    {
        public IActionResult Index()
        {
            var approvals = GetSampleApprovals();
            return View(approvals);
        }

        public IActionResult Details(int id)
        {
            var approval = GetSampleApprovals().FirstOrDefault(a => a.ApprovalID == id);
            return View(approval);
        }

        public IActionResult ProcessApproval(int claimId)
        {
            ViewBag.ClaimID = claimId;
            return View();
        }

        private List<Approval> GetSampleApprovals()
        {
            return new List<Approval>
            {
                new Approval { ApprovalID = 1, ApprovalDate = DateTime.Now.AddDays(-3), Comments = "Approved - documentation complete", ClaimID = 2, ApproverID = 4 },
                new Approval { ApprovalID = 2, ApprovalDate = DateTime.Now.AddDays(-10), Comments = "Rejected - insufficient documentation", ClaimID = 3, ApproverID = 3 },
                new Approval { ApprovalID = 3, ApprovalDate = DateTime.Now.AddDays(-1), Comments = "Approved with conditions", ClaimID = 1, ApproverID = 4 }
            };
        }
    }
}
