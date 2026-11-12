namespace GymWebApp.Models
{
    public class ClassSession
    {
        public int Id { get; set; }

        public int FitnessClassId { get; set; }
        public FitnessClass? FitnessClass { get; set; }

        public DateTime StartTime {  get; set; }
    }
}
