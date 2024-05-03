namespace DependencyInversion.Abstraction;

public interface IChore
{
    public IPerson Owner { get; set; }
    public string Title { get; set; }
    public double Duration { get; set; }
    public void PerformTask(double time);
    public void CompleteTask();
}
