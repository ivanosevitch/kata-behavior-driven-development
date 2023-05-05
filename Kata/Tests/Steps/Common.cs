using FluentAssertions;
using Kata.App;

namespace Kata.Tests.Steps;

[Binding]
public class Common
{
    private Attack? _attack;
    private readonly Pokemon? _battlingPokemon;

    public Common(Pokemon battlingPokemon)
    {
        _battlingPokemon = battlingPokemon;
    }

    [Given(@"(.*) has (\d*) maximum HP")]
    public void GivenThePokemonHasTheseMaximumHp(string pokemonName, int maximumHeathPoints)
    {
        ThrowIfPokemonIsNotBattling(pokemonName);
        _battlingPokemon!.MaximumHealthPoints = maximumHeathPoints;
    }

    [Given(@"the attack (.*) has a power of (\d*)")]
    public void GivenTheAttackHasAPowerOf(string attackName, int attackPower)
    {
        _attack = new Attack { Name = attackName, Power = attackPower };
    }

    [When(@"(.*) drinks a potion")]
    public void WhenThePokemonDrinksAPotion(string pokemonName)
    {
        ThrowIfPokemonIsNotBattling(pokemonName);
        _battlingPokemon!.DrinkPotion();
    }

    [When(@"(.*) is attacked with (.*)")]
    public void WhenThePokemonIsAttackedWith(string pokemonName, string attackName)
    {
        ThrowIfPokemonIsNotBattling(pokemonName);
        if (_attack is null || _attack.Name != attackName)
            throw new ArgumentException($"{attackName} does not exist.");

        _battlingPokemon!.IsAttackedWith(_attack);
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