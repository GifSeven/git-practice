using System;


public abstract class CookingProcess
{
    protected string Ingredients { get; }

    public CookingProcess(string ingredients)
    {
        Ingredients = ingredients;
    }

    public void Cook()
    {
        PrepareIngredients();
        CookCore();
        Serve();
    }
    protected void PrepareIngredients()
    {
        Console.WriteLine($"Подготовка ингредиентов: {Ingredients}");
    }

    protected abstract void CookCore();

    protected void Serve()
    {
        Console.WriteLine("Подача готового блюда.");
    }
}
public class Soup : CookingProcess
{
    public Soup() : base("Картофель, морковь, лук, вода, соль") { }

    protected override void CookCore()
    {
        Console.WriteLine("Суп варится на медленном огне.");
    }
}

public class Steak : CookingProcess
{
    public Steak() : base("Говядина, соль, перец, масло") { }

    protected override void CookCore()
    {
        Console.WriteLine("Стейк жарится на сковороде до золотистой корочки.");
    }
}

