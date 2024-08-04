namespace Domain.Entities
{
    public class Exercise
    {
        private Exercise() { }
        public Exercise(int id, string name, string preparation, string execution, string tips)
        {
            Id = id;
            Name = name;
            Preparation = preparation;
            Execution = execution;
            Tips = tips;
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Preparation { get; set; } = null!;
        public string Execution { get; set; } = null!;
        public string Tips { get; set; } = null!;
    }
}
