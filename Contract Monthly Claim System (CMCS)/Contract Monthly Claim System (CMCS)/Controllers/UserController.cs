using Contract_Monthly_Claim_System__CMCS_.Models;
using Microsoft.AspNetCore.Mvc;

namespace Contract_Monthly_Claim_System__CMCS_.Controllers
{
    public class UserController : Controller
    {
        // GET: User/Index - Shows the list of users
        public IActionResult Index()
        {
            var users = GetSampleUsers();
            return View(users);
        }

        // GET: User/Details/5 - Shows details for a single user
        public IActionResult Details(int id)
        {
            var user = GetSampleUsers().FirstOrDefault(u => u.UserID == id);
            if (user == null)
            {
                // For a non-functional prototype, simply redirect to index if not found
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: User/Create - Shows the empty create form
        public IActionResult Create()
        {
            ViewBag.Roles = GetSampleRoles();
            return View();
        }

        // GET: User/Edit/5 - Shows the edit form pre-populated with user data
        public IActionResult Edit(int id)
        {
            var user = GetSampleUsers().FirstOrDefault(u => u.UserID == id);
            if (user == null)
            {
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Roles = GetSampleRoles();
            return View(user);
        }

        private List<User> GetSampleUsers()
        {
            return new List<User>
            {
                new User { UserID = 1, FirstName = "Sizwe", LastName = "Mahlangu", Email = "sizwe.m@university.edu", ContactNumber = "123-456-7890", RoleID = 1 },
                new User { UserID = 2, FirstName = "Khumo", LastName = "Thato", Email = "khumo.t@university.edu", ContactNumber = "098-765-4321", RoleID = 2 },
                new User { UserID = 3, FirstName = "Mike", LastName = "Johnson", Email = "mike.johnson@university.edu", ContactNumber = "555-123-4567", RoleID = 1 },
                new User { UserID = 4, FirstName = "Sarah", LastName = "Williams", Email = "sarah.williams@university.edu", ContactNumber = "444-987-6543", RoleID = 3 }
            };
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