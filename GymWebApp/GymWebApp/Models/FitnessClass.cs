
namespace GymWebApp.Models
{
    public class FitnessClass
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int Duration { get; set; }
        public int Capacity { get; set; }


        public int TrainerId {  get; set; }
        public Trainer?Trainer { get; set; }
    }
}
