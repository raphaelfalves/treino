namespace Domain.Entities
{
    public class Muscle
    {
        private Muscle() { }
        public Muscle(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
    }
}
