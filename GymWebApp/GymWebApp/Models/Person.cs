using System.ComponentModel.DataAnnotations;

namespace GymWebApp.Models
{
    public abstract class Person
    {
        public int Id { get; set; }
        
        [Display(Name="Full Name")]
        public string FullName { get; set; } = "";

        [Display(Name ="Phone Number")]
        public string PhoneNumber { get; set; } = "";
    }
}
