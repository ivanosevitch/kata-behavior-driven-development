using FluentAssertions;
using Kata.App;

namespace Kata.Tests.Steps;

[Binding]
public class Battle
{
    private Pokemon? _battlingPokemon;

    [Given(@"(.*) has (\d*) HP")]
    public void GivenThePokemonHasThatManyHp(string pokemonName, int healthPoints)
    {
        _battlingPokemon = new Pokemon { Name = pokemonName, HealthPoints = healthPoints };
    }

    [Given(@"(.*) has (\d*) maximum HP")]
    public void GivenThePokemonHasTheseMaximumHp(string pokemonName, int maximumHeathPoints)
    {
        ThrowIfPokemonIsNotBattling(pokemonName);
        _battlingPokemon!.MaximumHealthPoints = maximumHeathPoints;
    }

    [When(@"(.*) drinks a potion")]
    public void WhenThePokemonDrinksAPotion(string pokemonName)
    {
        ThrowIfPokemonIsNotBattling(pokemonName);
        _battlingPokemon!.DrinkPotion();
    }

    [Then(@"(.*) should have (\d*) HP")]
    public void ThenThePokemonShouldHaveThatManyHp(string pokemonName, int healthPoints)
    {
        ThrowIfPokemonIsNotBattling(pokemonName);
        healthPoints.Should().Be(_battlingPokemon!.HealthPoints);
    }

    private void ThrowIfPokemonIsNotBattling(string pokemonName)
    {
        if (_battlingPokemon is null)
            throw new ArgumentException("No Pokémon is battling.");
        if (_battlingPokemon.Name != pokemonName)
            throw new ArgumentException($"{pokemonName} is not battling.");
    }
}