using Microsoft.AspNetCore.Mvc;
using Contract_Monthly_Claim_System__CMCS_.Models;

namespace Contract_Monthly_Claim_System__CMCS_.Controllers
{
    public class SupportingDocumentController : Controller
    {
        public IActionResult Index()
        {
            var documents = GetSampleDocuments();
            return View(documents);
        }
        public IActionResult Details(int id)
        {
            var document = GetSampleDocuments().FirstOrDefault(d => d.DocumentID == id);
            if (document == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(document);
        }
        public IActionResult Upload(int claimId)
        {
            ViewBag.ClaimID = claimId;
            return View();
        }
        private List<SupportingDocument> GetSampleDocuments()
        {
            return new List<SupportingDocument>
            {
                new SupportingDocument { DocumentID = 1, FileName = "timesheet_jan.pdf", FilePath = "/documents/timesheet_jan.pdf", UploadDate = DateTime.Now.AddDays(-5), ClaimID = 1 },
                new SupportingDocument { DocumentID = 2, FileName = "contract_agreement.pdf", FilePath = "/documents/contract_agreement.pdf", UploadDate = DateTime.Now.AddDays(-12), ClaimID = 2 },
                new SupportingDocument { DocumentID = 3, FileName = "work_log.xlsx", FilePath = "/documents/work_log.xlsx", UploadDate = DateTime.Now.AddDays(-18), ClaimID = 3 },
                new SupportingDocument { DocumentID = 4, FileName = "invoice_feb.pdf", FilePath = "/documents/invoice_feb.pdf", UploadDate = DateTime.Now.AddDays(-1), ClaimID = 4 }
            };
        }
    }
}