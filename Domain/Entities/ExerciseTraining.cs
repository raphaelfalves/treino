namespace Domain.Entities;

public class ExerciseTraining
{
    private ExerciseTraining() { }

    public ExerciseTraining(int id, int exerciseId, int trainingId)
    {
        Id = id;
        ExerciseId = exerciseId;
        TrainingId = trainingId;
    }

    public int Id { get; set; }
    public int ExerciseId { get; set; }
    public int TrainingId { get; set; }
    public int RestBetweenSets { get; set; }
    public List<Set> Sets { get; set; } = [];
    public Exercise? Exercise { get; set; }
}
