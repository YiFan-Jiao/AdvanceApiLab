using System;
using System.ComponentModel;
using Microsoft.Build.Framework;

namespace ControllersAndViews.Models
{
    public class Student
    {
        [DisplayName("Student Number")]
        public Guid Id { get; set; }

        [Required]
        public string FullName { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; } = null!;
    }
}
