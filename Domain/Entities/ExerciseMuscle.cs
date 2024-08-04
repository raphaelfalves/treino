namespace Domain.Entities;

public class ExerciseMuscle
{
    private ExerciseMuscle() { }
    public ExerciseMuscle(int exerciseId, int muscleId)
    {
        ExerciseId = exerciseId;
        MuscleId = muscleId;
    }

    public int ExerciseId { get; set; }
    public int MuscleId { get; set; }
}
