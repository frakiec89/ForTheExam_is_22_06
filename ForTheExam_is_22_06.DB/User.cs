using System.ComponentModel.DataAnnotations;

// track
namespace ForTheExam_is_22_06.DB
{
    public class User
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
