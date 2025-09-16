using Microsoft.AspNetCore.Mvc;
using Contract_Monthly_Claim_System__CMCS_.Models;

namespace Contract_Monthly_Claim_System__CMCS_.Controllers
{
    public class ClaimController : Controller
    {
        public IActionResult Index()
        {
            var claims = GetSampleClaims();
            return View(claims);
        }

        public IActionResult Details(int id)
        {
            var claim = GetSampleClaims().FirstOrDefault(c => c.ClaimID == id);
            return View(claim);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            var claim = GetSampleClaims().FirstOrDefault(c => c.ClaimID == id);
            return View(claim);
        }

        public IActionResult Approve(int id)
        {
            var claim = GetSampleClaims().FirstOrDefault(c => c.ClaimID == id);
            return View(claim);
        }

        private List<Claim> GetSampleClaims()
        {
            return new List<Claim>
            {
                new Claim { ClaimID = 1, ClaimDate = DateTime.Now.AddDays(-7), ClaimStatus = "Pending", HoursWorked = 40, HourlyRate = 25.00m, TotalAmount = 1000.00m, SubmissionDate = DateTime.Now.AddDays(-5), UserID = 1 },
                new Claim { ClaimID = 2, ClaimDate = DateTime.Now.AddDays(-14), ClaimStatus = "Approved", HoursWorked = 35, HourlyRate = 30.00m, TotalAmount = 1050.00m, SubmissionDate = DateTime.Now.AddDays(-12), UserID = 2 },
                new Claim { ClaimID = 3, ClaimDate = DateTime.Now.AddDays(-21), ClaimStatus = "Rejected", HoursWorked = 20, HourlyRate = 28.00m, TotalAmount = 560.00m, SubmissionDate = DateTime.Now.AddDays(-18), UserID = 3 },
                new Claim { ClaimID = 4, ClaimDate = DateTime.Now.AddDays(-3), ClaimStatus = "Pending", HoursWorked = 45, HourlyRate = 32.00m, TotalAmount = 1440.00m, SubmissionDate = DateTime.Now.AddDays(-1), UserID = 1 }
            };
        }
    }
}
