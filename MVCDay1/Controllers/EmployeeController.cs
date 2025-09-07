using Microsoft.AspNetCore.Mvc;
using MVCDay1.DAL.Database;

namespace MVCDay1.Controllers
{
	public class EmployeeController : Controller
	{
		private readonly ApplicationDbContext db;
		public EmployeeController()
		{
			db = new ApplicationDbContext();
		}
		public IActionResult GetAllEmployee()
		{
			var result = db.Employees.ToList();
			return View(result);
		}
	}
}
