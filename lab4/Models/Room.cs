using System.ComponentModel.DataAnnotations;

namespace lab4.Models
{
    public class Room
    {
        [Key]
        [Display(Name = "Room Number")]
        public int RoomNumber { get; set; }

        [Range(1, 6)]
        public int Capacity { get; set; }

        public Section Section { get; set; }
    }

    public enum Section
    {
        First,
        Second,
        Third
    }
}
