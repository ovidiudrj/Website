using System.ComponentModel.DataAnnotations.Schema;

namespace GymWebApp.Models
{
    public class MembershipPlan
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public decimal Price { get; set; }
    }
}
