namespace Kata.App;

public class Pokemon
{
    public string Name { get; set; } = "MissingNo.";
    public int HealthPoints { get; set; } = 10;
    public int MaximumHealthPoints { get; set; } = 1000;
    public Location Location { get; set; } = Location.Battle;

    public void DrinkPotion()
    {
        var potionHealing = Location switch
        {
            Location.Battle => 20,
            Location.Field => 30,
            _ => throw new ArgumentOutOfRangeException()
        };

        HealthPoints = Math.Min(HealthPoints + potionHealing, MaximumHealthPoints);
    }

    public void IsAttackedWith(Attack attack)
    {
        HealthPoints = Math.Max(HealthPoints - attack.Power, 0);
    }
}