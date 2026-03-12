using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentPortal.Models;
using StudentPortal.Services;

namespace StudentPortal.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IStudentService _service;
        private readonly ICalculatorService _calculator;

        public StudentsController(IStudentService service, ICalculatorService calculator)
        {
            _service = service;
            _calculator = calculator;
        }

        // GET: Students
        public async Task<IActionResult> Index(string q = null)
        {
            var items = await _service.GetAllAsync(q);
            ViewBag.Query = q ?? "";
            return View(items);
        }

        public async Task<IActionResult> Search(string q)
        {
            var students = await _service.GetAllAsync(q);
            return Json(students);
        }



        //GET: Students/Details/5
        public async Task<IActionResult> Details(int id)
        {
            if (id <= 0) return NotFound();
            try
            {
                var student = await _service.GetByIdAsync(id);
                return View(student);
            }
            catch
            {
                return NotFound();
            }
        }

        // GET: Students/Create
        public IActionResult Create()
        {
            return View();
        }

        //// POST: Students/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Student student)
        {
            // Status and CreatedAt are not in the Create form; supply defaults
            // before ModelState is checked so validation passes.
            student.Status = "Active";
            ModelState.Remove(nameof(Student.Status));
            ModelState.Remove(nameof(Student.CreatedAt));

            if (!ModelState.IsValid)
            {
                return View(student);
            }
            try
            {
                await _service.CreateAsync(student);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception e)
            {
                ModelState.AddModelError("", e.Message);
                return View(student);
            }
        }

        // GET: Students/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            try
            {
                var student = await _service.GetByIdAsync(id);
                return View(student);
            }
            catch
            {
                return NotFound();
            }
        }

        // POST: Students/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Student student)
        {
            if (id != student.StudentId)
                return NotFound();

            if (!ModelState.IsValid)
                return View(student);

            try
            {
                await _service.UpdateAsync(id, student);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View(student);
            }
        }

        // GET: Students/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var student = await _service.GetByIdAsync(id);
                return View(student);
            }
            catch
            {
                return NotFound();
            }
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                await _service.DeleteAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return NotFound();
            }
        }

        //private bool StudentExists(int id)
        //{
        //    return _context.Students.Any(e => e.StudentId == id);
        //}
    }
}
