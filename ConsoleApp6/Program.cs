public sealed class ConstructionCompany
{
    private static ConstructionCompany instance = null;
    private static readonly object padlock = new object();

    private ConstructionCompany() { }

    public static ConstructionCompany Instance
    {
        get
        {
            lock (padlock)
            {
                if (instance == null)
                {
                    instance = new ConstructionCompany();
                }
                return instance;
            }
        }
    }

    public void StartConstruction()
    {
        Console.WriteLine("Construction started.");
    }

    public void CompleteConstruction()
    {
        Console.WriteLine("Construction completed.");
    }
}

public interface IConstruction
{
    void Build();
}

public class Construction : IConstruction
{
    public void Build()
    {
        Console.WriteLine("Building a new house.");
    }
}

public abstract class ConstructionDecorator : IConstruction
{
    protected IConstruction construction;

    public ConstructionDecorator(IConstruction construction)
    {
        this.construction = construction;
    }

    public virtual void Build()
    {
        construction.Build();
    }
}

public class Architect : ConstructionDecorator
{
    public Architect(IConstruction construction) : base(construction) { }

    public override void Build()
    {
        base.Build();
        Console.WriteLine("Adding architectural design to the project.");
    }
}

public class Contractor : ConstructionDecorator
{
    public Contractor(IConstruction construction) : base(construction) { }

    public override void Build()
    {
        base.Build();
        Console.WriteLine("Building the house.");
    }
}

public interface ICommand
{
    void Execute();
}

public class StartConstructionCommand : ICommand
{
    private ConstructionCompany company;

    public StartConstructionCommand(ConstructionCompany company)
    {
        this.company = company;
    }

    public void Execute()
    {
        company.StartConstruction();
    }
}

public class CompleteConstructionCommand : ICommand
{
    private ConstructionCompany company;

    public CompleteConstructionCommand(ConstructionCompany company)
    {
        this.company = company;
    }

    public void Execute()
    {
        company.CompleteConstruction();
    }
}

// Использование паттернов
class Program
{
    static void Main(string[] args)
    {
        // Создание компании
        ConstructionCompany company = ConstructionCompany.Instance;

        // Создание проекта строительства
        IConstruction construction = new Construction();

        // Добавление архитектурного дизайна в проект
        construction = new Architect(construction);

        // Передача объектов командам
        ICommand startCommand = new StartConstructionCommand(company);
        ICommand completeCommand = new CompleteConstructionCommand(company);

        // Добавление подрядчика в проект
        construction = new Contractor(construction);

        // Выполнение команд на начало и завершение строительства
        startCommand.Execute();
        construction.Build();
        completeCommand.Execute();
    }
}
