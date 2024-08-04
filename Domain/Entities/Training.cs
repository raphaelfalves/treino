namespace Domain.Entities;

public class Training
{
    private Training() { }

    public Training(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public List<ExerciseTraining> ExerciseTraining { get; set; } = [];
}
