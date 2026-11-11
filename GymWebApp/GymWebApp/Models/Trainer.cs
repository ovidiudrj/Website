using System.ComponentModel.DataAnnotations;

namespace GymWebApp.Models
{
    public class Trainer 
    {
        public int Id { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; } = "";

        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; } = "";
        public string Specialization { get; set; } = "";
        public string Bio { get; set; } = "";
    }
}
