namespace Domain.Entities;

public class Set
{
    private Set() {}
    public Set(int id, int exerciseTrainingId)
    {
        Id = id;
        ExerciseTrainingId = exerciseTrainingId;
    }

    public int Id { get; set; }
    public int ExerciseTrainingId { get; set; }
    public int Repetition { get; set; }
    public int Weight { get; set; }
}