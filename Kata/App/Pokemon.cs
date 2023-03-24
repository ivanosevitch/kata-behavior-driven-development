namespace Kata.App;

public class Pokemon
{
    public string Name { get; init; } = "MissingNo.";
    public int HealthPoints { get; set; } = 10;

    public void DrinkPotion()
    {
        HealthPoints += 20;
    }
}