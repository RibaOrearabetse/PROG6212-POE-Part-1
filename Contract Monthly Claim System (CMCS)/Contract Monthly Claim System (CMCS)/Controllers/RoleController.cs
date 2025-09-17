using Contract_Monthly_Claim_System__CMCS_.Models;
using Microsoft.AspNetCore.Mvc;

namespace Contract_Monthly_Claim_System__CMCS_.Controllers
{
    public class RoleController : Controller
    {
        public IActionResult Index()
        {
            var roles = GetSampleRoles();
            return View(roles);
        }
        public IActionResult Details(int id)
        {
            var role = GetSampleRoles().FirstOrDefault(r => r.RoleID == id);
            if (role == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(role);
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Edit(int id)
        {
            var role = GetSampleRoles().FirstOrDefault(r => r.RoleID == id);
            if (role == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(role);
        }
        private List<Role> GetSampleRoles()
        {
            return new List<Role>
            {
                new Role { RoleID = 1, RoleName = "Lecturer" },
                new Role { RoleID = 2, RoleName = "Coordinator" },
                new Role { RoleID = 3, RoleName = "Manager" },
                new Role { RoleID = 4, RoleName = "Administrator" }
            };
        }
    }
}