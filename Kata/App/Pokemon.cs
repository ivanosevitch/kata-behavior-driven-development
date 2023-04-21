﻿namespace Kata.App;

public class Pokemon
{
    public string Name { get; init; } = "MissingNo.";
    public int HealthPoints { get; set; } = 10;
    public int MaximumHealthPoints { get; set; } = 1000;

    public void DrinkPotion()
    {
        const int potionHealing = 20;
        HealthPoints = Math.Min(HealthPoints + potionHealing, MaximumHealthPoints);
    }
}