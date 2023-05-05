using Kata.App;

namespace Kata.Tests.Steps;

[Binding]
public class Battle
{
    private readonly Pokemon? _battlingPokemon;

    public Battle(Pokemon battlingPokemon)
    {
        _battlingPokemon = battlingPokemon;
    }


    [Scope(Feature = "Battle")]
    [Given(@"(.*) has (\d*) HP")]
    public void GivenThePokemonInBattleHasThatManyHp(string pokemonName, int healthPoints)
    {
        _battlingPokemon!.Name = pokemonName;
        _battlingPokemon!.HealthPoints = healthPoints;
        _battlingPokemon!.Location = Location.Battle;
    }
}