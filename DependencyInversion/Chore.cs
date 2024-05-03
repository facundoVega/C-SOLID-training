using DependencyInversion.Abstraction;
using DependencyInversion.Abstractions;

namespace DependencyInversion;

public class Chore :IChore
{
    private readonly ILogger _logger;
    private readonly ISender _sender;
    public Chore(ILogger logger, ISender sender)
    {
        _logger = logger;
        _sender = sender;
    }
    public IPerson Owner { get; set; }

    public string Title { get; set; }
    public double Duration { get; set; } = 5.0;

    public void PerformTask(double time)
    {
        Duration -= time;
        _logger.Log($":CHORE: { Title} has { Duration } hs pending.");
    }

    public void CompleteTask()
    {
        Duration = 0;
        _logger.Log($":CHORE: {Title} has been completed.");
        _sender.Send($"TASK: { Title} COMPLETED!" );
    }
}
