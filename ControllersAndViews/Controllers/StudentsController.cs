using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ControllersAndViews.Data;
using ControllersAndViews.Models;
using ControllersAndViews.Models.ViewModels;

using Microsoft.CodeAnalysis.CSharp.Syntax;


namespace ControllersAndViews.Controllers
{
    public class StudentsController : Controller
    {
        private readonly ControllersAndViewsContext _context;

        public StudentsController(ControllersAndViewsContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            if (_context.Student == null)
            {
                return NotFound();
            }
            else
            {
                return View(_context.Student.Include(s => s.Course).ToHashSet());
            }
        }

        public IActionResult Create()
        {
            // in create method, add a dropdown list of all course names
            HashSet<Course> courses = _context.Course.ToHashSet();

            CUStudentVM vm = new CUStudentVM(courses);
            vm.Student = new Student();

            return View(vm);
        }

        [HttpPost]
        public IActionResult Create(CUStudentVM vm)
        {
            Student student = vm.Student;
            student.CourseId = vm.SelectedCourseId;
            
                _context.Student.Add(student);
                _context.SaveChanges();
                return RedirectToAction("Index");
        }

        // UPDATE
        public IActionResult Edit(Guid? id)
        {
            if (id == null || _context.Student == null || _context.Course == null)
            {
                return NotFound();
            }

            Student student = _context.Student.Find(id);

            if (student == null)
            {
                return NotFound();
            }


            CUStudentVM vm = new CUStudentVM(_context.Course.ToHashSet());
            vm.SelectedCourseId = student.CourseId;
            vm.Student = student;
            return View(vm);
        }

        [HttpPost]
        public IActionResult Edit(CUStudentVM vm)
        {
            Student student = vm.Student;
            student.CourseId = vm.SelectedCourseId;

            
                _context.Student.Update(student);
                _context.SaveChanges();
                return RedirectToAction("Index");
            
        }

        //delete
        public IActionResult Delete(Guid? id)
        {
            if (id == null || _context.Student == null)
            {
                return NotFound();
            }

            var student = _context.Student.Find(id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid id)
        {
            var student = _context.Student.Find(id);
            if (student != null)
            {
                _context.Student.Remove(student);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

    }
}