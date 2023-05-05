using Kata.App;

namespace Kata.Tests.Steps;

[Binding]
public class Field
{
    private readonly Pokemon? _battlingPokemon;

    public Field(Pokemon battlingPokemon)
    {
        _battlingPokemon = battlingPokemon;
    }

    [Scope(Feature = "Field")]
    [Given(@"(.*) has (\d*) HP")]
    public void GivenThePokemonInTheFieldHasThatManyHp(string pokemonName, int healthPoints)
    {
        _battlingPokemon!.Name = pokemonName;
        _battlingPokemon!.HealthPoints = healthPoints;
        _battlingPokemon!.Location = Location.Field;
    }
}