using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ControllersAndViews.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Course Title")]
        [MaxLength(100)]
        public string Title { get; set; }
        public HashSet<Student> EnrolledStudents = new HashSet<Student>();
    }
}
