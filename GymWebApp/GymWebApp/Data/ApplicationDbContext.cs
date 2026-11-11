using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GymWebApp.Models;

namespace GymWebApp.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext(options)
    {
        public DbSet<MembershipPlan> MembershipPlans { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
    }
}
