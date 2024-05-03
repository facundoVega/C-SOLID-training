using DependencyInversion.Abstraction;

namespace DependencyInversion;

public class Factory
{
    public IPerson BuildPerson()
    {
        return new Person();
    }

    public IChore BuildChore()
    {
        return new Chore(new Logger(), new MailSender());
    }
}
