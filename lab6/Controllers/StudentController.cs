using Microsoft.AspNetCore.Mvc;
using lab6.Data;
using lab6.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace lab6.Controllers
{
    public class StudentController : Controller
    {
        // The primary constructor injects the context directly
        public StudentController(StudentContext context) => _context = context;

        private StudentContext _context { get; }

        public async Task<IActionResult> Index()
        {
            var students = await _context.Students.ToListAsync();
            return View(students);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Add(student);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }
    }
}
